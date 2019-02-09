namespace PYLsystems
{
    partial class frmJobOrderTransaction
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
            this.dgvJobOrders = new System.Windows.Forms.DataGridView();
            this.dgvJobOrderDetails = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFinishJobOrder = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.chkCancelled = new System.Windows.Forms.CheckBox();
            this.chkDone = new System.Windows.Forms.CheckBox();
            this.btnCancelJobOrder = new System.Windows.Forms.Button();
            this.lblJobOrderNumber = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJobOrders
            // 
            this.dgvJobOrders.AllowUserToAddRows = false;
            this.dgvJobOrders.AllowUserToDeleteRows = false;
            this.dgvJobOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJobOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJobOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobOrders.Location = new System.Drawing.Point(18, 131);
            this.dgvJobOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvJobOrders.Name = "dgvJobOrders";
            this.dgvJobOrders.ReadOnly = true;
            this.dgvJobOrders.Size = new System.Drawing.Size(924, 363);
            this.dgvJobOrders.TabIndex = 0;
            this.dgvJobOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobOrders_CellClick);
            // 
            // dgvJobOrderDetails
            // 
            this.dgvJobOrderDetails.AllowUserToAddRows = false;
            this.dgvJobOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJobOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJobOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobOrderDetails.Location = new System.Drawing.Point(18, 503);
            this.dgvJobOrderDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvJobOrderDetails.Name = "dgvJobOrderDetails";
            this.dgvJobOrderDetails.ReadOnly = true;
            this.dgvJobOrderDetails.Size = new System.Drawing.Size(924, 363);
            this.dgvJobOrderDetails.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(18, 875);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(140, 875);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFinishJobOrder
            // 
            this.btnFinishJobOrder.Enabled = false;
            this.btnFinishJobOrder.Location = new System.Drawing.Point(480, 875);
            this.btnFinishJobOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinishJobOrder.Name = "btnFinishJobOrder";
            this.btnFinishJobOrder.Size = new System.Drawing.Size(226, 35);
            this.btnFinishJobOrder.TabIndex = 4;
            this.btnFinishJobOrder.Text = "Finish Job Transactions";
            this.btnFinishJobOrder.UseVisualStyleBackColor = true;
            this.btnFinishJobOrder.Click += new System.EventHandler(this.btnFinishJobOrder_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(490, 95);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 20);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(591, 83);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(349, 26);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // chkCancelled
            // 
            this.chkCancelled.AutoSize = true;
            this.chkCancelled.Location = new System.Drawing.Point(20, 65);
            this.chkCancelled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCancelled.Name = "chkCancelled";
            this.chkCancelled.Size = new System.Drawing.Size(105, 24);
            this.chkCancelled.TabIndex = 7;
            this.chkCancelled.Text = "Cancelled";
            this.chkCancelled.UseVisualStyleBackColor = true;
            this.chkCancelled.CheckedChanged += new System.EventHandler(this.chkOnGoing_CheckedChanged);
            // 
            // chkDone
            // 
            this.chkDone.AutoSize = true;
            this.chkDone.Location = new System.Drawing.Point(20, 100);
            this.chkDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDone.Name = "chkDone";
            this.chkDone.Size = new System.Drawing.Size(169, 24);
            this.chkDone.TabIndex = 8;
            this.chkDone.Text = "Done Transactions";
            this.chkDone.UseVisualStyleBackColor = true;
            this.chkDone.CheckedChanged += new System.EventHandler(this.chkDone_CheckedChanged);
            // 
            // btnCancelJobOrder
            // 
            this.btnCancelJobOrder.Enabled = false;
            this.btnCancelJobOrder.Location = new System.Drawing.Point(716, 875);
            this.btnCancelJobOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelJobOrder.Name = "btnCancelJobOrder";
            this.btnCancelJobOrder.Size = new System.Drawing.Size(226, 35);
            this.btnCancelJobOrder.TabIndex = 9;
            this.btnCancelJobOrder.Text = "Cancel Job Order";
            this.btnCancelJobOrder.UseVisualStyleBackColor = true;
            this.btnCancelJobOrder.Click += new System.EventHandler(this.btnCancelJobOrder_Click_1);
            // 
            // lblJobOrderNumber
            // 
            this.lblJobOrderNumber.AutoSize = true;
            this.lblJobOrderNumber.ForeColor = System.Drawing.Color.Red;
            this.lblJobOrderNumber.Location = new System.Drawing.Point(18, 14);
            this.lblJobOrderNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobOrderNumber.Name = "lblJobOrderNumber";
            this.lblJobOrderNumber.Size = new System.Drawing.Size(143, 20);
            this.lblJobOrderNumber.TabIndex = 10;
            this.lblJobOrderNumber.Text = "Job Order Number:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(171, 14);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 20);
            this.lblNumber.TabIndex = 11;
            // 
            // frmJobOrderTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 929);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblJobOrderNumber);
            this.Controls.Add(this.btnCancelJobOrder);
            this.Controls.Add(this.chkDone);
            this.Controls.Add(this.chkCancelled);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnFinishJobOrder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvJobOrderDetails);
            this.Controls.Add(this.dgvJobOrders);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmJobOrderTransaction";
            this.Text = "Job Order Transactions";
            this.Load += new System.EventHandler(this.frmJobOrderTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJobOrders;
        private System.Windows.Forms.DataGridView dgvJobOrderDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFinishJobOrder;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkCancelled;
        private System.Windows.Forms.CheckBox chkDone;
        private System.Windows.Forms.Button btnCancelJobOrder;
        private System.Windows.Forms.Label lblJobOrderNumber;
        private System.Windows.Forms.Label lblNumber;
    }
}