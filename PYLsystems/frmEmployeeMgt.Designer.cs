namespace PYLsystems
{
    partial class frmEmployeeMgt
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
            this.btnEmpList = new System.Windows.Forms.Button();
            this.payrollBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpList
            // 
            this.btnEmpList.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEmpList.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpList.ImageIndex = 0;
            this.btnEmpList.Location = new System.Drawing.Point(12, 12);
            this.btnEmpList.Name = "btnEmpList";
            this.btnEmpList.Size = new System.Drawing.Size(371, 105);
            this.btnEmpList.TabIndex = 0;
            this.btnEmpList.Text = "Employee List";
            this.btnEmpList.UseVisualStyleBackColor = false;
            this.btnEmpList.Click += new System.EventHandler(this.btnEmpList_Click);
            // 
            // payrollBtn
            // 
            this.payrollBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.payrollBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollBtn.Location = new System.Drawing.Point(12, 127);
            this.payrollBtn.Name = "payrollBtn";
            this.payrollBtn.Size = new System.Drawing.Size(371, 93);
            this.payrollBtn.TabIndex = 1;
            this.payrollBtn.Text = "Payroll";
            this.payrollBtn.UseVisualStyleBackColor = false;
            this.payrollBtn.Click += new System.EventHandler(this.payrollBtn_Click);
            // 
            // frmEmployeeMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(395, 232);
            this.Controls.Add(this.payrollBtn);
            this.Controls.Add(this.btnEmpList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEmployeeMgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEmployeeMgt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpList;
        private System.Windows.Forms.Button payrollBtn;
    }
}

