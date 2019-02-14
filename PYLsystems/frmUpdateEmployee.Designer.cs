namespace Employee_Management
{
    partial class frmUpdateEmployee
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
            this.empid = new System.Windows.Forms.Label();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblSalaryRate = new System.Windows.Forms.Label();
            this.lblHomeAddress = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStartofEmp = new System.Windows.Forms.Label();
            this.lblEmpStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cbEmpStatus = new System.Windows.Forms.ComboBox();
            this.txtSalaryRate = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.dtpStartofEmp = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // empid
            // 
            this.empid.AutoSize = true;
            this.empid.Location = new System.Drawing.Point(182, 9);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(41, 13);
            this.empid.TabIndex = 39;
            this.empid.Text = "label10";
            this.empid.Visible = false;
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.Location = new System.Drawing.Point(163, 436);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(93, 29);
            this.btnUpdateEmp.TabIndex = 38;
            this.btnUpdateEmp.Text = "Update";
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(474, 349);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 37;
            this.lblContactNumber.Text = "Contact Number";
            this.lblContactNumber.Visible = false;
            // 
            // lblSalaryRate
            // 
            this.lblSalaryRate.AutoSize = true;
            this.lblSalaryRate.Location = new System.Drawing.Point(474, 315);
            this.lblSalaryRate.Name = "lblSalaryRate";
            this.lblSalaryRate.Size = new System.Drawing.Size(62, 13);
            this.lblSalaryRate.TabIndex = 36;
            this.lblSalaryRate.Text = "Salary Rate";
            this.lblSalaryRate.Visible = false;
            // 
            // lblHomeAddress
            // 
            this.lblHomeAddress.AutoSize = true;
            this.lblHomeAddress.Location = new System.Drawing.Point(474, 283);
            this.lblHomeAddress.Name = "lblHomeAddress";
            this.lblHomeAddress.Size = new System.Drawing.Size(79, 13);
            this.lblHomeAddress.TabIndex = 35;
            this.lblHomeAddress.Text = "Homer Address";
            this.lblHomeAddress.Visible = false;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(474, 245);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 34;
            this.lblBirthDate.Text = "Birth Date";
            this.lblBirthDate.Visible = false;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(474, 208);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 33;
            this.lblGender.Text = "Gender";
            this.lblGender.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(474, 172);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 32;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(474, 133);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 31;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.Visible = false;
            // 
            // lblStartofEmp
            // 
            this.lblStartofEmp.AutoSize = true;
            this.lblStartofEmp.Location = new System.Drawing.Point(474, 88);
            this.lblStartofEmp.Name = "lblStartofEmp";
            this.lblStartofEmp.Size = new System.Drawing.Size(101, 13);
            this.lblStartofEmp.TabIndex = 30;
            this.lblStartofEmp.Text = "Start of Employment";
            this.lblStartofEmp.Visible = false;
            // 
            // lblEmpStatus
            // 
            this.lblEmpStatus.AutoSize = true;
            this.lblEmpStatus.Location = new System.Drawing.Point(474, 52);
            this.lblEmpStatus.Name = "lblEmpStatus";
            this.lblEmpStatus.Size = new System.Drawing.Size(86, 13);
            this.lblEmpStatus.TabIndex = 29;
            this.lblEmpStatus.Text = "Employee Status";
            this.lblEmpStatus.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Contact Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Salary Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Home Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Birth Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Start of Employment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Employee Status";
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Location = new System.Drawing.Point(163, 295);
            this.txtHomeAddress.Multiline = true;
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(211, 44);
            this.txtHomeAddress.TabIndex = 45;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(163, 165);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(211, 20);
            this.txtLastName.TabIndex = 44;
            // 
            // cbEmpStatus
            // 
            this.cbEmpStatus.FormattingEnabled = true;
            this.cbEmpStatus.Location = new System.Drawing.Point(163, 44);
            this.cbEmpStatus.Name = "cbEmpStatus";
            this.cbEmpStatus.Size = new System.Drawing.Size(211, 21);
            this.cbEmpStatus.TabIndex = 43;
            this.cbEmpStatus.SelectedIndexChanged += new System.EventHandler(this.cbEmpStatus_SelectedIndexChanged);
            // 
            // txtSalaryRate
            // 
            this.txtSalaryRate.Location = new System.Drawing.Point(163, 357);
            this.txtSalaryRate.Name = "txtSalaryRate";
            this.txtSalaryRate.Size = new System.Drawing.Size(211, 20);
            this.txtSalaryRate.TabIndex = 42;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(163, 395);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(211, 20);
            this.txtContactNumber.TabIndex = 41;
            this.txtContactNumber.TextChanged += new System.EventHandler(this.txtContactNumber_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(163, 126);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(211, 20);
            this.txtFirstName.TabIndex = 40;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(281, 436);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(93, 29);
            this.btCancel.TabIndex = 49;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // cbGender
            // 
            this.cbGender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbGender.Items.AddRange(new object[] {
            "Male\t",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(163, 200);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(211, 21);
            this.cbGender.TabIndex = 50;
            // 
            // dtpStartofEmp
            // 
            this.dtpStartofEmp.CustomFormat = "yyyy-MM-dd";
            this.dtpStartofEmp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartofEmp.Location = new System.Drawing.Point(163, 82);
            this.dtpStartofEmp.Name = "dtpStartofEmp";
            this.dtpStartofEmp.Size = new System.Drawing.Size(211, 20);
            this.dtpStartofEmp.TabIndex = 51;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "yyyy-MM-dd";
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(158, 237);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(216, 20);
            this.dtpBirthDate.TabIndex = 52;
            // 
            // frmUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 484);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.dtpStartofEmp);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.txtHomeAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.cbEmpStatus);
            this.Controls.Add(this.txtSalaryRate);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.empid);
            this.Controls.Add(this.btnUpdateEmp);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblSalaryRate);
            this.Controls.Add(this.lblHomeAddress);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStartofEmp);
            this.Controls.Add(this.lblEmpStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateEmployee";
            this.Load += new System.EventHandler(this.frmUpdateEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label empid;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cbEmpStatus;
        private System.Windows.Forms.TextBox txtSalaryRate;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btCancel;
        public System.Windows.Forms.Label lblContactNumber;
        public System.Windows.Forms.Label lblSalaryRate;
        public System.Windows.Forms.Label lblHomeAddress;
        public System.Windows.Forms.Label lblBirthDate;
        public System.Windows.Forms.Label lblGender;
        public System.Windows.Forms.Label lblLastName;
        public System.Windows.Forms.Label lblFirstName;
        public System.Windows.Forms.Label lblStartofEmp;
        public System.Windows.Forms.Label lblEmpStatus;
        private System.Windows.Forms.ComboBox cbGender;
        public System.Windows.Forms.DateTimePicker dtpStartofEmp;
        public System.Windows.Forms.DateTimePicker dtpBirthDate;
    }
}