using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_shopping.UserControls
{
    public partial class RemoveItem : UserControl
    {
        DBFunction fn = new DBFunction();
        String query;

        public RemoveItem()
        {
            InitializeComponent();
        }

        private void RemoveItem_Load(object sender, EventArgs e)
        {
            loadData();
        }

        //Load Product Details to the DataGridView..................
        public void loadData()
        {
            
            string query = "SELECT PCode, Pname, Price,PType FROM Products";
            DataSet ds = fn.getData(query);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                guna2DataGridView1.DataSource = null;
                MessageBox.Show("No Item found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        //Create a query for when search 
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * from Products where Pname like '" + searchBox.Text + "%' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        //get the Product Item from datagrid and delete it...........
        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

        }

        // Delete Selected Item by using ID....... 
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            query = "delete from Products where PCode = '" + id + "'";
            fn.deleteData(query);
            loadData();
        }

    }
}
