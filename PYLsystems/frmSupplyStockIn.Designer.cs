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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbelsupplyID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSupplyStockIn)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContactDetails
            // 
            this.txtContactDetails.Enabled = false;
            this.txtContactDetails.Location = new System.Drawing.Point(6, 91);
            this.txtContactDetails.Name = "txtContactDetails";
            this.txtContactDetails.Size = new System.Drawing.Size(237, 20);
            this.txtContactDetails.TabIndex = 4;
            // 
            // txtSupplierDetails
            // 
            this.txtSupplierDetails.Enabled = false;
            this.txtSupplierDetails.Location = new System.Drawing.Point(6, 65);
            this.txtSupplierDetails.Name = "txtSupplierDetails";
            this.txtSupplierDetails.Size = new System.Drawing.Size(237, 20);
            this.txtSupplierDetails.TabIndex = 3;
            // 
            // txtSupplyDescription
            // 
            this.txtSupplyDescription.Enabled = false;
            this.txtSupplyDescription.Location = new System.Drawing.Point(6, 191);
            this.txtSupplyDescription.Name = "txtSupplyDescription";
            this.txtSupplyDescription.Size = new System.Drawing.Size(237, 20);
            this.txtSupplyDescription.TabIndex = 7;
            // 
            // txtUnitMeasure
            // 
            this.txtUnitMeasure.Enabled = false;
            this.txtUnitMeasure.Location = new System.Drawing.Point(6, 217);
            this.txtUnitMeasure.Name = "txtUnitMeasure";
            this.txtUnitMeasure.Size = new System.Drawing.Size(237, 20);
            this.txtUnitMeasure.TabIndex = 8;
            // 
            // lblsupplierID
            // 
            this.lblsupplierID.AutoSize = true;
            this.lblsupplierID.Location = new System.Drawing.Point(508, 383);
            this.lblsupplierID.Name = "lblsupplierID";
            this.lblsupplierID.Size = new System.Drawing.Size(35, 13);
            this.lblsupplierID.TabIndex = 6;
            this.lblsupplierID.Text = "label1";
            this.lblsupplierID.Visible = false;
            // 
            // lbl_supply_itemsID
            // 
            this.lbl_supply_itemsID.AutoSize = true;
            this.lbl_supply_itemsID.Location = new System.Drawing.Point(508, 355);
            this.lbl_supply_itemsID.Name = "lbl_supply_itemsID";
            this.lbl_supply_itemsID.Size = new System.Drawing.Size(35, 13);
            this.lbl_supply_itemsID.TabIndex = 7;
            this.lbl_supply_itemsID.Text = "label2";
            this.lbl_supply_itemsID.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(6, 466);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(6, 21);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(45, 13);
            this.lblSupplier.TabIndex = 1;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblSupply_Items
            // 
            this.lblSupply_Items.AutoSize = true;
            this.lblSupply_Items.Location = new System.Drawing.Point(3, 148);
            this.lblSupply_Items.Name = "lblSupply_Items";
            this.lblSupply_Items.Size = new System.Drawing.Size(67, 13);
            this.lblSupply_Items.TabIndex = 5;
            this.lblSupply_Items.Text = "Supply Items";
            // 
            // msktxtDeliveryDate
            // 
            this.msktxtDeliveryDate.Location = new System.Drawing.Point(9, 292);
            this.msktxtDeliveryDate.Mask = "0000-00-00 90:00";
            this.msktxtDeliveryDate.Name = "msktxtDeliveryDate";
            this.msktxtDeliveryDate.PromptChar = ' ';
            this.msktxtDeliveryDate.Size = new System.Drawing.Size(235, 20);
            this.msktxtDeliveryDate.TabIndex = 10;
            this.msktxtDeliveryDate.ValidatingType = typeof(System.DateTime);
            this.msktxtDeliveryDate.TextChanged += new System.EventHandler(this.msktxtDeliveryDate_TextChanged);
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(374, 466);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Size = new System.Drawing.Size(100, 20);
            this.txtDeliveryDate.TabIndex = 12;
            this.txtDeliveryDate.Visible = false;
            this.txtDeliveryDate.TextChanged += new System.EventHandler(this.txtDeliveryDate_TextChanged);
            // 
            // txtStockInQuantity
            // 
            this.txtStockInQuantity.Location = new System.Drawing.Point(9, 376);
            this.txtStockInQuantity.Name = "txtStockInQuantity";
            this.txtStockInQuantity.Size = new System.Drawing.Size(235, 20);
            this.txtStockInQuantity.TabIndex = 14;
            this.txtStockInQuantity.TextChanged += new System.EventHandler(this.txtStockInQuantity_TextChanged);
            this.txtStockInQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockInQuantity_KeyPress);
            // 
            // txtSupplyPrice
            // 
            this.txtSupplyPrice.Location = new System.Drawing.Point(9, 415);
            this.txtSupplyPrice.Name = "txtSupplyPrice";
            this.txtSupplyPrice.Size = new System.Drawing.Size(235, 20);
            this.txtSupplyPrice.TabIndex = 16;
            this.txtSupplyPrice.TextChanged += new System.EventHandler(this.txtSupplyPrice_TextChanged);
            // 
            // cboActive
            // 
            this.cboActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActive.FormattingEnabled = true;
            this.cboActive.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboActive.Location = new System.Drawing.Point(9, 331);
            this.cboActive.Name = "cboActive";
            this.cboActive.Size = new System.Drawing.Size(235, 21);
            this.cboActive.TabIndex = 12;
            this.cboActive.SelectedIndexChanged += new System.EventHandler(this.cboActive_SelectedIndexChanged);
            // 
            // cboSupplierName
            // 
            this.cboSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplierName.FormattingEnabled = true;
            this.cboSupplierName.Location = new System.Drawing.Point(6, 37);
            this.cboSupplierName.Name = "cboSupplierName";
            this.cboSupplierName.Size = new System.Drawing.Size(237, 21);
            this.cboSupplierName.TabIndex = 2;
            this.cboSupplierName.SelectedIndexChanged += new System.EventHandler(this.cboSupplierName_SelectedIndexChanged);
            // 
            // cboSupplyName
            // 
            this.cboSupplyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplyName.FormattingEnabled = true;
            this.cboSupplyName.Location = new System.Drawing.Point(6, 164);
            this.cboSupplyName.Name = "cboSupplyName";
            this.cboSupplyName.Size = new System.Drawing.Size(239, 21);
            this.cboSupplyName.TabIndex = 6;
            this.cboSupplyName.SelectedIndexChanged += new System.EventHandler(this.cboSupplyName_SelectedIndexChanged);
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(6, 315);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(37, 13);
            this.lblActive.TabIndex = 11;
            this.lblActive.Text = "Active";
            // 
            // lblStockInQuantity
            // 
            this.lblStockInQuantity.AutoSize = true;
            this.lblStockInQuantity.Location = new System.Drawing.Point(6, 360);
            this.lblStockInQuantity.Name = "lblStockInQuantity";
            this.lblStockInQuantity.Size = new System.Drawing.Size(88, 13);
            this.lblStockInQuantity.TabIndex = 13;
            this.lblStockInQuantity.Text = "Stock in Quantity";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(6, 399);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 15;
            this.lblUnitPrice.Text = "Unit Price";
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(6, 495);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(131, 23);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Stock In";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dataGridSupplyStockIn
            // 
            this.dataGridSupplyStockIn.AllowUserToAddRows = false;
            this.dataGridSupplyStockIn.AllowUserToDeleteRows = false;
            this.dataGridSupplyStockIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSupplyStockIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSupplyStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSupplyStockIn.Location = new System.Drawing.Point(259, 65);
            this.dataGridSupplyStockIn.Name = "dataGridSupplyStockIn";
            this.dataGridSupplyStockIn.ReadOnly = true;
            this.dataGridSupplyStockIn.Size = new System.Drawing.Size(704, 529);
            this.dataGridSupplyStockIn.TabIndex = 19;
            this.dataGridSupplyStockIn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSupplyStockIn_CellClick);
            this.dataGridSupplyStockIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSupplyStockIn_CellContentClick);
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(6, 276);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(71, 13);
            this.lblDeliveryDate.TabIndex = 9;
            this.lblDeliveryDate.Text = "Delivery Date";
            // 
            // lblSupplyID
            // 
            this.lblSupplyID.AutoSize = true;
            this.lblSupplyID.Location = new System.Drawing.Point(440, 340);
            this.lblSupplyID.Name = "lblSupplyID";
            this.lblSupplyID.Size = new System.Drawing.Size(35, 13);
            this.lblSupplyID.TabIndex = 24;
            this.lblSupplyID.Text = "label1";
            this.lblSupplyID.Visible = false;
            // 
            // lblsupplyStockInQuantityUpdate
            // 
            this.lblsupplyStockInQuantityUpdate.AutoSize = true;
            this.lblsupplyStockInQuantityUpdate.Location = new System.Drawing.Point(440, 361);
            this.lblsupplyStockInQuantityUpdate.Name = "lblsupplyStockInQuantityUpdate";
            this.lblsupplyStockInQuantityUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblsupplyStockInQuantityUpdate.TabIndex = 25;
            this.lblsupplyStockInQuantityUpdate.Text = "label1";
            this.lblsupplyStockInQuantityUpdate.Visible = false;
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(440, 383);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblUnitPriceUpdate.TabIndex = 26;
            this.lblUnitPriceUpdate.Text = "label2";
            this.lblUnitPriceUpdate.Visible = false;
            // 
            // lblActiveUpdate
            // 
            this.lblActiveUpdate.AutoSize = true;
            this.lblActiveUpdate.Location = new System.Drawing.Point(440, 405);
            this.lblActiveUpdate.Name = "lblActiveUpdate";
            this.lblActiveUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblActiveUpdate.TabIndex = 27;
            this.lblActiveUpdate.Text = "label1";
            this.lblActiveUpdate.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(6, 524);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(254, 37);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(310, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(291, 20);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lbelsupplyID
            // 
            this.lbelsupplyID.AutoSize = true;
            this.lbelsupplyID.Location = new System.Drawing.Point(59, 569);
            this.lbelsupplyID.Name = "lbelsupplyID";
            this.lbelsupplyID.Size = new System.Drawing.Size(0, 13);
            this.lbelsupplyID.TabIndex = 29;
            this.lbelsupplyID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(83, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "yyyy/mm/dd time";
            // 
            // frmSupplyStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbelsupplyID);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnCancel);
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
            this.Controls.Add(this.lblActiveUpdate);
            this.Controls.Add(this.lblUnitPriceUpdate);
            this.Controls.Add(this.lblsupplyStockInQuantityUpdate);
            this.Controls.Add(this.lblSupplyID);
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbelsupplyID;
        private System.Windows.Forms.Label label1;
    }
}