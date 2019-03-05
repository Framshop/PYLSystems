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
            this.lblJobOrderNumber = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblformattedID = new System.Windows.Forms.Label();
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
            this.dgvJobOrders.Location = new System.Drawing.Point(12, 85);
            this.dgvJobOrders.Name = "dgvJobOrders";
            this.dgvJobOrders.ReadOnly = true;
            this.dgvJobOrders.Size = new System.Drawing.Size(616, 236);
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
            this.dgvJobOrderDetails.Location = new System.Drawing.Point(12, 327);
            this.dgvJobOrderDetails.Name = "dgvJobOrderDetails";
            this.dgvJobOrderDetails.ReadOnly = true;
            this.dgvJobOrderDetails.Size = new System.Drawing.Size(616, 236);
            this.dgvJobOrderDetails.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 569);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(93, 569);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblJobOrderNumber
            // 
            this.lblJobOrderNumber.AutoSize = true;
            this.lblJobOrderNumber.ForeColor = System.Drawing.Color.Red;
            this.lblJobOrderNumber.Location = new System.Drawing.Point(12, 9);
            this.lblJobOrderNumber.Name = "lblJobOrderNumber";
            this.lblJobOrderNumber.Size = new System.Drawing.Size(96, 13);
            this.lblJobOrderNumber.TabIndex = 10;
            this.lblJobOrderNumber.Text = "Job Order Number:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(25, 45);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 13);
            this.lblNumber.TabIndex = 11;
            this.lblNumber.Visible = false;
            // 
            // lblformattedID
            // 
            this.lblformattedID.AutoSize = true;
            this.lblformattedID.Location = new System.Drawing.Point(114, 9);
            this.lblformattedID.Name = "lblformattedID";
            this.lblformattedID.Size = new System.Drawing.Size(0, 13);
            this.lblformattedID.TabIndex = 12;
            // 
            // frmJobOrderTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(640, 605);
            this.Controls.Add(this.lblformattedID);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblJobOrderNumber);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvJobOrderDetails);
            this.Controls.Add(this.dgvJobOrders);
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
        private System.Windows.Forms.Label lblJobOrderNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblformattedID;
    }
}