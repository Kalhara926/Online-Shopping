using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_shopping.Dashboards
{
    public partial class AdminDashboardForm : Form
    {
       
        public AdminDashboardForm()
        {
            InitializeComponent();
            

        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            homeScreen1.Visible = false;
            addProducts1.Visible = false;
            dashboard1.Visible = true;
            updateItem1.Visible = false;
            removeItem1.Visible = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            dashboard1.BringToFront();
        }

        private void AdminDashboardForm_Load_1(object sender, EventArgs e)
        {
            homeScreen1.Visible = false;
            addProducts1.Visible = false;
            dashboard1.Visible = true;
            updateItem1.Visible = false;
            removeItem1.Visible = false;

        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            addProducts1.Visible = true;
            addProducts1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateItem1.Visible = true;
            updateItem1.BringToFront();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeItem1.Visible = true;
            removeItem1.BringToFront();
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void Users_Click(object sender, EventArgs e)
        {
            users1.Visible = true;
            users1.BringToFront();
        }
    }
}
