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
    public partial class AddProducts : UserControl
    {
        DBFunction fn = new DBFunction();
        String query;
        public AddProducts()
        {
            InitializeComponent();
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ProductCategory.Text != "" || ProductName.Text != "0" || ProductPrice.Text != "0")
            {
                query = "Insert into Products(Pname,Price,PType) Values('" + ProductName.Text + "','" + ProductPrice.Text + "','" + ProductCategory.Text + "')";
                fn.setData(query);
                clearAll();
            }
            else
            {
                MessageBox.Show("Please select a product and quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clearAll()
        {
            ProductCategory.SelectedIndex = -1;
            ProductName.Clear();
            ProductPrice.Clear();
        }
    }
}
