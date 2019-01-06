namespace PYLsystems
{
    partial class frmFrameList
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblDimension = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.cboActive = new System.Windows.Forms.ComboBox();
            this.btbAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.frameItemsGrid = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIDUpdate = new System.Windows.Forms.Label();
            this.txtSupplyDescription = new System.Windows.Forms.TextBox();
            this.cboSupplyName = new System.Windows.Forms.ComboBox();
            this.txtSupplyUnitMeasure = new System.Windows.Forms.TextBox();
            this.lblSupplyName = new System.Windows.Forms.Label();
            this.lblSupplyDescription = new System.Windows.Forms.Label();
            this.lblSupplyUnitMeasure = new System.Windows.Forms.Label();
            this.lvwFrameList = new System.Windows.Forms.ListView();
            this.lvwSupplyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwSupplyDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwSupplyUnitMeasure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddSupply = new System.Windows.Forms.Button();
            this.lblSupplyID = new System.Windows.Forms.Label();
            this.lblFrameItemID = new System.Windows.Forms.Label();
            this.lvwSupplyID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.frameItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 106);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(23, 128);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(23, 238);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(37, 13);
            this.lblActive.TabIndex = 2;
            this.lblActive.Text = "Active";
            // 
            // lblDimension
            // 
            this.lblDimension.AutoSize = true;
            this.lblDimension.Location = new System.Drawing.Point(23, 264);
            this.lblDimension.Name = "lblDimension";
            this.lblDimension.Size = new System.Drawing.Size(56, 13);
            this.lblDimension.TabIndex = 3;
            this.lblDimension.Text = "Dimension";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(23, 297);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtDimension
            // 
            this.txtDimension.Location = new System.Drawing.Point(161, 261);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(100, 20);
            this.txtDimension.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(161, 125);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(169, 86);
            this.txtDescription.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(161, 290);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 7;
            // 
            // cboActive
            // 
            this.cboActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActive.FormattingEnabled = true;
            this.cboActive.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboActive.Location = new System.Drawing.Point(161, 230);
            this.cboActive.Name = "cboActive";
            this.cboActive.Size = new System.Drawing.Size(100, 21);
            this.cboActive.TabIndex = 8;
            // 
            // btbAdd
            // 
            this.btbAdd.Location = new System.Drawing.Point(77, 332);
            this.btbAdd.Name = "btbAdd";
            this.btbAdd.Size = new System.Drawing.Size(75, 23);
            this.btbAdd.TabIndex = 9;
            this.btbAdd.Text = "Add";
            this.btbAdd.UseVisualStyleBackColor = true;
            this.btbAdd.Click += new System.EventHandler(this.btbAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(207, 332);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frameItemsGrid
            // 
            this.frameItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frameItemsGrid.Location = new System.Drawing.Point(382, 79);
            this.frameItemsGrid.Name = "frameItemsGrid";
            this.frameItemsGrid.Size = new System.Drawing.Size(426, 231);
            this.frameItemsGrid.TabIndex = 11;
            this.frameItemsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.frameItemsGrid_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(534, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search:";
            // 
            // lblIDUpdate
            // 
            this.lblIDUpdate.AutoSize = true;
            this.lblIDUpdate.Location = new System.Drawing.Point(225, 33);
            this.lblIDUpdate.Name = "lblIDUpdate";
            this.lblIDUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblIDUpdate.TabIndex = 14;
            this.lblIDUpdate.Text = "label2";
            // 
            // txtSupplyDescription
            // 
            this.txtSupplyDescription.Enabled = false;
            this.txtSupplyDescription.Location = new System.Drawing.Point(111, 526);
            this.txtSupplyDescription.Name = "txtSupplyDescription";
            this.txtSupplyDescription.Size = new System.Drawing.Size(100, 20);
            this.txtSupplyDescription.TabIndex = 15;
            // 
            // cboSupplyName
            // 
            this.cboSupplyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplyName.FormattingEnabled = true;
            this.cboSupplyName.Location = new System.Drawing.Point(111, 498);
            this.cboSupplyName.Name = "cboSupplyName";
            this.cboSupplyName.Size = new System.Drawing.Size(100, 21);
            this.cboSupplyName.TabIndex = 16;
            this.cboSupplyName.SelectedIndexChanged += new System.EventHandler(this.cboSupplyName_SelectedIndexChanged);
            // 
            // txtSupplyUnitMeasure
            // 
            this.txtSupplyUnitMeasure.Enabled = false;
            this.txtSupplyUnitMeasure.Location = new System.Drawing.Point(111, 552);
            this.txtSupplyUnitMeasure.Name = "txtSupplyUnitMeasure";
            this.txtSupplyUnitMeasure.Size = new System.Drawing.Size(100, 20);
            this.txtSupplyUnitMeasure.TabIndex = 17;
            // 
            // lblSupplyName
            // 
            this.lblSupplyName.AutoSize = true;
            this.lblSupplyName.Location = new System.Drawing.Point(26, 506);
            this.lblSupplyName.Name = "lblSupplyName";
            this.lblSupplyName.Size = new System.Drawing.Size(70, 13);
            this.lblSupplyName.TabIndex = 18;
            this.lblSupplyName.Text = "Supply Name";
            // 
            // lblSupplyDescription
            // 
            this.lblSupplyDescription.AutoSize = true;
            this.lblSupplyDescription.Location = new System.Drawing.Point(26, 533);
            this.lblSupplyDescription.Name = "lblSupplyDescription";
            this.lblSupplyDescription.Size = new System.Drawing.Size(60, 13);
            this.lblSupplyDescription.TabIndex = 19;
            this.lblSupplyDescription.Text = "Description";
            // 
            // lblSupplyUnitMeasure
            // 
            this.lblSupplyUnitMeasure.AutoSize = true;
            this.lblSupplyUnitMeasure.Location = new System.Drawing.Point(26, 560);
            this.lblSupplyUnitMeasure.Name = "lblSupplyUnitMeasure";
            this.lblSupplyUnitMeasure.Size = new System.Drawing.Size(70, 13);
            this.lblSupplyUnitMeasure.TabIndex = 20;
            this.lblSupplyUnitMeasure.Text = "Unit Measure";
            // 
            // lvwFrameList
            // 
            this.lvwFrameList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwSupplyName,
            this.lvwSupplyDescription,
            this.lvwSupplyUnitMeasure,
            this.lvwSupplyID});
            this.lvwFrameList.Enabled = false;
            this.lvwFrameList.Location = new System.Drawing.Point(382, 332);
            this.lvwFrameList.Name = "lvwFrameList";
            this.lvwFrameList.Size = new System.Drawing.Size(305, 356);
            this.lvwFrameList.TabIndex = 21;
            this.lvwFrameList.UseCompatibleStateImageBehavior = false;
            this.lvwFrameList.View = System.Windows.Forms.View.Details;
            // 
            // lvwSupplyName
            // 
            this.lvwSupplyName.Text = "Supply Name";
            this.lvwSupplyName.Width = 100;
            // 
            // lvwSupplyDescription
            // 
            this.lvwSupplyDescription.Text = "Description";
            this.lvwSupplyDescription.Width = 100;
            // 
            // lvwSupplyUnitMeasure
            // 
            this.lvwSupplyUnitMeasure.Text = "Unit Measure";
            this.lvwSupplyUnitMeasure.Width = 100;
            // 
            // btnAddSupply
            // 
            this.btnAddSupply.Location = new System.Drawing.Point(228, 549);
            this.btnAddSupply.Name = "btnAddSupply";
            this.btnAddSupply.Size = new System.Drawing.Size(75, 23);
            this.btnAddSupply.TabIndex = 22;
            this.btnAddSupply.Text = "Add Supply";
            this.btnAddSupply.UseVisualStyleBackColor = true;
            this.btnAddSupply.Click += new System.EventHandler(this.btnAddSupply_Click);
            // 
            // lblSupplyID
            // 
            this.lblSupplyID.AutoSize = true;
            this.lblSupplyID.Location = new System.Drawing.Point(108, 482);
            this.lblSupplyID.Name = "lblSupplyID";
            this.lblSupplyID.Size = new System.Drawing.Size(35, 13);
            this.lblSupplyID.TabIndex = 23;
            this.lblSupplyID.Text = "label2";
            // 
            // lblFrameItemID
            // 
            this.lblFrameItemID.AutoSize = true;
            this.lblFrameItemID.Location = new System.Drawing.Point(107, 419);
            this.lblFrameItemID.Name = "lblFrameItemID";
            this.lblFrameItemID.Size = new System.Drawing.Size(35, 13);
            this.lblFrameItemID.TabIndex = 25;
            this.lblFrameItemID.Text = "label2";
            // 
            // lvwSupplyID
            // 
            this.lvwSupplyID.Text = "Supply ID";
            this.lvwSupplyID.Width = 100;
            // 
            // frmFrameList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 749);
            this.Controls.Add(this.lblFrameItemID);
            this.Controls.Add(this.lblSupplyID);
            this.Controls.Add(this.btnAddSupply);
            this.Controls.Add(this.lvwFrameList);
            this.Controls.Add(this.lblSupplyUnitMeasure);
            this.Controls.Add(this.lblSupplyDescription);
            this.Controls.Add(this.lblSupplyName);
            this.Controls.Add(this.txtSupplyUnitMeasure);
            this.Controls.Add(this.cboSupplyName);
            this.Controls.Add(this.txtSupplyDescription);
            this.Controls.Add(this.lblIDUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.frameItemsGrid);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btbAdd);
            this.Controls.Add(this.cboActive);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtDimension);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblDimension);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Name = "frmFrameList";
            this.Text = "Frame List";
            this.Load += new System.EventHandler(this.frmFrameList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frameItemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblDimension;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDimension;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.ComboBox cboActive;
        private System.Windows.Forms.Button btbAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView frameItemsGrid;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIDUpdate;
        private System.Windows.Forms.TextBox txtSupplyDescription;
        private System.Windows.Forms.ComboBox cboSupplyName;
        private System.Windows.Forms.TextBox txtSupplyUnitMeasure;
        private System.Windows.Forms.Label lblSupplyName;
        private System.Windows.Forms.Label lblSupplyDescription;
        private System.Windows.Forms.Label lblSupplyUnitMeasure;
        private System.Windows.Forms.ListView lvwFrameList;
        private System.Windows.Forms.ColumnHeader lvwSupplyName;
        private System.Windows.Forms.ColumnHeader lvwSupplyDescription;
        private System.Windows.Forms.ColumnHeader lvwSupplyUnitMeasure;
        private System.Windows.Forms.Button btnAddSupply;
        private System.Windows.Forms.Label lblSupplyID;
        private System.Windows.Forms.Label lblFrameItemID;
        private System.Windows.Forms.ColumnHeader lvwSupplyID;
    }
}