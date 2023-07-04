
namespace Online_shopping.UserControls
{
    partial class PlaceOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Total = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProductQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.AddToCartbtn = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.productName = new Guna.UI2.WinForms.Guna2TextBox();
            this.unitPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.ProductListBox = new System.Windows.Forms.ListBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.category);
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.Controls.Add(this.ProductListBox);
            this.guna2Panel2.Controls.Add(this.gunaLabel6);
            this.guna2Panel2.Controls.Add(this.searchBox);
            this.guna2Panel2.FillColor = System.Drawing.Color.Lavender;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(904, 608);
            this.guna2Panel2.TabIndex = 2;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.Transparent;
            this.category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.category.FocusedState.Parent = this.category;
            this.category.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.category.HoverState.Parent = this.category;
            this.category.ItemHeight = 30;
            this.category.Items.AddRange(new object[] {
            "Foods",
            "Soft Drink"});
            this.category.ItemsAppearance.Parent = this.category;
            this.category.Location = new System.Drawing.Point(627, 52);
            this.category.Name = "category";
            this.category.ShadowDecoration.Parent = this.category;
            this.category.Size = new System.Drawing.Size(192, 36);
            this.category.TabIndex = 20;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.Total);
            this.guna2Panel1.Controls.Add(this.ProductQuantity);
            this.guna2Panel1.Controls.Add(this.AddToCartbtn);
            this.guna2Panel1.Controls.Add(this.gunaLabel5);
            this.guna2Panel1.Controls.Add(this.gunaLabel1);
            this.guna2Panel1.Controls.Add(this.gunaLabel3);
            this.guna2Panel1.Controls.Add(this.gunaLabel4);
            this.guna2Panel1.Controls.Add(this.productName);
            this.guna2Panel1.Controls.Add(this.unitPrice);
            this.guna2Panel1.Controls.Add(this.gunaLabel2);
            this.guna2Panel1.Location = new System.Drawing.Point(10, 11);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(566, 291);
            this.guna2Panel1.TabIndex = 19;
            // 
            // Total
            // 
            this.Total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Total.DefaultText = "";
            this.Total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Total.DisabledState.Parent = this.Total;
            this.Total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Total.FocusedState.Parent = this.Total;
            this.Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Total.HoverState.Parent = this.Total;
            this.Total.Location = new System.Drawing.Point(294, 174);
            this.Total.Name = "Total";
            this.Total.PasswordChar = '\0';
            this.Total.PlaceholderText = "";
            this.Total.ReadOnly = true;
            this.Total.SelectedText = "";
            this.Total.ShadowDecoration.Parent = this.Total;
            this.Total.Size = new System.Drawing.Size(200, 40);
            this.Total.TabIndex = 17;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.BackColor = System.Drawing.Color.Transparent;
            this.ProductQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductQuantity.DisabledState.Parent = this.ProductQuantity;
            this.ProductQuantity.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.ProductQuantity.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.ProductQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductQuantity.FocusedState.Parent = this.ProductQuantity;
            this.ProductQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductQuantity.Location = new System.Drawing.Point(63, 174);
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ShadowDecoration.Parent = this.ProductQuantity;
            this.ProductQuantity.Size = new System.Drawing.Size(194, 40);
            this.ProductQuantity.TabIndex = 18;
            this.ProductQuantity.ValueChanged += new System.EventHandler(this.ProductQuantity_ValueChanged);
            this.ProductQuantity.VisibleChanged += new System.EventHandler(this.ProductQuantity_VisibleChanged);
            // 
            // AddToCartbtn
            // 
            this.AddToCartbtn.CheckedState.Parent = this.AddToCartbtn;
            this.AddToCartbtn.CustomImages.Parent = this.AddToCartbtn;
            this.AddToCartbtn.FillColor = System.Drawing.SystemColors.HotTrack;
            this.AddToCartbtn.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCartbtn.ForeColor = System.Drawing.Color.White;
            this.AddToCartbtn.HoverState.Parent = this.AddToCartbtn;
            this.AddToCartbtn.Location = new System.Drawing.Point(346, 226);
            this.AddToCartbtn.Name = "AddToCartbtn";
            this.AddToCartbtn.ShadowDecoration.Parent = this.AddToCartbtn;
            this.AddToCartbtn.Size = new System.Drawing.Size(148, 48);
            this.AddToCartbtn.TabIndex = 13;
            this.AddToCartbtn.Text = "Place Order";
            this.AddToCartbtn.Click += new System.EventHandler(this.AddToCartbtn_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gunaLabel5.Location = new System.Drawing.Point(184, 14);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(168, 42);
            this.gunaLabel5.TabIndex = 16;
            this.gunaLabel5.Text = "Place Order";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(60, 71);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(96, 22);
            this.gunaLabel1.TabIndex = 16;
            this.gunaLabel1.Text = "Product Name";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(60, 147);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(61, 22);
            this.gunaLabel3.TabIndex = 16;
            this.gunaLabel3.Text = "Quantity";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(291, 147);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(40, 22);
            this.gunaLabel4.TabIndex = 16;
            this.gunaLabel4.Text = "Total";
            // 
            // productName
            // 
            this.productName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productName.DefaultText = "";
            this.productName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productName.DisabledState.Parent = this.productName;
            this.productName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productName.FocusedState.Parent = this.productName;
            this.productName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productName.HoverState.Parent = this.productName;
            this.productName.Location = new System.Drawing.Point(63, 99);
            this.productName.Name = "productName";
            this.productName.PasswordChar = '\0';
            this.productName.PlaceholderText = "";
            this.productName.ReadOnly = true;
            this.productName.SelectedText = "";
            this.productName.ShadowDecoration.Parent = this.productName;
            this.productName.Size = new System.Drawing.Size(200, 40);
            this.productName.TabIndex = 17;
            // 
            // unitPrice
            // 
            this.unitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unitPrice.DefaultText = "";
            this.unitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.unitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.unitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.unitPrice.DisabledState.Parent = this.unitPrice;
            this.unitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.unitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unitPrice.FocusedState.Parent = this.unitPrice;
            this.unitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.unitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unitPrice.HoverState.Parent = this.unitPrice;
            this.unitPrice.Location = new System.Drawing.Point(294, 99);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.PasswordChar = '\0';
            this.unitPrice.PlaceholderText = "";
            this.unitPrice.ReadOnly = true;
            this.unitPrice.SelectedText = "";
            this.unitPrice.ShadowDecoration.Parent = this.unitPrice;
            this.unitPrice.Size = new System.Drawing.Size(200, 40);
            this.unitPrice.TabIndex = 17;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(291, 71);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(65, 22);
            this.gunaLabel2.TabIndex = 16;
            this.gunaLabel2.Text = "Unit Price";
            // 
            // ProductListBox
            // 
            this.ProductListBox.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductListBox.FormattingEnabled = true;
            this.ProductListBox.ItemHeight = 22;
            this.ProductListBox.Location = new System.Drawing.Point(627, 191);
            this.ProductListBox.Name = "ProductListBox";
            this.ProductListBox.Size = new System.Drawing.Size(192, 312);
            this.ProductListBox.TabIndex = 15;
            this.ProductListBox.SelectedIndexChanged += new System.EventHandler(this.ProductListBox_SelectedIndexChanged);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(627, 25);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(66, 22);
            this.gunaLabel6.TabIndex = 16;
            this.gunaLabel6.Text = "Category";
            // 
            // searchBox
            // 
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.DisabledState.Parent = this.searchBox;
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.FocusedState.Parent = this.searchBox;
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.HoverState.Parent = this.searchBox;
            this.searchBox.Location = new System.Drawing.Point(627, 135);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderText = "";
            this.searchBox.SelectedText = "";
            this.searchBox.ShadowDecoration.Parent = this.searchBox;
            this.searchBox.Size = new System.Drawing.Size(192, 40);
            this.searchBox.TabIndex = 17;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel2);
            this.Name = "PlaceOrder";
            this.Size = new System.Drawing.Size(904, 608);
            this.Load += new System.EventHandler(this.PlaceOrder_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox category;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox Total;
        private Guna.UI2.WinForms.Guna2NumericUpDown ProductQuantity;
        private Guna.UI2.WinForms.Guna2Button AddToCartbtn;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI2.WinForms.Guna2TextBox productName;
        private Guna.UI2.WinForms.Guna2TextBox unitPrice;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.ListBox ProductListBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
    }
}
