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
    public partial class Users : UserControl
    {
        DBFunction fn = new DBFunction();
        String query;
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            string query = "SELECT UId, Uname, Urole FROM Users WHERE Urole = 'user'";
            DataSet ds = fn.getData(query);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Assign the DataTable to the DataSource of the DataGridView
                guna2DataGridView1.DataSource = ds.Tables[0];

                // Rename the columns in the DataGridView if desired
                guna2DataGridView1.Columns[0].HeaderText = "User ID";
                guna2DataGridView1.Columns[1].HeaderText = "Username";
                guna2DataGridView1.Columns[2].HeaderText = "Role";
            }
            else
            {
                guna2DataGridView1.DataSource = null;
                MessageBox.Show("No users found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void removeUser_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];
                // Get the OrderId from the selected row
                int userId = Convert.ToInt32(selectedRow.Cells["UId"].Value);

                // Ask for confirmation before deleting the order
                DialogResult result = MessageBox.Show("Are you sure you want to delete this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    guna2DataGridView1.Rows.Remove(selectedRow);
                    string deleteQuery = "DELETE FROM Users WHERE UId = " + userId;
                    fn.deleteData(deleteQuery);
                   
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
