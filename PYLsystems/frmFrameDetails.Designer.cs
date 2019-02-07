namespace PYLsystems
{
    partial class frmFrameDetails
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
            this.dgvFrameStockInDetails = new System.Windows.Forms.DataGridView();
            this.btnFrameUpdate = new System.Windows.Forms.Button();
            this.dgvSupply = new System.Windows.Forms.DataGridView();
            this.btnFrameAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSupplyName = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrameStockInDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupply)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFrameStockInDetails
            // 
            this.dgvFrameStockInDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFrameStockInDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFrameStockInDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrameStockInDetails.Location = new System.Drawing.Point(12, 41);
            this.dgvFrameStockInDetails.Name = "dgvFrameStockInDetails";
            this.dgvFrameStockInDetails.Size = new System.Drawing.Size(703, 241);
            this.dgvFrameStockInDetails.TabIndex = 0;
            this.dgvFrameStockInDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFrameStockInDetails_CellClick);
            // 
            // btnFrameUpdate
            // 
            this.btnFrameUpdate.Enabled = false;
            this.btnFrameUpdate.Location = new System.Drawing.Point(93, 574);
            this.btnFrameUpdate.Name = "btnFrameUpdate";
            this.btnFrameUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnFrameUpdate.TabIndex = 1;
            this.btnFrameUpdate.Text = "Update";
            this.btnFrameUpdate.UseVisualStyleBackColor = true;
            this.btnFrameUpdate.Click += new System.EventHandler(this.btnFrameUpdate_Click);
            // 
            // dgvSupply
            // 
            this.dgvSupply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSupply.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupply.Location = new System.Drawing.Point(12, 327);
            this.dgvSupply.Name = "dgvSupply";
            this.dgvSupply.Size = new System.Drawing.Size(703, 241);
            this.dgvSupply.TabIndex = 2;
            // 
            // btnFrameAdd
            // 
            this.btnFrameAdd.Location = new System.Drawing.Point(12, 574);
            this.btnFrameAdd.Name = "btnFrameAdd";
            this.btnFrameAdd.Size = new System.Drawing.Size(75, 23);
            this.btnFrameAdd.TabIndex = 3;
            this.btnFrameAdd.Text = "Add";
            this.btnFrameAdd.UseVisualStyleBackColor = true;
            this.btnFrameAdd.Click += new System.EventHandler(this.btnFrameAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(174, 574);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSupplyName
            // 
            this.lblSupplyName.AutoSize = true;
            this.lblSupplyName.Location = new System.Drawing.Point(12, 311);
            this.lblSupplyName.Name = "lblSupplyName";
            this.lblSupplyName.Size = new System.Drawing.Size(0, 13);
            this.lblSupplyName.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(60, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmFrameDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 609);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblSupplyName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFrameAdd);
            this.Controls.Add(this.dgvSupply);
            this.Controls.Add(this.btnFrameUpdate);
            this.Controls.Add(this.dgvFrameStockInDetails);
            this.Name = "frmFrameDetails";
            this.Text = "Frame Details";
            this.Load += new System.EventHandler(this.frmFrameDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrameStockInDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupply)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFrameStockInDetails;
        private System.Windows.Forms.Button btnFrameUpdate;
        private System.Windows.Forms.DataGridView dgvSupply;
        private System.Windows.Forms.Button btnFrameAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSupplyName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}