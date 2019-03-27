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
            this.dgEmpList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgEmpList.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgEmpList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgEmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpList.Location = new System.Drawing.Point(159, 64);
            this.dgEmpList.Name = "dgEmpList";
            this.dgEmpList.ReadOnly = true;
            this.dgEmpList.RowHeadersVisible = false;
            this.dgEmpList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmpList.Size = new System.Drawing.Size(580, 421);
            this.dgEmpList.TabIndex = 0;
            // 
            // btnNewEmp
            // 
            this.btnNewEmp.BackColor = System.Drawing.Color.PaleGreen;
            this.btnNewEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEmp.Location = new System.Drawing.Point(12, 64);
            this.btnNewEmp.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.btnNewEmp.Name = "btnNewEmp";
            this.btnNewEmp.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.btnNewEmp.Size = new System.Drawing.Size(134, 43);
            this.btnNewEmp.TabIndex = 1;
            this.btnNewEmp.Text = "New Employee";
            this.btnNewEmp.UseVisualStyleBackColor = false;
            this.btnNewEmp.Click += new System.EventHandler(this.btnNewEmp_Click);
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUpdateEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmp.Location = new System.Drawing.Point(12, 127);
            this.btnUpdateEmp.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(134, 43);
            this.btnUpdateEmp.TabIndex = 2;
            this.btnUpdateEmp.Text = "Update Employee";
            this.btnUpdateEmp.UseVisualStyleBackColor = false;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // btnViewEmp
            // 
            this.btnViewEmp.BackColor = System.Drawing.Color.PaleGreen;
            this.btnViewEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEmp.Location = new System.Drawing.Point(12, 190);
            this.btnViewEmp.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.btnViewEmp.Name = "btnViewEmp";
            this.btnViewEmp.Size = new System.Drawing.Size(134, 43);
            this.btnViewEmp.TabIndex = 4;
            this.btnViewEmp.Text = "View Employee";
            this.btnViewEmp.UseVisualStyleBackColor = false;
            this.btnViewEmp.Click += new System.EventHandler(this.btnViewEmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee List";
            // 
            // btnEmpList
            // 
            this.btnEmpList.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEmpList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpList.Location = new System.Drawing.Point(12, 442);
            this.btnEmpList.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.btnEmpList.Name = "btnEmpList";
            this.btnEmpList.Size = new System.Drawing.Size(134, 43);
            this.btnEmpList.TabIndex = 3;
            this.btnEmpList.Text = "Close";
            this.btnEmpList.UseVisualStyleBackColor = false;
            this.btnEmpList.Click += new System.EventHandler(this.btnEmpList_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(543, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 20);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search";
            // 
            // viewAttendance
            // 
            this.viewAttendance.BackColor = System.Drawing.Color.PaleGreen;
            this.viewAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAttendance.Location = new System.Drawing.Point(12, 253);
            this.viewAttendance.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.viewAttendance.Name = "viewAttendance";
            this.viewAttendance.Size = new System.Drawing.Size(134, 43);
            this.viewAttendance.TabIndex = 8;
            this.viewAttendance.Text = "Attendance";
            this.viewAttendance.UseVisualStyleBackColor = false;
            this.viewAttendance.Click += new System.EventHandler(this.viewAttendance_Click);
            // 
            // BtnNewWorkDesc
            // 
            this.BtnNewWorkDesc.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnNewWorkDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewWorkDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewWorkDesc.Location = new System.Drawing.Point(12, 379);
            this.BtnNewWorkDesc.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.BtnNewWorkDesc.Name = "BtnNewWorkDesc";
            this.BtnNewWorkDesc.Size = new System.Drawing.Size(134, 43);
            this.BtnNewWorkDesc.TabIndex = 10;
            this.BtnNewWorkDesc.Text = "New Work Position";
            this.BtnNewWorkDesc.UseVisualStyleBackColor = false;
            this.BtnNewWorkDesc.Visible = false;
            this.BtnNewWorkDesc.Click += new System.EventHandler(this.BtnNewWorkDesc_Click);
            // 
            // btnArchiveRec
            // 
            this.btnArchiveRec.BackColor = System.Drawing.Color.PaleGreen;
            this.btnArchiveRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchiveRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveRec.Location = new System.Drawing.Point(12, 316);
            this.btnArchiveRec.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.btnArchiveRec.Name = "btnArchiveRec";
            this.btnArchiveRec.Size = new System.Drawing.Size(134, 43);
            this.btnArchiveRec.TabIndex = 11;
            this.btnArchiveRec.Text = "Archive List";
            this.btnArchiveRec.UseVisualStyleBackColor = false;
            this.btnArchiveRec.Click += new System.EventHandler(this.btnArchiveRec_Click);
            // 
            // frmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(753, 496);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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