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
            this.BtnNewWorkDesc = new System.Windows.Forms.Button();
            this.btnArchiveRec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmpList
            // 
            this.dgEmpList.AllowUserToAddRows = false;
            this.dgEmpList.AllowUserToDeleteRows = false;
            this.dgEmpList.AllowUserToResizeRows = false;
            this.dgEmpList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpList.Location = new System.Drawing.Point(38, 77);
            this.dgEmpList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgEmpList.Name = "dgEmpList";
            this.dgEmpList.ReadOnly = true;
            this.dgEmpList.RowHeadersVisible = false;
            this.dgEmpList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmpList.Size = new System.Drawing.Size(742, 391);
            this.dgEmpList.TabIndex = 0;
            // 
            // btnNewEmp
            // 
            this.btnNewEmp.Location = new System.Drawing.Point(38, 491);
            this.btnNewEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewEmp.Name = "btnNewEmp";
            this.btnNewEmp.Size = new System.Drawing.Size(152, 66);
            this.btnNewEmp.TabIndex = 1;
            this.btnNewEmp.Text = "New Employee";
            this.btnNewEmp.UseVisualStyleBackColor = true;
            this.btnNewEmp.Click += new System.EventHandler(this.btnNewEmp_Click);
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.Location = new System.Drawing.Point(438, 491);
            this.btnUpdateEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(152, 66);
            this.btnUpdateEmp.TabIndex = 2;
            this.btnUpdateEmp.Text = "Update Employee";
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // btnViewEmp
            // 
            this.btnViewEmp.Location = new System.Drawing.Point(238, 491);
            this.btnViewEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewEmp.Name = "btnViewEmp";
            this.btnViewEmp.Size = new System.Drawing.Size(152, 66);
            this.btnViewEmp.TabIndex = 4;
            this.btnViewEmp.Text = "View Employee";
            this.btnViewEmp.UseVisualStyleBackColor = true;
            this.btnViewEmp.Click += new System.EventHandler(this.btnViewEmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee List";
            // 
            // btnEmpList
            // 
            this.btnEmpList.Location = new System.Drawing.Point(628, 573);
            this.btnEmpList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmpList.Name = "btnEmpList";
            this.btnEmpList.Size = new System.Drawing.Size(152, 66);
            this.btnEmpList.TabIndex = 3;
            this.btnEmpList.Text = "Close";
            this.btnEmpList.UseVisualStyleBackColor = true;
            this.btnEmpList.Click += new System.EventHandler(this.btnEmpList_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(104, 37);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(193, 26);
            this.txtSearch.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search";
            // 
            // viewAttendance
            // 
            this.viewAttendance.Location = new System.Drawing.Point(628, 491);
            this.viewAttendance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewAttendance.Name = "viewAttendance";
            this.viewAttendance.Size = new System.Drawing.Size(152, 66);
            this.viewAttendance.TabIndex = 8;
            this.viewAttendance.Text = "Attendance";
            this.viewAttendance.UseVisualStyleBackColor = true;
            this.viewAttendance.Click += new System.EventHandler(this.viewAttendance_Click);
            // 
            // BtnNewWorkDesc
            // 
            this.BtnNewWorkDesc.Location = new System.Drawing.Point(38, 575);
            this.BtnNewWorkDesc.Name = "BtnNewWorkDesc";
            this.BtnNewWorkDesc.Size = new System.Drawing.Size(152, 66);
            this.BtnNewWorkDesc.TabIndex = 10;
            this.BtnNewWorkDesc.Text = "Create Work Description";
            this.BtnNewWorkDesc.UseVisualStyleBackColor = true;
            this.BtnNewWorkDesc.Click += new System.EventHandler(this.BtnNewWorkDesc_Click);
            // 
            // btnArchiveRec
            // 
            this.btnArchiveRec.Location = new System.Drawing.Point(438, 573);
            this.btnArchiveRec.Name = "btnArchiveRec";
            this.btnArchiveRec.Size = new System.Drawing.Size(152, 66);
            this.btnArchiveRec.TabIndex = 11;
            this.btnArchiveRec.Text = "Archive List";
            this.btnArchiveRec.UseVisualStyleBackColor = true;
            this.btnArchiveRec.Click += new System.EventHandler(this.btnArchiveRec_Click);
            // 
            // frmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 653);
            this.Controls.Add(this.btnArchiveRec);
            this.Controls.Add(this.BtnNewWorkDesc);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployeeList";
            this.Load += new System.EventHandler(this.frmEmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgEmpList;
        private System.Windows.Forms.Button btnNewEmp;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Button btnViewEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewAttendance;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button BtnNewWorkDesc;
        private System.Windows.Forms.Button btnArchiveRec;

    }
}