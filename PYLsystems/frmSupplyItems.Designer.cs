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
            ((System.ComponentModel.ISupportInitialize)(this.supplyItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDUpdate
            // 
            this.lblIDUpdate.AutoSize = true;
            this.lblIDUpdate.Location = new System.Drawing.Point(291, 222);
            this.lblIDUpdate.Name = "lblIDUpdate";
            this.lblIDUpdate.Size = new System.Drawing.Size(44, 13);
            this.lblIDUpdate.TabIndex = 29;
            this.lblIDUpdate.Text = "Search:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(375, 26);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 28;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(511, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblUnitMeasureUpdate
            // 
            this.lblUnitMeasureUpdate.AutoSize = true;
            this.lblUnitMeasureUpdate.Location = new System.Drawing.Point(291, 181);
            this.lblUnitMeasureUpdate.Name = "lblUnitMeasureUpdate";
            this.lblUnitMeasureUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblUnitMeasureUpdate.TabIndex = 26;
            this.lblUnitMeasureUpdate.Text = "label6";
            // 
            // lblDescriptionUpdate
            // 
            this.lblDescriptionUpdate.AutoSize = true;
            this.lblDescriptionUpdate.Location = new System.Drawing.Point(291, 143);
            this.lblDescriptionUpdate.Name = "lblDescriptionUpdate";
            this.lblDescriptionUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblDescriptionUpdate.TabIndex = 25;
            this.lblDescriptionUpdate.Text = "label5";
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(291, 109);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblNameUpdate.TabIndex = 24;
            this.lblNameUpdate.Text = "label4";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(154, 320);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // supplyItemsGrid
            // 
            this.supplyItemsGrid.AllowUserToAddRows = false;
            this.supplyItemsGrid.AllowUserToDeleteRows = false;
            this.supplyItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplyItemsGrid.Location = new System.Drawing.Point(375, 67);
            this.supplyItemsGrid.Name = "supplyItemsGrid";
            this.supplyItemsGrid.ReadOnly = true;
            this.supplyItemsGrid.Size = new System.Drawing.Size(315, 417);
            this.supplyItemsGrid.TabIndex = 22;
            this.supplyItemsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplyItemsGrid_CellClick);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(36, 320);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 21;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // txtUnitMeasure
            // 
            this.txtUnitMeasure.Location = new System.Drawing.Point(145, 206);
            this.txtUnitMeasure.Name = "txtUnitMeasure";
            this.txtUnitMeasure.Size = new System.Drawing.Size(100, 20);
            this.txtUnitMeasure.TabIndex = 20;
            this.txtUnitMeasure.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(145, 174);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 140);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 18;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(22, 181);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Description";
            // 
            // lblUnitMeasure
            // 
            this.lblUnitMeasure.AutoSize = true;
            this.lblUnitMeasure.Location = new System.Drawing.Point(22, 213);
            this.lblUnitMeasure.Name = "lblUnitMeasure";
            this.lblUnitMeasure.Size = new System.Drawing.Size(70, 13);
            this.lblUnitMeasure.TabIndex = 16;
            this.lblUnitMeasure.Text = "Unit Measure";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 147);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name";
            // 
            // frmSupplyItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 529);
            this.Controls.Add(this.lblIDUpdate);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblUnitMeasureUpdate);
            this.Controls.Add(this.lblDescriptionUpdate);
            this.Controls.Add(this.lblNameUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.supplyItemsGrid);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.txtUnitMeasure);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblUnitMeasure);
            this.Controls.Add(this.lblName);
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
    }
}