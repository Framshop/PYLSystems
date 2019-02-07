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
            this.lblSupplyID = new System.Windows.Forms.Label();
            this.lblFrameItemID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFrameID = new System.Windows.Forms.Label();
            this.lblValidate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frameItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(23, 125);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(23, 230);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(37, 13);
            this.lblActive.TabIndex = 6;
            this.lblActive.Text = "Active";
            // 
            // lblDimension
            // 
            this.lblDimension.AutoSize = true;
            this.lblDimension.Location = new System.Drawing.Point(23, 257);
            this.lblDimension.Name = "lblDimension";
            this.lblDimension.Size = new System.Drawing.Size(56, 13);
            this.lblDimension.TabIndex = 8;
            this.lblDimension.Text = "Dimension";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(23, 290);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 10;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDimension
            // 
            this.txtDimension.Location = new System.Drawing.Point(97, 257);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(169, 20);
            this.txtDimension.TabIndex = 7;
            this.txtDimension.TextChanged += new System.EventHandler(this.txtDimension_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(97, 125);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(169, 86);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(97, 290);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(169, 20);
            this.txtUnitPrice.TabIndex = 9;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // cboActive
            // 
            this.cboActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActive.FormattingEnabled = true;
            this.cboActive.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboActive.Location = new System.Drawing.Point(97, 230);
            this.cboActive.Name = "cboActive";
            this.cboActive.Size = new System.Drawing.Size(169, 21);
            this.cboActive.TabIndex = 5;
            this.cboActive.SelectedIndexChanged += new System.EventHandler(this.cboActive_SelectedIndexChanged);
            // 
            // btbAdd
            // 
            this.btbAdd.Enabled = false;
            this.btbAdd.Location = new System.Drawing.Point(29, 332);
            this.btbAdd.Name = "btbAdd";
            this.btbAdd.Size = new System.Drawing.Size(75, 23);
            this.btbAdd.TabIndex = 11;
            this.btbAdd.Text = "Add";
            this.btbAdd.UseVisualStyleBackColor = true;
            this.btbAdd.Click += new System.EventHandler(this.btbAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(110, 332);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frameItemsGrid
            // 
            this.frameItemsGrid.AllowUserToAddRows = false;
            this.frameItemsGrid.AllowUserToDeleteRows = false;
            this.frameItemsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameItemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.frameItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frameItemsGrid.Location = new System.Drawing.Point(272, 79);
            this.frameItemsGrid.Name = "frameItemsGrid";
            this.frameItemsGrid.ReadOnly = true;
            this.frameItemsGrid.Size = new System.Drawing.Size(363, 348);
            this.frameItemsGrid.TabIndex = 11;
            this.frameItemsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.frameItemsGrid_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(318, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(206, 20);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search:";
            // 
            // lblIDUpdate
            // 
            this.lblIDUpdate.AutoSize = true;
            this.lblIDUpdate.Enabled = false;
            this.lblIDUpdate.Location = new System.Drawing.Point(516, 238);
            this.lblIDUpdate.Name = "lblIDUpdate";
            this.lblIDUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblIDUpdate.TabIndex = 14;
            this.lblIDUpdate.Text = "label2";
            // 
            // lblSupplyID
            // 
            this.lblSupplyID.AutoSize = true;
            this.lblSupplyID.Enabled = false;
            this.lblSupplyID.Location = new System.Drawing.Point(499, 251);
            this.lblSupplyID.Name = "lblSupplyID";
            this.lblSupplyID.Size = new System.Drawing.Size(35, 13);
            this.lblSupplyID.TabIndex = 23;
            this.lblSupplyID.Text = "label2";
            // 
            // lblFrameItemID
            // 
            this.lblFrameItemID.AutoSize = true;
            this.lblFrameItemID.Enabled = false;
            this.lblFrameItemID.Location = new System.Drawing.Point(498, 188);
            this.lblFrameItemID.Name = "lblFrameItemID";
            this.lblFrameItemID.Size = new System.Drawing.Size(35, 13);
            this.lblFrameItemID.TabIndex = 25;
            this.lblFrameItemID.Text = "label2";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(26, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFrameID
            // 
            this.lblFrameID.AutoSize = true;
            this.lblFrameID.Location = new System.Drawing.Point(107, 48);
            this.lblFrameID.Name = "lblFrameID";
            this.lblFrameID.Size = new System.Drawing.Size(0, 13);
            this.lblFrameID.TabIndex = 27;
            this.lblFrameID.Visible = false;
            // 
            // lblValidate
            // 
            this.lblValidate.AutoSize = true;
            this.lblValidate.ForeColor = System.Drawing.Color.Red;
            this.lblValidate.Location = new System.Drawing.Point(26, 368);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(0, 13);
            this.lblValidate.TabIndex = 28;
            // 
            // frmFrameList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 439);
            this.ControlBox = false;
            this.Controls.Add(this.lblValidate);
            this.Controls.Add(this.lblFrameID);
            this.Controls.Add(this.btnCancel);
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
            this.Controls.Add(this.lblIDUpdate);
            this.Controls.Add(this.lblFrameItemID);
            this.Controls.Add(this.lblSupplyID);
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
        private System.Windows.Forms.Label lblSupplyID;
        private System.Windows.Forms.Label lblFrameItemID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFrameID;
        private System.Windows.Forms.Label lblValidate;
    }
}