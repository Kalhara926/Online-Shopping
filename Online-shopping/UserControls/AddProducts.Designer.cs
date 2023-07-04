
namespace Online_shopping.UserControls
{
    partial class AddProducts
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.ProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.ProductPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.ProductCategory = new Guna.UI.WinForms.GunaComboBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Poppins Medium", 24F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(261, 35);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(315, 56);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Add New Product";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.gunaLabel2.Location = new System.Drawing.Point(255, 211);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(129, 28);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Product Name";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // ProductName
            // 
            this.ProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductName.DefaultText = "";
            this.ProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductName.DisabledState.Parent = this.ProductName;
            this.ProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductName.FocusedState.Parent = this.ProductName;
            this.ProductName.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.ProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductName.HoverState.Parent = this.ProductName;
            this.ProductName.Location = new System.Drawing.Point(255, 244);
            this.ProductName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ProductName.Name = "ProductName";
            this.ProductName.PasswordChar = '\0';
            this.ProductName.PlaceholderText = "";
            this.ProductName.SelectedText = "";
            this.ProductName.ShadowDecoration.Parent = this.ProductName;
            this.ProductName.Size = new System.Drawing.Size(345, 48);
            this.ProductName.TabIndex = 1;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.gunaLabel3.Location = new System.Drawing.Point(255, 318);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(82, 28);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "Price ($)";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // ProductPrice
            // 
            this.ProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductPrice.DefaultText = "";
            this.ProductPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductPrice.DisabledState.Parent = this.ProductPrice;
            this.ProductPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductPrice.FocusedState.Parent = this.ProductPrice;
            this.ProductPrice.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.ProductPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductPrice.HoverState.Parent = this.ProductPrice;
            this.ProductPrice.Location = new System.Drawing.Point(255, 351);
            this.ProductPrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.PasswordChar = '\0';
            this.ProductPrice.PlaceholderText = "";
            this.ProductPrice.SelectedText = "";
            this.ProductPrice.ShadowDecoration.Parent = this.ProductPrice;
            this.ProductPrice.Size = new System.Drawing.Size(340, 48);
            this.ProductPrice.TabIndex = 1;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.gunaLabel4.Location = new System.Drawing.Point(255, 116);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(87, 28);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "Category";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // ProductCategory
            // 
            this.ProductCategory.BackColor = System.Drawing.Color.Transparent;
            this.ProductCategory.BaseColor = System.Drawing.Color.White;
            this.ProductCategory.BorderColor = System.Drawing.Color.Silver;
            this.ProductCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductCategory.FocusedColor = System.Drawing.Color.Empty;
            this.ProductCategory.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.ProductCategory.ForeColor = System.Drawing.Color.Black;
            this.ProductCategory.FormattingEnabled = true;
            this.ProductCategory.Items.AddRange(new object[] {
            "Soft Drink",
            "Foods"});
            this.ProductCategory.Location = new System.Drawing.Point(255, 147);
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProductCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ProductCategory.Size = new System.Drawing.Size(350, 28);
            this.ProductCategory.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(335, 441);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(180, 48);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ProductCategory);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "AddProducts";
            this.Size = new System.Drawing.Size(908, 608);
            this.Load += new System.EventHandler(this.AddProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2TextBox ProductName;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2TextBox ProductPrice;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaComboBox ProductCategory;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
    }
}
