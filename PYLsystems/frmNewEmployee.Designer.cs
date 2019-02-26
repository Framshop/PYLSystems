namespace PYLsystems
{
    partial class frmNewEmployee
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSalaryRate = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbEmpStatus = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.dtpStartofEmp = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblwarning = new System.Windows.Forms.Label();
            this.lblwaring1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(242, 211);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(326, 26);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtSalaryRate
            // 
            this.txtSalaryRate.Location = new System.Drawing.Point(242, 525);
            this.txtSalaryRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalaryRate.Name = "txtSalaryRate";
            this.txtSalaryRate.Size = new System.Drawing.Size(326, 26);
            this.txtSalaryRate.TabIndex = 6;
            this.txtSalaryRate.TextChanged += new System.EventHandler(this.txtSalaryRate_TextChanged);
            this.txtSalaryRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalaryRate_KeyPress);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(242, 589);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(326, 26);
            this.txtContactNumber.TabIndex = 5;
            this.txtContactNumber.TextChanged += new System.EventHandler(this.txtContactNumber_TextChanged);
            this.txtContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Employee Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Start of Employment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 403);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Home Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Birth Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(130, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(100, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(50, 589);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Contact Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(92, 525);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "Hourly Rate";
            // 
            // cbEmpStatus
            // 
            this.cbEmpStatus.FormattingEnabled = true;
            this.cbEmpStatus.Location = new System.Drawing.Point(242, 49);
            this.cbEmpStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEmpStatus.Name = "cbEmpStatus";
            this.cbEmpStatus.Size = new System.Drawing.Size(326, 28);
            this.cbEmpStatus.TabIndex = 20;
            this.cbEmpStatus.SelectedIndexChanged += new System.EventHandler(this.cbEmpStatus_SelectedIndexChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(242, 154);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(326, 26);
            this.txtLastName.TabIndex = 24;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Location = new System.Drawing.Point(246, 403);
            this.txtHomeAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHomeAddress.Multiline = true;
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(326, 84);
            this.txtHomeAddress.TabIndex = 26;
            this.txtHomeAddress.TextChanged += new System.EventHandler(this.txtHomeAddress_TextChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(242, 660);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(147, 51);
            this.btnCreate.TabIndex = 27;
            this.btnCreate.Text = "Create Employee";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(418, 660);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 51);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(692, 334);
            this.status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(51, 20);
            this.status.TabIndex = 31;
            this.status.Text = "label4";
            this.status.Visible = false;
            // 
            // cbGender
            // 
            this.cbGender.DisplayMember = "sdsd";
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(242, 269);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(326, 28);
            this.cbGender.TabIndex = 33;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // dtpStartofEmp
            // 
            this.dtpStartofEmp.CustomFormat = "yyyy-MM-dd";
            this.dtpStartofEmp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartofEmp.Location = new System.Drawing.Point(242, 103);
            this.dtpStartofEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpStartofEmp.Name = "dtpStartofEmp";
            this.dtpStartofEmp.Size = new System.Drawing.Size(326, 26);
            this.dtpStartofEmp.TabIndex = 34;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "yyyy-MM-dd";
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(246, 332);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(326, 26);
            this.dtpBirthDate.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 565);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 36;
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwarning.ForeColor = System.Drawing.Color.Maroon;
            this.lblwarning.Location = new System.Drawing.Point(242, 560);
            this.lblwarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(245, 18);
            this.lblwarning.TabIndex = 37;
            this.lblwarning.Text = "This entry can only contain numbers";
            // 
            // lblwaring1
            // 
            this.lblwaring1.AutoSize = true;
            this.lblwaring1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwaring1.ForeColor = System.Drawing.Color.Maroon;
            this.lblwaring1.Location = new System.Drawing.Point(242, 625);
            this.lblwaring1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwaring1.Name = "lblwaring1";
            this.lblwaring1.Size = new System.Drawing.Size(309, 18);
            this.lblwaring1.TabIndex = 38;
            this.lblwaring1.Text = "This entry can only contain numbers(11 digits)";
            // 
            // frmNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 729);
            this.Controls.Add(this.lblwaring1);
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.dtpStartofEmp);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.status);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtHomeAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.cbEmpStatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalaryRate);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewEmployee";
            this.Load += new System.EventHandler(this.frmNewEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSalaryRate;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbEmpStatus;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ComboBox cbGender;
        public System.Windows.Forms.DateTimePicker dtpStartofEmp;
        public System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.Label lblwaring1;
    }
}