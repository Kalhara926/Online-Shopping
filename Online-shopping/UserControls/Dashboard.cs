using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_shopping
{
    public partial class Dashboard : UserControl
    {
        DBFunction fn = new DBFunction();
        String query;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string query = "SELECT OrderDate, OrderID, UserID,ProductName, OrderTotal, Quantity FROM Orders";
            DataSet ds = fn.getData(query);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                guna2DataGridView1.DataSource = null;
                MessageBox.Show("No orders found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadTotalOrders();
            LoadTotalIncome();
            LoadDailyIncome();
            LoadDailyOrders();
        }

        //To get Total Orders Value....
        public void LoadTotalOrders()
        {
            string totalOrdersQuery = "SELECT COUNT(*) FROM Orders";
            DataSet ds = fn.getData(totalOrdersQuery);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int totalOrders = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                gunaLabel7.Text = totalOrders.ToString();

            }
            else
            {
                gunaLabel7.Text = "0";
            }
        }

        //To get Total Income Value....
        public void LoadTotalIncome()
        {
            string totalIncomeQuery = "SELECT FORMAT(SUM(OrderTotal), 'N2') FROM Orders"; 
            DataSet totalIncomeData = fn.getData(totalIncomeQuery);

            if (totalIncomeData.Tables.Count > 0 && totalIncomeData.Tables[0].Rows.Count > 0)
            {
                decimal totalIncome = Convert.ToDecimal(totalIncomeData.Tables[0].Rows[0][0]);
                gunaLabel2.Text = "$ "+totalIncome.ToString(); // Display as currency format
            }
            else
            {
                gunaLabel2.Text = "$0.00"; // or any default value you prefer
            }
        }

        //To get Daily Income....
        public void LoadDailyIncome()
        {
            string todayEarningQuery = "SELECT FORMAT(SUM(OrderTotal), 'N2' )FROM Orders WHERE CONVERT(date, OrderDate) = CONVERT(date, GETDATE())";
            DataSet todayEarningData = fn.getData(todayEarningQuery);

            if (todayEarningData.Tables.Count > 0 && todayEarningData.Tables[0].Rows.Count > 0)
            {
                decimal todayEarning = Convert.ToDecimal(todayEarningData.Tables[0].Rows[0][0]);
                gunaLabel3.Text = "$ "+ todayEarning.ToString(); // Display as currency format
            }
            else
            {
                gunaLabel3.Text = "$0.00"; // or any default value you prefer
            }
        }

        //To get Daily orders....
        public void LoadDailyOrders()
        {
            string todayOrdersQuery = "SELECT COUNT(*) FROM Orders WHERE CONVERT(date, OrderDate) = CONVERT(date, GETDATE())";
            DataSet todayOrdersData = fn.getData(todayOrdersQuery);

            if (todayOrdersData.Tables.Count > 0 && todayOrdersData.Tables[0].Rows.Count > 0)
            {
                int todayOrders = Convert.ToInt32(todayOrdersData.Tables[0].Rows[0][0]);
                gunaLabel5.Text = todayOrders.ToString();
            }
            else
            {
                gunaLabel5.Text = "0"; // or any default value you prefer
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];
                // Get the OrderId from the selected row
                int orderId = Convert.ToInt32(selectedRow.Cells["OrderId"].Value);

                // Ask for confirmation before deleting the order
                DialogResult result = MessageBox.Show("Are you sure you want to delete this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    guna2DataGridView1.Rows.Remove(selectedRow);
                    string deleteQuery = "DELETE FROM Orders WHERE OrderId = " + orderId;
                    fn.deleteData(deleteQuery);
                    LoadTotalOrders();
                    LoadTotalIncome();
                    LoadDailyIncome();
                    LoadDailyOrders();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }
    }
    }
