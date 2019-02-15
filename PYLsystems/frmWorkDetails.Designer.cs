namespace PYLsystems
{
    partial class frmWorkDetails
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
            this.dgvWorkList = new System.Windows.Forms.DataGridView();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.BtnEmployeeMgt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Work List";
            // 
            // dgvWorkList
            // 
            this.dgvWorkList.AllowUserToAddRows = false;
            this.dgvWorkList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkList.Location = new System.Drawing.Point(12, 50);
            this.dgvWorkList.Name = "dgvWorkList";
            this.dgvWorkList.ReadOnly = true;
            this.dgvWorkList.Size = new System.Drawing.Size(497, 185);
            this.dgvWorkList.TabIndex = 3;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(87, 253);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(90, 37);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "Set Work Detail";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(209, 253);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(90, 37);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View Work Detail";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnEmployeeMgt
            // 
            this.BtnEmployeeMgt.Location = new System.Drawing.Point(331, 253);
            this.BtnEmployeeMgt.Name = "BtnEmployeeMgt";
            this.BtnEmployeeMgt.Size = new System.Drawing.Size(90, 37);
            this.BtnEmployeeMgt.TabIndex = 6;
            this.BtnEmployeeMgt.Text = "Employee Management";
            this.BtnEmployeeMgt.UseVisualStyleBackColor = true;
            // 
            // frmWorkDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 311);
            this.Controls.Add(this.BtnEmployeeMgt);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.dgvWorkList);
            this.Controls.Add(this.label1);
            this.Name = "frmWorkDetails";
            this.Text = "frmWorkDetails";
            this.Load += new System.EventHandler(this.frmWorkDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button BtnEmployeeMgt;
        public System.Windows.Forms.DataGridView dgvWorkList;
    }
}