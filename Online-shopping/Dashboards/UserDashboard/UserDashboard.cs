using Online_shopping.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_shopping.Dashboards.UserDashboard
{
    public partial class UserDashboard : Form
    {
        private string username1;
        public PlaceOrder PlaceOrderForm { get; set; }

        public UserDashboard()
        {
            InitializeComponent();
        }

        public UserDashboard(string username1)
        {
            this.username1 = username1;
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
          
           
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }
    }
}
