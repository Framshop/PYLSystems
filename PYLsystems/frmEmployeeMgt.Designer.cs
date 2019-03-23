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
            this.btnEmpList.Location = new System.Drawing.Point(217, 79);
            this.btnEmpList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmpList.Name = "btnEmpList";
            this.btnEmpList.Size = new System.Drawing.Size(188, 80);
            this.btnEmpList.TabIndex = 0;
            this.btnEmpList.Text = "EmployeeList";
            this.btnEmpList.UseVisualStyleBackColor = false;
            this.btnEmpList.Click += new System.EventHandler(this.btnEmpList_Click);
            // 
            // payrollBtn
            // 
            this.payrollBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.payrollBtn.Location = new System.Drawing.Point(217, 210);
            this.payrollBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.payrollBtn.Name = "payrollBtn";
            this.payrollBtn.Size = new System.Drawing.Size(188, 80);
            this.payrollBtn.TabIndex = 1;
            this.payrollBtn.Text = "Payroll";
            this.payrollBtn.UseVisualStyleBackColor = false;
            this.payrollBtn.Click += new System.EventHandler(this.payrollBtn_Click);
            // 
            // frmEmployeeMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(627, 371);
            this.Controls.Add(this.payrollBtn);
            this.Controls.Add(this.btnEmpList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEmployeeMgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management";
            this.Load += new System.EventHandler(this.frmEmployeeMgt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpList;
        private System.Windows.Forms.Button payrollBtn;
    }
}

