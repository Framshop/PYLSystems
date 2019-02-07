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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblCurrentQuantity = new System.Windows.Forms.Label();
            this.lblSupplyName = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtCurrentQuantity = new System.Windows.Forms.TextBox();
            this.txtSupplyName = new System.Windows.Forms.TextBox();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtStockInQuantity
            // 
            this.txtStockInQuantity.Location = new System.Drawing.Point(146, 90);
            this.txtStockInQuantity.Name = "txtStockInQuantity";
            this.txtStockInQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtStockInQuantity.TabIndex = 0;
            this.txtStockInQuantity.TextChanged += new System.EventHandler(this.txtStockInQuantity_TextChanged);
            this.txtStockInQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockInQuantity_KeyPress);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(146, 128);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 1;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
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
            this.btnUpdate.Enabled = false;
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
            this.cboActive.SelectedIndexChanged += new System.EventHandler(this.cboActive_SelectedIndexChanged);
            // 
            // lblSupplyID
            // 
            this.lblSupplyID.AutoSize = true;
            this.lblSupplyID.Location = new System.Drawing.Point(53, 9);
            this.lblSupplyID.Name = "lblSupplyID";
            this.lblSupplyID.Size = new System.Drawing.Size(35, 13);
            this.lblSupplyID.TabIndex = 7;
            this.lblSupplyID.Text = "label1";
            this.lblSupplyID.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(119, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(266, 58);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(76, 13);
            this.lblSupplierName.TabIndex = 9;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // lblCurrentQuantity
            // 
            this.lblCurrentQuantity.AutoSize = true;
            this.lblCurrentQuantity.Location = new System.Drawing.Point(266, 135);
            this.lblCurrentQuantity.Name = "lblCurrentQuantity";
            this.lblCurrentQuantity.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentQuantity.TabIndex = 10;
            this.lblCurrentQuantity.Text = "Current Quantity";
            // 
            // lblSupplyName
            // 
            this.lblSupplyName.AutoSize = true;
            this.lblSupplyName.Location = new System.Drawing.Point(266, 97);
            this.lblSupplyName.Name = "lblSupplyName";
            this.lblSupplyName.Size = new System.Drawing.Size(70, 13);
            this.lblSupplyName.TabIndex = 11;
            this.lblSupplyName.Text = "Supply Name";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Enabled = false;
            this.txtSupplierName.Location = new System.Drawing.Point(362, 51);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(153, 20);
            this.txtSupplierName.TabIndex = 12;
            // 
            // txtCurrentQuantity
            // 
            this.txtCurrentQuantity.Enabled = false;
            this.txtCurrentQuantity.Location = new System.Drawing.Point(362, 128);
            this.txtCurrentQuantity.Name = "txtCurrentQuantity";
            this.txtCurrentQuantity.Size = new System.Drawing.Size(153, 20);
            this.txtCurrentQuantity.TabIndex = 13;
            // 
            // txtSupplyName
            // 
            this.txtSupplyName.Enabled = false;
            this.txtSupplyName.Location = new System.Drawing.Point(362, 90);
            this.txtSupplyName.Name = "txtSupplyName";
            this.txtSupplyName.Size = new System.Drawing.Size(153, 20);
            this.txtSupplyName.TabIndex = 14;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(266, 177);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(71, 13);
            this.lblDeliveryDate.TabIndex = 15;
            this.lblDeliveryDate.Text = "Delivery Date";
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Enabled = false;
            this.txtDeliveryDate.Location = new System.Drawing.Point(362, 170);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Size = new System.Drawing.Size(153, 20);
            this.txtDeliveryDate.TabIndex = 16;
            // 
            // frmStockInSupplyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(555, 242);
            this.ControlBox = false;
            this.Controls.Add(this.txtDeliveryDate);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.txtSupplyName);
            this.Controls.Add(this.txtCurrentQuantity);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.lblSupplyName);
            this.Controls.Add(this.lblCurrentQuantity);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.btnCancel);
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblCurrentQuantity;
        private System.Windows.Forms.Label lblSupplyName;
        public System.Windows.Forms.TextBox txtSupplierName;
        public System.Windows.Forms.TextBox txtCurrentQuantity;
        public System.Windows.Forms.TextBox txtSupplyName;
        private System.Windows.Forms.Label lblDeliveryDate;
        public System.Windows.Forms.TextBox txtDeliveryDate;
    }
}