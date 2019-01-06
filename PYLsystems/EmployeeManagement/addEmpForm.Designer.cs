namespace PYLsystems.EmployeeManagement
{
    partial class addEmpForm
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
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.bdateLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fNameText = new System.Windows.Forms.TextBox();
            this.lNameText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.contactText = new System.Windows.Forms.TextBox();
            this.genderCombo = new System.Windows.Forms.ComboBox();
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.addEmpDetPanel = new System.Windows.Forms.Panel();
            this.addEmpDetPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Location = new System.Drawing.Point(47, 44);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(86, 20);
            this.fnameLabel.TabIndex = 0;
            this.fnameLabel.Text = "First Name";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Location = new System.Drawing.Point(47, 84);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(86, 20);
            this.lnameLabel.TabIndex = 1;
            this.lnameLabel.Text = "Last Name";
            // 
            // bdateLabel
            // 
            this.bdateLabel.AutoSize = true;
            this.bdateLabel.Location = new System.Drawing.Point(47, 124);
            this.bdateLabel.Name = "bdateLabel";
            this.bdateLabel.Size = new System.Drawing.Size(74, 20);
            this.bdateLabel.TabIndex = 2;
            this.bdateLabel.Text = "Birthdate";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(47, 164);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(63, 20);
            this.genderLabel.TabIndex = 3;
            this.genderLabel.Text = "Gender";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(47, 204);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(68, 20);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(47, 244);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(93, 20);
            this.contactLabel.TabIndex = 5;
            this.contactLabel.Text = "Contact No.";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(47, 284);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(56, 20);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.CustomFormat = "MMM. dd, yyyy";
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDatePicker.Location = new System.Drawing.Point(182, 118);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(271, 26);
            this.birthDatePicker.TabIndex = 7;
            this.birthDatePicker.Value = new System.DateTime(2018, 10, 24, 0, 0, 0, 0);
            // 
            // fNameText
            // 
            this.fNameText.Location = new System.Drawing.Point(182, 38);
            this.fNameText.Name = "fNameText";
            this.fNameText.Size = new System.Drawing.Size(497, 26);
            this.fNameText.TabIndex = 8;
            // 
            // lNameText
            // 
            this.lNameText.Location = new System.Drawing.Point(182, 78);
            this.lNameText.Name = "lNameText";
            this.lNameText.Size = new System.Drawing.Size(497, 26);
            this.lNameText.TabIndex = 9;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(182, 198);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(497, 26);
            this.addressText.TabIndex = 10;
            // 
            // contactText
            // 
            this.contactText.Location = new System.Drawing.Point(182, 238);
            this.contactText.Name = "contactText";
            this.contactText.Size = new System.Drawing.Size(497, 26);
            this.contactText.TabIndex = 11;
            // 
            // genderCombo
            // 
            this.genderCombo.FormattingEnabled = true;
            this.genderCombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderCombo.Location = new System.Drawing.Point(182, 156);
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(271, 28);
            this.genderCombo.TabIndex = 12;
            // 
            // statusCombo
            // 
            this.statusCombo.FormattingEnabled = true;
            this.statusCombo.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusCombo.Location = new System.Drawing.Point(182, 276);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(271, 28);
            this.statusCombo.TabIndex = 13;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(37, 359);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(109, 42);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(570, 359);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(109, 42);
            this.nextButton.TabIndex = 15;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // addEmpDetPanel
            // 
            this.addEmpDetPanel.Controls.Add(this.nextButton);
            this.addEmpDetPanel.Controls.Add(this.fNameText);
            this.addEmpDetPanel.Controls.Add(this.cancelButton);
            this.addEmpDetPanel.Controls.Add(this.fnameLabel);
            this.addEmpDetPanel.Controls.Add(this.statusCombo);
            this.addEmpDetPanel.Controls.Add(this.lnameLabel);
            this.addEmpDetPanel.Controls.Add(this.genderCombo);
            this.addEmpDetPanel.Controls.Add(this.bdateLabel);
            this.addEmpDetPanel.Controls.Add(this.contactText);
            this.addEmpDetPanel.Controls.Add(this.genderLabel);
            this.addEmpDetPanel.Controls.Add(this.addressText);
            this.addEmpDetPanel.Controls.Add(this.addressLabel);
            this.addEmpDetPanel.Controls.Add(this.lNameText);
            this.addEmpDetPanel.Controls.Add(this.contactLabel);
            this.addEmpDetPanel.Controls.Add(this.statusLabel);
            this.addEmpDetPanel.Controls.Add(this.birthDatePicker);
            this.addEmpDetPanel.Location = new System.Drawing.Point(12, 13);
            this.addEmpDetPanel.Name = "addEmpDetPanel";
            this.addEmpDetPanel.Size = new System.Drawing.Size(721, 425);
            this.addEmpDetPanel.TabIndex = 16;
            // 
            // addEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.addEmpDetPanel);
            this.Name = "addEmpForm";
            this.Text = "Add Employee";
            this.addEmpDetPanel.ResumeLayout(false);
            this.addEmpDetPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label bdateLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.TextBox fNameText;
        private System.Windows.Forms.TextBox lNameText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox contactText;
        private System.Windows.Forms.ComboBox genderCombo;
        private System.Windows.Forms.ComboBox statusCombo;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Panel addEmpDetPanel;
    }
}