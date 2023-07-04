using Online_shopping.Dashboards.UserDashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_shopping.UserControls
{
    public partial class PlaceOrder : UserControl
    {
        DBFunction fn = new DBFunction();
        String query;
       
        public string username { get; set; }
        public int userId;

        public PlaceOrder()
        {
            InitializeComponent();
        }
        
        // filter product selecting category....
        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            String categoryName = category.Text;
            query = "SELECT Pname from Products where PType = '" + categoryName + "'";
            showItemList(query);

        }

        //Search product using searching product name.....
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            ProductListBox.Items.Clear();
            String categoryName = category.Text;
            query = "SELECT Pname from Products where PType = '" + categoryName + "' and Pname like '"+ searchBox.Text+ "%' ";
            showItemList(query);
           
        }

        // Show all product item.....
        private void showItemList(string query)
        {
            ProductListBox.Items.Clear();
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ProductListBox.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void ProductListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductQuantity.ResetText();
            Total.Clear();

            String text = ProductListBox.GetItemText(ProductListBox.SelectedItem);
            productName.Text = text;

            query = "select Price from Products where Pname = '" + text + "' ";
            DataSet ds = fn.getData(query);
            try
            {
                unitPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        //Create a method for calculate the totla price when selecting quantity..............
        private void ProductQuantity_VisibleChanged(object sender, EventArgs e)
        {
        }

        
        private void ProductQuantity_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(ProductQuantity.Value.ToString());
            decimal price;
            if (decimal.TryParse(unitPrice.Text, out price))
            {
                // Parsing was successful, use the 'price' variable
                Total.Text = (quan * price).ToString();
            }
            else
            {
                // Parsing failed, handle the error appropriately
                MessageBox.Show("Invalid price value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Total.Text = (quan * price).ToString();
        }

        
        // Method to get UserId who is logged in the system by using Username.....
        private int GetUserIdByUsername(string username)
        {
            
            string query = "SELECT UId FROM Users WHERE Uname = '"+username+"' ";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                userId = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }

            return userId;
        }

        // Place order.......
        private void AddToCartbtn_Click(object sender, EventArgs e)
        {
            
             
            if (productName.Text != "" || unitPrice.Text != "0" || ProductQuantity.Text != "0" || Total.Text != "0")
            {
                int userId = GetUserIdByUsername(username);
                string uname = username;
                string productName = this.productName.Text;
                decimal orderTotal = decimal.Parse(unitPrice.Text) * ProductQuantity.Value;
                int quantity = (int)ProductQuantity.Value;
                DateTime orderDate = DateTime.Now;

                InsertOrder(userId, productName, orderDate, orderTotal, quantity);
                clearAll();
            }
            else
            {
                MessageBox.Show("Please select a product and quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Insert data to Order table......
        private void InsertOrder(int userId , string productName, DateTime orderDate, decimal orderTotal, int quantity)
        {
            string query = "INSERT INTO Orders (UserId, ProductName, OrderDate, OrderTotal, Quantity) " +
                           "VALUES ('" + userId + "','" + productName + "','" + orderDate + "','" + orderTotal + "','" + quantity + "')";

            fn.setData(query);
        }

        //Clear all Text Boxes After 
        public void clearAll()
        {
            productName.Clear();
            unitPrice.Clear();
            ProductQuantity.Value = 0;
            Total.Clear();
        }

        //To Display All Product when the system load....
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            query = "select Pname from Products";
            showItemList(query);

           
        }

        // to get user name in logged user....... 
        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            username = ((UserDashboard)ParentForm).PlaceOrderForm.username;
        }
    }
}
