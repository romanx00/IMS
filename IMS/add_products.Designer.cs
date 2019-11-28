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
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSup = new System.Windows.Forms.ComboBox();
            this.cbDep = new System.Windows.Forms.ComboBox();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.btnProduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbEditSup = new System.Windows.Forms.ComboBox();
            this.cbEditDep = new System.Windows.Forms.ComboBox();
            this.cbEditCat = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEditBarcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
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
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(141, 38);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(263, 20);
            this.txtBarcode.TabIndex = 2;
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 20);
            this.txtName.TabIndex = 4;
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
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(141, 129);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(263, 20);
            this.txtDesc.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(452, 38);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(452, 82);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 9;
            this.lblDepartment.Text = "Department";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(452, 125);
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
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtBarcode);
            this.panel1.Controls.Add(this.lblBarccode);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 181);
            this.panel1.TabIndex = 0;
            // 
            // cbSup
            // 
            this.cbSup.FormattingEnabled = true;
            this.cbSup.Location = new System.Drawing.Point(532, 117);
            this.cbSup.Name = "cbSup";
            this.cbSup.Size = new System.Drawing.Size(263, 21);
            this.cbSup.TabIndex = 15;
            // 
            // cbDep
            // 
            this.cbDep.FormattingEnabled = true;
            this.cbDep.Location = new System.Drawing.Point(532, 82);
            this.cbDep.Name = "cbDep";
            this.cbDep.Size = new System.Drawing.Size(263, 21);
            this.cbDep.TabIndex = 14;
            // 
            // cbCat
            // 
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(532, 38);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(263, 21);
            this.cbCat.TabIndex = 13;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(922, 38);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(113, 23);
            this.btnProduct.TabIndex = 12;
            this.btnProduct.Text = "Add Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(721, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(747, 356);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbEditSup);
            this.panel2.Controls.Add(this.cbEditDep);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbEditCat);
            this.panel2.Controls.Add(this.txtEditBarcode);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtEditName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtEditDesc);
            this.panel2.Location = new System.Drawing.Point(12, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 356);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // cbEditSup
            // 
            this.cbEditSup.FormattingEnabled = true;
            this.cbEditSup.Location = new System.Drawing.Point(426, 101);
            this.cbEditSup.Name = "cbEditSup";
            this.cbEditSup.Size = new System.Drawing.Size(263, 21);
            this.cbEditSup.TabIndex = 28;
            // 
            // cbEditDep
            // 
            this.cbEditDep.FormattingEnabled = true;
            this.cbEditDep.Location = new System.Drawing.Point(426, 66);
            this.cbEditDep.Name = "cbEditDep";
            this.cbEditDep.Size = new System.Drawing.Size(263, 21);
            this.cbEditDep.TabIndex = 27;
            // 
            // cbEditCat
            // 
            this.cbEditCat.FormattingEnabled = true;
            this.cbEditCat.Location = new System.Drawing.Point(426, 22);
            this.cbEditCat.Name = "cbEditCat";
            this.cbEditCat.Size = new System.Drawing.Size(263, 21);
            this.cbEditCat.TabIndex = 26;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(264, 183);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 23);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Edit Product ";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Category";
            // 
            // txtEditDesc
            // 
            this.txtEditDesc.Location = new System.Drawing.Point(72, 107);
            this.txtEditDesc.Name = "txtEditDesc";
            this.txtEditDesc.Size = new System.Drawing.Size(263, 20);
            this.txtEditDesc.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Desc";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(72, 59);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(263, 20);
            this.txtEditName.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Name";
            // 
            // txtEditBarcode
            // 
            this.txtEditBarcode.Location = new System.Drawing.Point(72, 22);
            this.txtEditBarcode.Name = "txtEditBarcode";
            this.txtEditBarcode.Size = new System.Drawing.Size(263, 20);
            this.txtEditBarcode.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Barcode";
            // 
            // add_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "add_products";
            this.Text = "add_products";
            this.Load += new System.EventHandler(this.add_products_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBarccode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.ComboBox cbSup;
        private System.Windows.Forms.ComboBox cbDep;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbEditSup;
        private System.Windows.Forms.ComboBox cbEditDep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEditCat;
        private System.Windows.Forms.TextBox txtEditBarcode;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditDesc;
    }
}