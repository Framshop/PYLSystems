namespace PYLsystems
{
    partial class frmStockInSupplyEdit
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
            this.txtStockInQuantity = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblStockInQuantity = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblActive = new System.Windows.Forms.Label();
            this.cboActive = new System.Windows.Forms.ComboBox();
            this.lblSupplyID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStockInQuantity
            // 
            this.txtStockInQuantity.Location = new System.Drawing.Point(146, 90);
            this.txtStockInQuantity.Name = "txtStockInQuantity";
            this.txtStockInQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtStockInQuantity.TabIndex = 0;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(146, 128);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 1;
            // 
            // lblStockInQuantity
            // 
            this.lblStockInQuantity.AutoSize = true;
            this.lblStockInQuantity.Location = new System.Drawing.Point(35, 97);
            this.lblStockInQuantity.Name = "lblStockInQuantity";
            this.lblStockInQuantity.Size = new System.Drawing.Size(89, 13);
            this.lblStockInQuantity.TabIndex = 2;
            this.lblStockInQuantity.Text = "Stock In Quantity";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(35, 135);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 3;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(38, 173);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(35, 58);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(37, 13);
            this.lblActive.TabIndex = 5;
            this.lblActive.Text = "Active";
            // 
            // cboActive
            // 
            this.cboActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActive.FormattingEnabled = true;
            this.cboActive.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboActive.Location = new System.Drawing.Point(146, 49);
            this.cboActive.Name = "cboActive";
            this.cboActive.Size = new System.Drawing.Size(100, 21);
            this.cboActive.TabIndex = 6;
            // 
            // lblSupplyID
            // 
            this.lblSupplyID.AutoSize = true;
            this.lblSupplyID.Location = new System.Drawing.Point(143, 178);
            this.lblSupplyID.Name = "lblSupplyID";
            this.lblSupplyID.Size = new System.Drawing.Size(35, 13);
            this.lblSupplyID.TabIndex = 7;
            this.lblSupplyID.Text = "label1";
            // 
            // frmStockInSupplyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 247);
            this.Controls.Add(this.lblSupplyID);
            this.Controls.Add(this.cboActive);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblStockInQuantity);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtStockInQuantity);
            this.Name = "frmStockInSupplyEdit";
            this.Text = "Stock In Supply Edit";
            this.Load += new System.EventHandler(this.frmStockInSupplyEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStockInQuantity;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.ComboBox cboActive;
        public System.Windows.Forms.Label lblSupplyID;
        public System.Windows.Forms.TextBox txtStockInQuantity;
        public System.Windows.Forms.TextBox txtUnitPrice;
    }
}