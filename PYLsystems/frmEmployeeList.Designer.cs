namespace PYLsystems
{
    partial class frmEmployeeList
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
            this.dgEmpList = new System.Windows.Forms.DataGridView();
            this.btnNewEmp = new System.Windows.Forms.Button();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.btnViewEmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmpList = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewAttendance = new System.Windows.Forms.Button();
            this.payrollBtn = new System.Windows.Forms.Button();
            this.BtnNewWorkDesc = new System.Windows.Forms.Button();
            this.btnArchiveRec = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgEmpList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmpList
            // 
            this.dgEmpList.AllowUserToAddRows = false;
            this.dgEmpList.AllowUserToDeleteRows = false;
            this.dgEmpList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpList.Location = new System.Drawing.Point(22, 85);
            this.dgEmpList.Name = "dgEmpList";
            this.dgEmpList.ReadOnly = true;
            this.dgEmpList.RowHeadersVisible = false;
            this.dgEmpList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmpList.Size = new System.Drawing.Size(495, 254);
            this.dgEmpList.TabIndex = 0;
            this.dgEmpList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpList_CellClick);
            // 
            // btnNewEmp
            // 
            this.btnNewEmp.Location = new System.Drawing.Point(22, 354);
            this.btnNewEmp.Name = "btnNewEmp";
            this.btnNewEmp.Size = new System.Drawing.Size(101, 43);
            this.btnNewEmp.TabIndex = 1;
            this.btnNewEmp.Text = "New Employee";
            this.btnNewEmp.UseVisualStyleBackColor = true;
            this.btnNewEmp.Click += new System.EventHandler(this.btnNewEmp_Click);
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.Location = new System.Drawing.Point(289, 354);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(101, 43);
            this.btnUpdateEmp.TabIndex = 2;
            this.btnUpdateEmp.Text = "Update Employee";
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // btnViewEmp
            // 
            this.btnViewEmp.Location = new System.Drawing.Point(156, 354);
            this.btnViewEmp.Name = "btnViewEmp";
            this.btnViewEmp.Size = new System.Drawing.Size(101, 43);
            this.btnViewEmp.TabIndex = 4;
            this.btnViewEmp.Text = "View Employee";
            this.btnViewEmp.UseVisualStyleBackColor = true;
            this.btnViewEmp.Click += new System.EventHandler(this.btnViewEmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee List";
            // 
            // btnEmpList
            // 
            this.btnEmpList.Location = new System.Drawing.Point(416, 407);
            this.btnEmpList.Name = "btnEmpList";
            this.btnEmpList.Size = new System.Drawing.Size(101, 40);
            this.btnEmpList.TabIndex = 3;
            this.btnEmpList.Text = "Close";
            this.btnEmpList.UseVisualStyleBackColor = true;
            this.btnEmpList.Click += new System.EventHandler(this.btnEmpList_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(66, 59);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(161, 20);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search";
            // 
            // viewAttendance
            // 
            this.viewAttendance.Location = new System.Drawing.Point(416, 354);
            this.viewAttendance.Name = "viewAttendance";
            this.viewAttendance.Size = new System.Drawing.Size(101, 43);
            this.viewAttendance.TabIndex = 8;
            this.viewAttendance.Text = "Attendance";
            this.viewAttendance.UseVisualStyleBackColor = true;
            this.viewAttendance.Click += new System.EventHandler(this.viewAttendance_Click);
            // 

            // payrollBtn
            // 
            this.payrollBtn.Location = new System.Drawing.Point(22, 407);
            this.payrollBtn.Name = "payrollBtn";
            this.payrollBtn.Size = new System.Drawing.Size(101, 43);
            this.payrollBtn.TabIndex = 9;
            this.payrollBtn.Text = "Payroll";
            this.payrollBtn.UseVisualStyleBackColor = true;
            // 
            // BtnNewWorkDesc
            // 
            this.BtnNewWorkDesc.Location = new System.Drawing.Point(156, 407);
            this.BtnNewWorkDesc.Name = "BtnNewWorkDesc";
            this.BtnNewWorkDesc.Size = new System.Drawing.Size(101, 40);
            this.BtnNewWorkDesc.TabIndex = 10;
            this.BtnNewWorkDesc.Text = "Create Work Description";
            this.BtnNewWorkDesc.UseVisualStyleBackColor = true;
            this.BtnNewWorkDesc.Click += new System.EventHandler(this.BtnNewWorkDesc_Click);
            // 
            // btnArchiveRec
            // 
            this.btnArchiveRec.Location = new System.Drawing.Point(289, 407);
            this.btnArchiveRec.Name = "btnArchiveRec";
            this.btnArchiveRec.Size = new System.Drawing.Size(101, 40);
            this.btnArchiveRec.TabIndex = 11;
            this.btnArchiveRec.Text = "Archive List";
            this.btnArchiveRec.UseVisualStyleBackColor = true;
            this.btnArchiveRec.Click += new System.EventHandler(this.btnArchiveRec_Click);
            // 

            // frmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(538, 469);
            this.Controls.Add(this.btnArchiveRec);
            this.Controls.Add(this.BtnNewWorkDesc);
            this.Controls.Add(this.payrollBtn);

            this.ClientSize = new System.Drawing.Size(813, 653);

            this.Controls.Add(this.viewAttendance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewEmp);
            this.Controls.Add(this.btnEmpList);
            this.Controls.Add(this.btnUpdateEmp);
            this.Controls.Add(this.btnNewEmp);
            this.Controls.Add(this.dgEmpList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmpList;
        private System.Windows.Forms.Button btnNewEmp;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Button btnViewEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewAttendance;
        private System.Windows.Forms.Button payrollBtn;
        private System.Windows.Forms.Button BtnNewWorkDesc;
        private System.Windows.Forms.Button btnArchiveRec;
    }
}