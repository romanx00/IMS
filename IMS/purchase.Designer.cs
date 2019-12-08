namespace IMS
{
    partial class purchase
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPurTotal = new System.Windows.Forms.Label();
            this.lblPriceSelect = new System.Windows.Forms.Label();
            this.lblCategorySelection = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.cbEmpName = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductQty = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPurTotal);
            this.panel1.Controls.Add(this.lblPriceSelect);
            this.panel1.Controls.Add(this.lblCategorySelection);
            this.panel1.Controls.Add(this.cbDepartment);
            this.panel1.Controls.Add(this.cbEmpName);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cbProductName);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblProductQty);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 437);
            this.panel1.TabIndex = 0;
            // 
            // lblPurTotal
            // 
            this.lblPurTotal.AutoSize = true;
            this.lblPurTotal.Location = new System.Drawing.Point(191, 132);
            this.lblPurTotal.Name = "lblPurTotal";
            this.lblPurTotal.Size = new System.Drawing.Size(10, 13);
            this.lblPurTotal.TabIndex = 45;
            this.lblPurTotal.Text = ".";
            // 
            // lblPriceSelect
            // 
            this.lblPriceSelect.AutoSize = true;
            this.lblPriceSelect.Location = new System.Drawing.Point(191, 94);
            this.lblPriceSelect.Name = "lblPriceSelect";
            this.lblPriceSelect.Size = new System.Drawing.Size(10, 13);
            this.lblPriceSelect.TabIndex = 44;
            this.lblPriceSelect.Text = ".";
            // 
            // lblCategorySelection
            // 
            this.lblCategorySelection.AutoSize = true;
            this.lblCategorySelection.Location = new System.Drawing.Point(191, 284);
            this.lblCategorySelection.Name = "lblCategorySelection";
            this.lblCategorySelection.Size = new System.Drawing.Size(10, 13);
            this.lblCategorySelection.TabIndex = 43;
            this.lblCategorySelection.Text = ".";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(106, 238);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(260, 21);
            this.cbDepartment.TabIndex = 42;
            // 
            // cbEmpName
            // 
            this.cbEmpName.FormattingEnabled = true;
            this.cbEmpName.Location = new System.Drawing.Point(106, 204);
            this.cbEmpName.Name = "cbEmpName";
            this.cbEmpName.Size = new System.Drawing.Size(260, 21);
            this.cbEmpName.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // cbProductName
            // 
            this.cbProductName.FormattingEnabled = true;
            this.cbProductName.Location = new System.Drawing.Point(106, 17);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(260, 21);
            this.cbProductName.TabIndex = 38;
            this.cbProductName.SelectedIndexChanged += new System.EventHandler(this.cbProductName_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(149, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 23);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Purchase";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Category ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Department ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Employee Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 169);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(78, 13);
            this.lblDate.TabIndex = 27;
            this.lblDate.Text = "Purchase Date";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(15, 132);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(79, 13);
            this.lbltotal.TabIndex = 25;
            this.lbltotal.Text = "Purchase Total";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(15, 94);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 13);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "Product Price";
            // 
            // lblProductQty
            // 
            this.lblProductQty.AutoSize = true;
            this.lblProductQty.Location = new System.Drawing.Point(15, 55);
            this.lblProductQty.Name = "lblProductQty";
            this.lblProductQty.Size = new System.Drawing.Size(46, 13);
            this.lblProductQty.TabIndex = 21;
            this.lblProductQty.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(106, 55);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(260, 20);
            this.txtQuantity.TabIndex = 20;
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave_1);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(15, 17);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 19;
            this.lblProductName.Text = "Product Name";
            // 
            // purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 494);
            this.Controls.Add(this.panel1);
            this.Name = "purchase";
            this.Text = "purchase";
            this.Load += new System.EventHandler(this.purchase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductQty;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox cbProductName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbEmpName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lblCategorySelection;
        private System.Windows.Forms.Label lblPriceSelect;
        private System.Windows.Forms.Label lblPurTotal;
    }
}