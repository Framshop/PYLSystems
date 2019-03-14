namespace PYLsystems
{
    partial class frmRemainingSupplyFrames
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
            this.dgvSupply = new System.Windows.Forms.DataGridView();
            this.dgvFrames = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvSupplySalesDamage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplySalesDamage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupply
            // 
            this.dgvSupply.AllowUserToAddRows = false;
            this.dgvSupply.AllowUserToDeleteRows = false;
            this.dgvSupply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSupply.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupply.Location = new System.Drawing.Point(12, 12);
            this.dgvSupply.Name = "dgvSupply";
            this.dgvSupply.ReadOnly = true;
            this.dgvSupply.Size = new System.Drawing.Size(426, 226);
            this.dgvSupply.TabIndex = 0;
            // 
            // dgvFrames
            // 
            this.dgvFrames.AllowUserToAddRows = false;
            this.dgvFrames.AllowUserToDeleteRows = false;
            this.dgvFrames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFrames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFrames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrames.Location = new System.Drawing.Point(12, 244);
            this.dgvFrames.Name = "dgvFrames";
            this.dgvFrames.ReadOnly = true;
            this.dgvFrames.Size = new System.Drawing.Size(426, 226);
            this.dgvFrames.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(13, 489);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvSupplySalesDamage
            // 
            this.dgvSupplySalesDamage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSupplySalesDamage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplySalesDamage.Location = new System.Drawing.Point(444, 12);
            this.dgvSupplySalesDamage.Name = "dgvSupplySalesDamage";
            this.dgvSupplySalesDamage.Size = new System.Drawing.Size(351, 458);
            this.dgvSupplySalesDamage.TabIndex = 3;
            // 
            // frmRemainingSupplyFrames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 524);
            this.Controls.Add(this.dgvSupplySalesDamage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvFrames);
            this.Controls.Add(this.dgvSupply);
            this.Name = "frmRemainingSupplyFrames";
            this.Text = "Remaining Supply / Remaining Frames";
            this.Load += new System.EventHandler(this.frmRemainingSupplyFrames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplySalesDamage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupply;
        private System.Windows.Forms.DataGridView dgvFrames;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvSupplySalesDamage;
    }
}