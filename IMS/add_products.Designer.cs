namespace IMS
{
    partial class add_products
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
            this.lblBarccode = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProduct = new System.Windows.Forms.Button();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.cbDep = new System.Windows.Forms.ComboBox();
            this.cbSup = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBarccode
            // 
            this.lblBarccode.AutoSize = true;
            this.lblBarccode.Location = new System.Drawing.Point(78, 38);
            this.lblBarccode.Name = "lblBarccode";
            this.lblBarccode.Size = new System.Drawing.Size(47, 13);
            this.lblBarccode.TabIndex = 0;
            this.lblBarccode.Text = "Barcode";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(78, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 20);
            this.textBox2.TabIndex = 4;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(78, 129);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(32, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Desc";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(141, 129);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(263, 20);
            this.textBox4.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(61, 172);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(61, 216);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 9;
            this.lblDepartment.Text = "Department";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(61, 259);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(45, 13);
            this.lblSupplier.TabIndex = 11;
            this.lblSupplier.Text = "Supplier";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbSup);
            this.panel1.Controls.Add(this.cbDep);
            this.panel1.Controls.Add(this.cbCat);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.lblSupplier);
            this.panel1.Controls.Add(this.lblDepartment);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblBarccode);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 390);
            this.panel1.TabIndex = 0;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(515, 105);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(113, 23);
            this.btnProduct.TabIndex = 12;
            this.btnProduct.Text = "Add Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // cbCat
            // 
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(141, 172);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(263, 21);
            this.cbCat.TabIndex = 13;
            // 
            // cbDep
            // 
            this.cbDep.FormattingEnabled = true;
            this.cbDep.Location = new System.Drawing.Point(141, 216);
            this.cbDep.Name = "cbDep";
            this.cbDep.Size = new System.Drawing.Size(263, 21);
            this.cbDep.TabIndex = 14;
            // 
            // cbSup
            // 
            this.cbSup.FormattingEnabled = true;
            this.cbSup.Location = new System.Drawing.Point(141, 251);
            this.cbSup.Name = "cbSup";
            this.cbSup.Size = new System.Drawing.Size(263, 21);
            this.cbSup.TabIndex = 15;
            // 
            // add_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 704);
            this.Controls.Add(this.panel1);
            this.Name = "add_products";
            this.Text = "add_products";
            this.Load += new System.EventHandler(this.add_products_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBarccode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.ComboBox cbSup;
        private System.Windows.Forms.ComboBox cbDep;
        private System.Windows.Forms.ComboBox cbCat;
    }
}