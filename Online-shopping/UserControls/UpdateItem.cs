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
    public partial class UpdateItem : UserControl
    {
        DBFunction fn = new DBFunction();
        String query;

        public UpdateItem()
        {
            InitializeComponent();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            query = "select * from Products ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * from Products where Pname like '" + searchBox.Text + "%' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];


        }

        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String ProductName = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());

            productName.Text = ProductName;
            unitPrice.Text = price.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "UPDATE Products set Pname = '" + productName.Text + "', Price = '"+ unitPrice.Text+ "', PType = '"+ ProductCategory.Text+ "' where PCode = "+id+"";
            fn.updateData(query);
            loadData();
            clearAll();
        }
        public void clearAll()
        {
            ProductCategory.SelectedIndex = -1;
            productName.Clear();
            unitPrice.Clear();
        }
    }
}
