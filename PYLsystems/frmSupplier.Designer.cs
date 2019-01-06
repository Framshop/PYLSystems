namespace PYLsystems
{
    partial class frmSupplier
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.supplierGrid = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.lblDetailsUpdate = new System.Windows.Forms.Label();
            this.lblContactUpdate = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblIDUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Details";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 126);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(145, 160);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(100, 20);
            this.txtDetails.TabIndex = 4;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(145, 192);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 20);
            this.txtContact.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(36, 306);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // supplierGrid
            // 
            this.supplierGrid.AllowUserToAddRows = false;
            this.supplierGrid.AllowUserToDeleteRows = false;
            this.supplierGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGrid.Location = new System.Drawing.Point(409, 95);
            this.supplierGrid.Name = "supplierGrid";
            this.supplierGrid.ReadOnly = true;
            this.supplierGrid.Size = new System.Drawing.Size(315, 417);
            this.supplierGrid.TabIndex = 7;
            this.supplierGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierGrid_CellClick);
            this.supplierGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierGrid_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(154, 306);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(291, 95);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblNameUpdate.TabIndex = 9;
            this.lblNameUpdate.Text = "label4";
            // 
            // lblDetailsUpdate
            // 
            this.lblDetailsUpdate.AutoSize = true;
            this.lblDetailsUpdate.Location = new System.Drawing.Point(291, 129);
            this.lblDetailsUpdate.Name = "lblDetailsUpdate";
            this.lblDetailsUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblDetailsUpdate.TabIndex = 10;
            this.lblDetailsUpdate.Text = "label5";
            // 
            // lblContactUpdate
            // 
            this.lblContactUpdate.AutoSize = true;
            this.lblContactUpdate.Location = new System.Drawing.Point(291, 167);
            this.lblContactUpdate.Name = "lblContactUpdate";
            this.lblContactUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblContactUpdate.TabIndex = 11;
            this.lblContactUpdate.Text = "label6";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(545, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(409, 54);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Search:";
            // 
            // lblIDUpdate
            // 
            this.lblIDUpdate.AutoSize = true;
            this.lblIDUpdate.Location = new System.Drawing.Point(291, 208);
            this.lblIDUpdate.Name = "lblIDUpdate";
            this.lblIDUpdate.Size = new System.Drawing.Size(44, 13);
            this.lblIDUpdate.TabIndex = 14;
            this.lblIDUpdate.Text = "Search:";
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 534);
            this.Controls.Add(this.lblIDUpdate);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblContactUpdate);
            this.Controls.Add(this.lblDetailsUpdate);
            this.Controls.Add(this.lblNameUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.supplierGrid);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSupplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView supplierGrid;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Label lblDetailsUpdate;
        private System.Windows.Forms.Label lblContactUpdate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblIDUpdate;
    }
}