namespace PYLsystems
{
    partial class frmFrameStockInSupplyStockOut
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
            System.Windows.Forms.ColumnHeader lvwSupplyID;
            this.cboFrameList = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblframeName = new System.Windows.Forms.Label();
            this.lblUnitType = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridSupplyStockIn = new System.Windows.Forms.DataGridView();
            this.lblSupplyID = new System.Windows.Forms.Label();
            this.lblSupplyName = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.txtUnitType = new System.Windows.Forms.TextBox();
            this.lblFrameItemID = new System.Windows.Forms.Label();
            this.lblQuantityIn = new System.Windows.Forms.Label();
            this.txtQuantityIn = new System.Windows.Forms.TextBox();
            this.lvwSupplyStockOut = new System.Windows.Forms.ListView();
            this.lvwSupplyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwSupplierName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwStockOutSupply = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwUType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblValidate = new System.Windows.Forms.Label();
            this.lblCompute = new System.Windows.Forms.TextBox();
            this.txtSupplyName = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplyame = new System.Windows.Forms.Label();
            this.lbelSupplierName = new System.Windows.Forms.Label();
            this.cboDimension = new System.Windows.Forms.ComboBox();
            lvwSupplyID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSupplyStockIn)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwSupplyID
            // 
            lvwSupplyID.Text = "Supply ID";
            lvwSupplyID.Width = 0;
            // 
            // cboFrameList
            // 
            this.cboFrameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrameList.FormattingEnabled = true;
            this.cboFrameList.Location = new System.Drawing.Point(119, 80);
            this.cboFrameList.Name = "cboFrameList";
            this.cboFrameList.Size = new System.Drawing.Size(156, 21);
            this.cboFrameList.TabIndex = 0;
            this.cboFrameList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(119, 215);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(156, 20);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblframeName
            // 
            this.lblframeName.AutoSize = true;
            this.lblframeName.Location = new System.Drawing.Point(11, 88);
            this.lblframeName.Name = "lblframeName";
            this.lblframeName.Size = new System.Drawing.Size(67, 13);
            this.lblframeName.TabIndex = 1;
            this.lblframeName.Text = "Frame Name";
            // 
            // lblUnitType
            // 
            this.lblUnitType.AutoSize = true;
            this.lblUnitType.Location = new System.Drawing.Point(11, 300);
            this.lblUnitType.Name = "lblUnitType";
            this.lblUnitType.Size = new System.Drawing.Size(53, 13);
            this.lblUnitType.TabIndex = 9;
            this.lblUnitType.Text = "Unit Type";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(11, 222);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(97, 13);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Stock Out Quantity";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(119, 377);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.dataGridSupplyStockIn.Location = new System.Drawing.Point(281, 80);
            this.dataGridSupplyStockIn.Name = "dataGridSupplyStockIn";
            this.dataGridSupplyStockIn.ReadOnly = true;
            this.dataGridSupplyStockIn.Size = new System.Drawing.Size(674, 308);
            this.dataGridSupplyStockIn.TabIndex = 13;
            this.dataGridSupplyStockIn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSupplyStockIn_CellClick);
            this.dataGridSupplyStockIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSupplyStockIn_CellContentClick);
            // 
            // lblSupplyID
            // 
            this.lblSupplyID.AutoSize = true;
            this.lblSupplyID.Location = new System.Drawing.Point(77, 350);
            this.lblSupplyID.Name = "lblSupplyID";
            this.lblSupplyID.Size = new System.Drawing.Size(0, 13);
            this.lblSupplyID.TabIndex = 9;
            this.lblSupplyID.Visible = false;
            // 
            // lblSupplyName
            // 
            this.lblSupplyName.AutoSize = true;
            this.lblSupplyName.Location = new System.Drawing.Point(77, 381);
            this.lblSupplyName.Name = "lblSupplyName";
            this.lblSupplyName.Size = new System.Drawing.Size(0, 13);
            this.lblSupplyName.TabIndex = 10;
            this.lblSupplyName.Visible = false;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(77, 416);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(0, 13);
            this.lblSupplierName.TabIndex = 11;
            this.lblSupplierName.Visible = false;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(202, 370);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(0, 13);
            this.lblEmployeeID.TabIndex = 12;
            this.lblEmployeeID.Visible = false;
            // 
            // btnStockOut
            // 
            this.btnStockOut.Enabled = false;
            this.btnStockOut.Location = new System.Drawing.Point(119, 319);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(156, 23);
            this.btnStockOut.TabIndex = 10;
            this.btnStockOut.Text = "Stock Out Supply";
            this.btnStockOut.UseVisualStyleBackColor = true;
            this.btnStockOut.Click += new System.EventHandler(this.btnStockOut_Click);
            // 
            // txtUnitType
            // 
            this.txtUnitType.Enabled = false;
            this.txtUnitType.Location = new System.Drawing.Point(119, 293);
            this.txtUnitType.Name = "txtUnitType";
            this.txtUnitType.Size = new System.Drawing.Size(156, 20);
            this.txtUnitType.TabIndex = 8;
            this.txtUnitType.TextChanged += new System.EventHandler(this.txtUnitType_TextChanged);
            this.txtUnitType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitType_KeyPress);
            // 
            // lblFrameItemID
            // 
            this.lblFrameItemID.AutoSize = true;
            this.lblFrameItemID.Location = new System.Drawing.Point(202, 341);
            this.lblFrameItemID.Name = "lblFrameItemID";
            this.lblFrameItemID.Size = new System.Drawing.Size(0, 13);
            this.lblFrameItemID.TabIndex = 19;
            this.lblFrameItemID.Visible = false;
            // 
            // lblQuantityIn
            // 
            this.lblQuantityIn.AutoSize = true;
            this.lblQuantityIn.Location = new System.Drawing.Point(11, 114);
            this.lblQuantityIn.Name = "lblQuantityIn";
            this.lblQuantityIn.Size = new System.Drawing.Size(89, 13);
            this.lblQuantityIn.TabIndex = 3;
            this.lblQuantityIn.Text = "Stock In Quantity";
            // 
            // txtQuantityIn
            // 
            this.txtQuantityIn.Location = new System.Drawing.Point(119, 107);
            this.txtQuantityIn.Name = "txtQuantityIn";
            this.txtQuantityIn.Size = new System.Drawing.Size(156, 20);
            this.txtQuantityIn.TabIndex = 2;
            this.txtQuantityIn.TextChanged += new System.EventHandler(this.txtQuantityIn_TextChanged);
            this.txtQuantityIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantityIn_KeyPress);
            // 
            // lvwSupplyStockOut
            // 
            this.lvwSupplyStockOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwSupplyStockOut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lvwSupplyID,
            this.lvwSupplyName,
            this.lvwSupplierName,
            this.lvwStockOutSupply,
            this.lvwUType});
            this.lvwSupplyStockOut.FullRowSelect = true;
            this.lvwSupplyStockOut.GridLines = true;
            this.lvwSupplyStockOut.Location = new System.Drawing.Point(281, 394);
            this.lvwSupplyStockOut.Name = "lvwSupplyStockOut";
            this.lvwSupplyStockOut.Size = new System.Drawing.Size(674, 306);
            this.lvwSupplyStockOut.TabIndex = 14;
            this.lvwSupplyStockOut.UseCompatibleStateImageBehavior = false;
            this.lvwSupplyStockOut.View = System.Windows.Forms.View.Details;
            // 
            // lvwSupplyName
            // 
            this.lvwSupplyName.Text = "Supply Name";
            this.lvwSupplyName.Width = 250;
            // 
            // lvwSupplierName
            // 
            this.lvwSupplierName.Text = "Supplier Name";
            this.lvwSupplierName.Width = 90;
            // 
            // lvwStockOutSupply
            // 
            this.lvwStockOutSupply.Text = "Stock Out Supply Quantity";
            this.lvwStockOutSupply.Width = 250;
            // 
            // lvwUType
            // 
            this.lvwUType.Text = "Unit Type";
            this.lvwUType.Width = 200;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(119, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(119, 348);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(156, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(278, 39);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 27;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(325, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(218, 20);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblValidate
            // 
            this.lblValidate.AutoSize = true;
            this.lblValidate.ForeColor = System.Drawing.Color.Red;
            this.lblValidate.Location = new System.Drawing.Point(10, 119);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(0, 13);
            this.lblValidate.TabIndex = 28;
            // 
            // lblCompute
            // 
            this.lblCompute.Location = new System.Drawing.Point(351, 182);
            this.lblCompute.Name = "lblCompute";
            this.lblCompute.Size = new System.Drawing.Size(100, 20);
            this.lblCompute.TabIndex = 29;
            this.lblCompute.Visible = false;
            // 
            // txtSupplyName
            // 
            this.txtSupplyName.Enabled = false;
            this.txtSupplyName.Location = new System.Drawing.Point(119, 241);
            this.txtSupplyName.Name = "txtSupplyName";
            this.txtSupplyName.Size = new System.Drawing.Size(156, 20);
            this.txtSupplyName.TabIndex = 30;
            this.txtSupplyName.TextChanged += new System.EventHandler(this.txtSupplyName_TextChanged);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Enabled = false;
            this.txtSupplierName.Location = new System.Drawing.Point(119, 267);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(156, 20);
            this.txtSupplierName.TabIndex = 31;
            // 
            // lblSupplyame
            // 
            this.lblSupplyame.AutoSize = true;
            this.lblSupplyame.Location = new System.Drawing.Point(11, 248);
            this.lblSupplyame.Name = "lblSupplyame";
            this.lblSupplyame.Size = new System.Drawing.Size(70, 13);
            this.lblSupplyame.TabIndex = 32;
            this.lblSupplyame.Text = "Supply Name";
            // 
            // lbelSupplierName
            // 
            this.lbelSupplierName.AutoSize = true;
            this.lbelSupplierName.Location = new System.Drawing.Point(11, 274);
            this.lbelSupplierName.Name = "lbelSupplierName";
            this.lbelSupplierName.Size = new System.Drawing.Size(76, 13);
            this.lbelSupplierName.TabIndex = 33;
            this.lbelSupplierName.Text = "Supplier Name";
            // 
            // cboDimension
            // 
            this.cboDimension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDimension.FormattingEnabled = true;
            this.cboDimension.Location = new System.Drawing.Point(119, 53);
            this.cboDimension.Name = "cboDimension";
            this.cboDimension.Size = new System.Drawing.Size(156, 21);
            this.cboDimension.TabIndex = 34;
            // 
            // frmFrameStockInSupplyStockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 749);
            this.ControlBox = false;
            this.Controls.Add(this.cboDimension);
            this.Controls.Add(this.lbelSupplierName);
            this.Controls.Add(this.lblSupplyame);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtSupplyName);
            this.Controls.Add(this.lblValidate);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lvwSupplyStockOut);
            this.Controls.Add(this.lblQuantityIn);
            this.Controls.Add(this.txtQuantityIn);
            this.Controls.Add(this.txtUnitType);
            this.Controls.Add(this.btnStockOut);
            this.Controls.Add(this.dataGridSupplyStockIn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblUnitType);
            this.Controls.Add(this.lblframeName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cboFrameList);
            this.Controls.Add(this.lblFrameItemID);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblSupplyName);
            this.Controls.Add(this.lblSupplyID);
            this.Controls.Add(this.lblCompute);
            this.Name = "frmFrameStockInSupplyStockOut";
            this.Text = "Frame Stock In and Supply Stock Out";
            this.Load += new System.EventHandler(this.frmFrameStockInSupplyStockOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSupplyStockIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFrameList;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblframeName;
        private System.Windows.Forms.Label lblUnitType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridSupplyStockIn;
        private System.Windows.Forms.Label lblSupplyID;
        private System.Windows.Forms.Label lblSupplyName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Button btnStockOut;
        private System.Windows.Forms.TextBox txtUnitType;
        private System.Windows.Forms.Label lblFrameItemID;
        private System.Windows.Forms.Label lblQuantityIn;
        private System.Windows.Forms.TextBox txtQuantityIn;
        private System.Windows.Forms.ListView lvwSupplyStockOut;
        private System.Windows.Forms.ColumnHeader lvwSupplyName;
        private System.Windows.Forms.ColumnHeader lvwSupplierName;
        private System.Windows.Forms.ColumnHeader lvwStockOutSupply;
        private System.Windows.Forms.ColumnHeader lvwUType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblValidate;
        private System.Windows.Forms.TextBox lblCompute;
        private System.Windows.Forms.TextBox txtSupplyName;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblSupplyame;
        private System.Windows.Forms.Label lbelSupplierName;
        private System.Windows.Forms.ComboBox cboDimension;
    }
}