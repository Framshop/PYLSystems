namespace PYLsystems
{
    partial class frmSupplyStockIn
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
            this.txtContactDetails = new System.Windows.Forms.TextBox();
            this.txtSupplierDetails = new System.Windows.Forms.TextBox();
            this.txtSupplyDescription = new System.Windows.Forms.TextBox();
            this.txtUnitMeasure = new System.Windows.Forms.TextBox();
            this.lblsupplierID = new System.Windows.Forms.Label();
            this.lbl_supply_itemsID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblSupply_Items = new System.Windows.Forms.Label();
            this.msktxtDeliveryDate = new System.Windows.Forms.MaskedTextBox();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.txtStockInQuantity = new System.Windows.Forms.TextBox();
            this.txtSupplyPrice = new System.Windows.Forms.TextBox();
            this.cboActive = new System.Windows.Forms.ComboBox();
            this.cboSupplierName = new System.Windows.Forms.ComboBox();
            this.cboSupplyName = new System.Windows.Forms.ComboBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblStockInQuantity = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataGridSupplyStockIn = new System.Windows.Forms.DataGridView();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblSupplyID = new System.Windows.Forms.Label();
            this.lblsupplyStockInQuantityUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblActiveUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSupplyStockIn)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContactDetails
            // 
            this.txtContactDetails.Enabled = false;
            this.txtContactDetails.Location = new System.Drawing.Point(36, 163);
            this.txtContactDetails.Name = "txtContactDetails";
            this.txtContactDetails.Size = new System.Drawing.Size(100, 20);
            this.txtContactDetails.TabIndex = 1;
            // 
            // txtSupplierDetails
            // 
            this.txtSupplierDetails.Enabled = false;
            this.txtSupplierDetails.Location = new System.Drawing.Point(36, 137);
            this.txtSupplierDetails.Name = "txtSupplierDetails";
            this.txtSupplierDetails.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierDetails.TabIndex = 2;
            // 
            // txtSupplyDescription
            // 
            this.txtSupplyDescription.Enabled = false;
            this.txtSupplyDescription.Location = new System.Drawing.Point(39, 287);
            this.txtSupplyDescription.Name = "txtSupplyDescription";
            this.txtSupplyDescription.Size = new System.Drawing.Size(100, 20);
            this.txtSupplyDescription.TabIndex = 5;
            // 
            // txtUnitMeasure
            // 
            this.txtUnitMeasure.Enabled = false;
            this.txtUnitMeasure.Location = new System.Drawing.Point(39, 313);
            this.txtUnitMeasure.Name = "txtUnitMeasure";
            this.txtUnitMeasure.Size = new System.Drawing.Size(100, 20);
            this.txtUnitMeasure.TabIndex = 4;
            // 
            // lblsupplierID
            // 
            this.lblsupplierID.AutoSize = true;
            this.lblsupplierID.Location = new System.Drawing.Point(93, 643);
            this.lblsupplierID.Name = "lblsupplierID";
            this.lblsupplierID.Size = new System.Drawing.Size(35, 13);
            this.lblsupplierID.TabIndex = 6;
            this.lblsupplierID.Text = "label1";
            // 
            // lbl_supply_itemsID
            // 
            this.lbl_supply_itemsID.AutoSize = true;
            this.lbl_supply_itemsID.Location = new System.Drawing.Point(93, 615);
            this.lbl_supply_itemsID.Name = "lbl_supply_itemsID";
            this.lbl_supply_itemsID.Size = new System.Drawing.Size(35, 13);
            this.lbl_supply_itemsID.TabIndex = 7;
            this.lbl_supply_itemsID.Text = "label2";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 489);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(36, 64);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(45, 13);
            this.lblSupplier.TabIndex = 9;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblSupply_Items
            // 
            this.lblSupply_Items.AutoSize = true;
            this.lblSupply_Items.Location = new System.Drawing.Point(36, 214);
            this.lblSupply_Items.Name = "lblSupply_Items";
            this.lblSupply_Items.Size = new System.Drawing.Size(67, 13);
            this.lblSupply_Items.TabIndex = 10;
            this.lblSupply_Items.Text = "Supply Items";
            // 
            // msktxtDeliveryDate
            // 
            this.msktxtDeliveryDate.Location = new System.Drawing.Point(118, 369);
            this.msktxtDeliveryDate.Mask = "0000-00-00 90:00";
            this.msktxtDeliveryDate.Name = "msktxtDeliveryDate";
            this.msktxtDeliveryDate.PromptChar = ' ';
            this.msktxtDeliveryDate.Size = new System.Drawing.Size(98, 20);
            this.msktxtDeliveryDate.TabIndex = 11;
            this.msktxtDeliveryDate.ValidatingType = typeof(System.DateTime);
            this.msktxtDeliveryDate.TextChanged += new System.EventHandler(this.msktxtDeliveryDate_TextChanged);
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(96, 582);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Size = new System.Drawing.Size(100, 20);
            this.txtDeliveryDate.TabIndex = 12;
            // 
            // txtStockInQuantity
            // 
            this.txtStockInQuantity.Location = new System.Drawing.Point(118, 422);
            this.txtStockInQuantity.Name = "txtStockInQuantity";
            this.txtStockInQuantity.Size = new System.Drawing.Size(98, 20);
            this.txtStockInQuantity.TabIndex = 13;
            // 
            // txtSupplyPrice
            // 
            this.txtSupplyPrice.Location = new System.Drawing.Point(118, 449);
            this.txtSupplyPrice.Name = "txtSupplyPrice";
            this.txtSupplyPrice.Size = new System.Drawing.Size(98, 20);
            this.txtSupplyPrice.TabIndex = 14;
            // 
            // cboActive
            // 
            this.cboActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActive.FormattingEnabled = true;
            this.cboActive.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboActive.Location = new System.Drawing.Point(118, 395);
            this.cboActive.Name = "cboActive";
            this.cboActive.Size = new System.Drawing.Size(98, 21);
            this.cboActive.TabIndex = 15;
            // 
            // cboSupplierName
            // 
            this.cboSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplierName.FormattingEnabled = true;
            this.cboSupplierName.Location = new System.Drawing.Point(36, 109);
            this.cboSupplierName.Name = "cboSupplierName";
            this.cboSupplierName.Size = new System.Drawing.Size(100, 21);
            this.cboSupplierName.TabIndex = 16;
            this.cboSupplierName.SelectedIndexChanged += new System.EventHandler(this.cboSupplierName_SelectedIndexChanged);
            // 
            // cboSupplyName
            // 
            this.cboSupplyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplyName.FormattingEnabled = true;
            this.cboSupplyName.Location = new System.Drawing.Point(39, 260);
            this.cboSupplyName.Name = "cboSupplyName";
            this.cboSupplyName.Size = new System.Drawing.Size(102, 21);
            this.cboSupplyName.TabIndex = 17;
            this.cboSupplyName.SelectedIndexChanged += new System.EventHandler(this.cboSupplyName_SelectedIndexChanged);
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(5, 402);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(37, 13);
            this.lblActive.TabIndex = 18;
            this.lblActive.Text = "Active";
            // 
            // lblStockInQuantity
            // 
            this.lblStockInQuantity.AutoSize = true;
            this.lblStockInQuantity.Location = new System.Drawing.Point(5, 429);
            this.lblStockInQuantity.Name = "lblStockInQuantity";
            this.lblStockInQuantity.Size = new System.Drawing.Size(88, 13);
            this.lblStockInQuantity.TabIndex = 19;
            this.lblStockInQuantity.Text = "Stock in Quantity";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(5, 456);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 20;
            this.lblUnitPrice.Text = "Unit Price";
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(109, 489);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dataGridSupplyStockIn
            // 
            this.dataGridSupplyStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSupplyStockIn.Location = new System.Drawing.Point(257, 12);
            this.dataGridSupplyStockIn.Name = "dataGridSupplyStockIn";
            this.dataGridSupplyStockIn.Size = new System.Drawing.Size(560, 725);
            this.dataGridSupplyStockIn.TabIndex = 22;
            this.dataGridSupplyStockIn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSupplyStockIn_CellClick);
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(2, 376);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(71, 13);
            this.lblDeliveryDate.TabIndex = 23;
            this.lblDeliveryDate.Text = "Delivery Date";
            // 
            // lblSupplyID
            // 
            this.lblSupplyID.AutoSize = true;
            this.lblSupplyID.Location = new System.Drawing.Point(25, 600);
            this.lblSupplyID.Name = "lblSupplyID";
            this.lblSupplyID.Size = new System.Drawing.Size(35, 13);
            this.lblSupplyID.TabIndex = 24;
            this.lblSupplyID.Text = "label1";
            // 
            // lblsupplyStockInQuantityUpdate
            // 
            this.lblsupplyStockInQuantityUpdate.AutoSize = true;
            this.lblsupplyStockInQuantityUpdate.Location = new System.Drawing.Point(25, 621);
            this.lblsupplyStockInQuantityUpdate.Name = "lblsupplyStockInQuantityUpdate";
            this.lblsupplyStockInQuantityUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblsupplyStockInQuantityUpdate.TabIndex = 25;
            this.lblsupplyStockInQuantityUpdate.Text = "label1";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(25, 643);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblUnitPriceUpdate.TabIndex = 26;
            this.lblUnitPriceUpdate.Text = "label2";
            // 
            // lblActiveUpdate
            // 
            this.lblActiveUpdate.AutoSize = true;
            this.lblActiveUpdate.Location = new System.Drawing.Point(25, 665);
            this.lblActiveUpdate.Name = "lblActiveUpdate";
            this.lblActiveUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblActiveUpdate.TabIndex = 27;
            this.lblActiveUpdate.Text = "label1";
            // 
            // frmSupplyStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 749);
            this.Controls.Add(this.lblActiveUpdate);
            this.Controls.Add(this.lblUnitPriceUpdate);
            this.Controls.Add(this.lblsupplyStockInQuantityUpdate);
            this.Controls.Add(this.lblSupplyID);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.dataGridSupplyStockIn);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblStockInQuantity);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.cboSupplyName);
            this.Controls.Add(this.cboSupplierName);
            this.Controls.Add(this.cboActive);
            this.Controls.Add(this.txtSupplyPrice);
            this.Controls.Add(this.txtStockInQuantity);
            this.Controls.Add(this.txtDeliveryDate);
            this.Controls.Add(this.msktxtDeliveryDate);
            this.Controls.Add(this.lblSupply_Items);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbl_supply_itemsID);
            this.Controls.Add(this.lblsupplierID);
            this.Controls.Add(this.txtSupplyDescription);
            this.Controls.Add(this.txtUnitMeasure);
            this.Controls.Add(this.txtSupplierDetails);
            this.Controls.Add(this.txtContactDetails);
            this.Name = "frmSupplyStockIn";
            this.Text = "Supply Stock In";
            this.Load += new System.EventHandler(this.frmSupplyStockIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSupplyStockIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtContactDetails;
        private System.Windows.Forms.TextBox txtSupplierDetails;
        private System.Windows.Forms.TextBox txtSupplyDescription;
        private System.Windows.Forms.TextBox txtUnitMeasure;
        private System.Windows.Forms.Label lblsupplierID;
        private System.Windows.Forms.Label lbl_supply_itemsID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblSupply_Items;
        private System.Windows.Forms.MaskedTextBox msktxtDeliveryDate;
        private System.Windows.Forms.TextBox txtDeliveryDate;
        private System.Windows.Forms.TextBox txtStockInQuantity;
        private System.Windows.Forms.TextBox txtSupplyPrice;
        private System.Windows.Forms.ComboBox cboActive;
        private System.Windows.Forms.ComboBox cboSupplierName;
        private System.Windows.Forms.ComboBox cboSupplyName;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblStockInQuantity;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataGridSupplyStockIn;
        private System.Windows.Forms.Label lblDeliveryDate;
        public System.Windows.Forms.Label lblSupplyID;
        public System.Windows.Forms.Label lblsupplyStockInQuantityUpdate;
        public System.Windows.Forms.Label lblUnitPriceUpdate;
        public System.Windows.Forms.Label lblActiveUpdate;
    }
}