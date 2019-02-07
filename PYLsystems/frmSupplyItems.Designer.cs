namespace PYLsystems
{
    partial class frmSupplyItems
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
            this.lblIDUpdate = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblUnitMeasureUpdate = new System.Windows.Forms.Label();
            this.lblDescriptionUpdate = new System.Windows.Forms.Label();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.supplyItemsGrid = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.txtUnitMeasure = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblUnitMeasure = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblValidate = new System.Windows.Forms.Label();
            this.lblSupplyItemsID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplyItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDUpdate
            // 
            this.lblIDUpdate.AutoSize = true;
            this.lblIDUpdate.Location = new System.Drawing.Point(409, 261);
            this.lblIDUpdate.Name = "lblIDUpdate";
            this.lblIDUpdate.Size = new System.Drawing.Size(44, 13);
            this.lblIDUpdate.TabIndex = 29;
            this.lblIDUpdate.Text = "Search:";
            this.lblIDUpdate.Visible = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(362, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 28;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(412, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(268, 20);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblUnitMeasureUpdate
            // 
            this.lblUnitMeasureUpdate.AutoSize = true;
            this.lblUnitMeasureUpdate.Location = new System.Drawing.Point(409, 220);
            this.lblUnitMeasureUpdate.Name = "lblUnitMeasureUpdate";
            this.lblUnitMeasureUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblUnitMeasureUpdate.TabIndex = 26;
            this.lblUnitMeasureUpdate.Text = "label6";
            this.lblUnitMeasureUpdate.Visible = false;
            // 
            // lblDescriptionUpdate
            // 
            this.lblDescriptionUpdate.AutoSize = true;
            this.lblDescriptionUpdate.Location = new System.Drawing.Point(409, 182);
            this.lblDescriptionUpdate.Name = "lblDescriptionUpdate";
            this.lblDescriptionUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblDescriptionUpdate.TabIndex = 25;
            this.lblDescriptionUpdate.Text = "label5";
            this.lblDescriptionUpdate.Visible = false;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(409, 148);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblNameUpdate.TabIndex = 24;
            this.lblNameUpdate.Text = "label4";
            this.lblNameUpdate.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(130, 286);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // supplyItemsGrid
            // 
            this.supplyItemsGrid.AllowUserToAddRows = false;
            this.supplyItemsGrid.AllowUserToDeleteRows = false;
            this.supplyItemsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supplyItemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplyItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplyItemsGrid.Location = new System.Drawing.Point(369, 38);
            this.supplyItemsGrid.Name = "supplyItemsGrid";
            this.supplyItemsGrid.ReadOnly = true;
            this.supplyItemsGrid.Size = new System.Drawing.Size(315, 331);
            this.supplyItemsGrid.TabIndex = 11;
            this.supplyItemsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplyItemsGrid_CellClick);
            // 
            // addBtn
            // 
            this.addBtn.Enabled = false;
            this.addBtn.Location = new System.Drawing.Point(46, 286);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // txtUnitMeasure
            // 
            this.txtUnitMeasure.Location = new System.Drawing.Point(130, 254);
            this.txtUnitMeasure.Name = "txtUnitMeasure";
            this.txtUnitMeasure.Size = new System.Drawing.Size(184, 20);
            this.txtUnitMeasure.TabIndex = 5;
            this.txtUnitMeasure.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(130, 109);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(184, 139);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(43, 109);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // lblUnitMeasure
            // 
            this.lblUnitMeasure.AutoSize = true;
            this.lblUnitMeasure.Location = new System.Drawing.Point(43, 254);
            this.lblUnitMeasure.Name = "lblUnitMeasure";
            this.lblUnitMeasure.Size = new System.Drawing.Size(70, 13);
            this.lblUnitMeasure.TabIndex = 6;
            this.lblUnitMeasure.Text = "Unit Measure";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(46, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblValidate
            // 
            this.lblValidate.AutoSize = true;
            this.lblValidate.ForeColor = System.Drawing.Color.Red;
            this.lblValidate.Location = new System.Drawing.Point(43, 321);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(0, 13);
            this.lblValidate.TabIndex = 31;
            // 
            // lblSupplyItemsID
            // 
            this.lblSupplyItemsID.AutoSize = true;
            this.lblSupplyItemsID.Location = new System.Drawing.Point(471, 148);
            this.lblSupplyItemsID.Name = "lblSupplyItemsID";
            this.lblSupplyItemsID.Size = new System.Drawing.Size(0, 13);
            this.lblSupplyItemsID.TabIndex = 32;
            this.lblSupplyItemsID.Visible = false;
            // 
            // frmSupplyItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 381);
            this.Controls.Add(this.lblSupplyItemsID);
            this.Controls.Add(this.lblValidate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.supplyItemsGrid);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.txtUnitMeasure);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblUnitMeasure);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblIDUpdate);
            this.Controls.Add(this.lblUnitMeasureUpdate);
            this.Controls.Add(this.lblDescriptionUpdate);
            this.Controls.Add(this.lblNameUpdate);
            this.Name = "frmSupplyItems";
            this.Text = "Supply Items";
            this.Load += new System.EventHandler(this.frmSupplyItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplyItemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDUpdate;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblUnitMeasureUpdate;
        private System.Windows.Forms.Label lblDescriptionUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView supplyItemsGrid;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox txtUnitMeasure;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblUnitMeasure;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblValidate;
        private System.Windows.Forms.Label lblSupplyItemsID;
    }
}