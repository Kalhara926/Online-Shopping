
namespace Online_shopping.Dashboards
{
    partial class AdminDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.Users = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnProducts = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.dashboard1 = new Online_shopping.Dashboard();
            this.homeScreen1 = new Online_shopping.UserControls.HomeScreen();
            this.removeItem1 = new Online_shopping.UserControls.RemoveItem();
            this.updateItem1 = new Online_shopping.UserControls.UpdateItem();
            this.addProducts1 = new Online_shopping.UserControls.AddProducts();
            this.users1 = new Online_shopping.UserControls.Users();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.guna2Panel2.Controls.Add(this.gunaLinkLabel1);
            this.guna2Panel2.Controls.Add(this.Users);
            this.guna2Panel2.Controls.Add(this.btnRemove);
            this.guna2Panel2.Controls.Add(this.btnUpdate);
            this.guna2Panel2.Controls.Add(this.btnProducts);
            this.guna2Panel2.Controls.Add(this.btnDashboard);
            this.guna2Panel2.Location = new System.Drawing.Point(-1, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(207, 608);
            this.guna2Panel2.TabIndex = 0;
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Poppins", 10F);
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.White;
            this.gunaLinkLabel1.Location = new System.Drawing.Point(60, 559);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(65, 25);
            this.gunaLinkLabel1.TabIndex = 1;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "Log Out";
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // Users
            // 
            this.Users.BorderRadius = 8;
            this.Users.CheckedState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Users.CheckedState.ForeColor = System.Drawing.Color.White;
            this.Users.CheckedState.Parent = this.Users;
            this.Users.CustomImages.Parent = this.Users;
            this.Users.FillColor = System.Drawing.SystemColors.ControlText;
            this.Users.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.Users.ForeColor = System.Drawing.Color.White;
            this.Users.HoverState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Users.HoverState.ForeColor = System.Drawing.Color.White;
            this.Users.HoverState.Parent = this.Users;
            this.Users.Location = new System.Drawing.Point(22, 420);
            this.Users.Name = "Users";
            this.Users.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Users.ShadowDecoration.Parent = this.Users;
            this.Users.Size = new System.Drawing.Size(195, 53);
            this.Users.TabIndex = 0;
            this.Users.Text = "Users";
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BorderRadius = 8;
            this.btnRemove.CheckedState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRemove.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.btnRemove.FillColor = System.Drawing.SystemColors.ControlText;
            this.btnRemove.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRemove.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Location = new System.Drawing.Point(22, 340);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(195, 53);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 8;
            this.btnUpdate.CheckedState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(22, 264);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(195, 53);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update Item";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BorderRadius = 8;
            this.btnProducts.CheckedState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProducts.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnProducts.CheckedState.Parent = this.btnProducts;
            this.btnProducts.CustomImages.Parent = this.btnProducts;
            this.btnProducts.FillColor = System.Drawing.SystemColors.ControlText;
            this.btnProducts.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.HoverState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProducts.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnProducts.HoverState.Parent = this.btnProducts;
            this.btnProducts.Location = new System.Drawing.Point(22, 188);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.ShadowDecoration.Parent = this.btnProducts;
            this.btnProducts.Size = new System.Drawing.Size(195, 53);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Add Item";
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BorderRadius = 8;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.SystemColors.ControlText;
            this.btnDashboard.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Location = new System.Drawing.Point(22, 112);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(195, 53);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.dashboard1);
            this.guna2Panel3.Controls.Add(this.homeScreen1);
            this.guna2Panel3.Controls.Add(this.removeItem1);
            this.guna2Panel3.Controls.Add(this.updateItem1);
            this.guna2Panel3.Controls.Add(this.addProducts1);
            this.guna2Panel3.Controls.Add(this.users1);
            this.guna2Panel3.Location = new System.Drawing.Point(212, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(904, 608);
            this.guna2Panel3.TabIndex = 1;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.Lavender;
            this.dashboard1.Location = new System.Drawing.Point(-7, -3);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(908, 608);
            this.dashboard1.TabIndex = 0;
            this.dashboard1.Load += new System.EventHandler(this.dashboard1_Load);
            // 
            // homeScreen1
            // 
            this.homeScreen1.Location = new System.Drawing.Point(-4, 0);
            this.homeScreen1.Name = "homeScreen1";
            this.homeScreen1.Size = new System.Drawing.Size(904, 608);
            this.homeScreen1.TabIndex = 4;
            // 
            // removeItem1
            // 
            this.removeItem1.BackColor = System.Drawing.Color.Lavender;
            this.removeItem1.Location = new System.Drawing.Point(-3, 2);
            this.removeItem1.Name = "removeItem1";
            this.removeItem1.Size = new System.Drawing.Size(908, 608);
            this.removeItem1.TabIndex = 3;
            // 
            // updateItem1
            // 
            this.updateItem1.BackColor = System.Drawing.Color.Lavender;
            this.updateItem1.Location = new System.Drawing.Point(-7, 0);
            this.updateItem1.Name = "updateItem1";
            this.updateItem1.Size = new System.Drawing.Size(908, 608);
            this.updateItem1.TabIndex = 2;
            // 
            // addProducts1
            // 
            this.addProducts1.BackColor = System.Drawing.Color.Lavender;
            this.addProducts1.Location = new System.Drawing.Point(-4, 0);
            this.addProducts1.Name = "addProducts1";
            this.addProducts1.Size = new System.Drawing.Size(908, 608);
            this.addProducts1.TabIndex = 1;
            // 
            // users1
            // 
            this.users1.BackColor = System.Drawing.Color.Lavender;
            this.users1.Location = new System.Drawing.Point(-3, 2);
            this.users1.Name = "users1";
            this.users1.Size = new System.Drawing.Size(904, 608);
            this.users1.TabIndex = 5;
            // 
            // AdminDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(1120, 609);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnProducts;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Dashboard dashboard1;
        private UserControls.AddProducts addProducts1;
        private UserControls.RemoveItem removeItem1;
        private UserControls.UpdateItem updateItem1;
        private UserControls.HomeScreen homeScreen1;
        private Guna.UI2.WinForms.Guna2Button Users;
        private UserControls.Users users1;
    }
}