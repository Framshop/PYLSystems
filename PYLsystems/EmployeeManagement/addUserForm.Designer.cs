namespace PYLsystems.EmployeeManagement
{
    partial class addUserForm
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passLabel = new System.Windows.Forms.Label();
            this.confPassLabel = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.confPassText = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(33, 40);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(83, 20);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.confPassText);
            this.panel1.Controls.Add(this.passText);
            this.panel1.Controls.Add(this.userNameText);
            this.panel1.Controls.Add(this.confPassLabel);
            this.panel1.Controls.Add(this.passLabel);
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 288);
            this.panel1.TabIndex = 1;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(33, 100);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(78, 20);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Password";
            // 
            // confPassLabel
            // 
            this.confPassLabel.AutoSize = true;
            this.confPassLabel.Location = new System.Drawing.Point(33, 160);
            this.confPassLabel.Name = "confPassLabel";
            this.confPassLabel.Size = new System.Drawing.Size(137, 20);
            this.confPassLabel.TabIndex = 2;
            this.confPassLabel.Text = "Confirm Password";
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(198, 33);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(301, 26);
            this.userNameText.TabIndex = 3;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(198, 94);
            this.passText.Name = "passText";
            this.passText.PasswordChar = '•';
            this.passText.Size = new System.Drawing.Size(301, 26);
            this.passText.TabIndex = 4;
            this.passText.UseSystemPasswordChar = true;
            // 
            // confPassText
            // 
            this.confPassText.Location = new System.Drawing.Point(198, 154);
            this.confPassText.Name = "confPassText";
            this.confPassText.PasswordChar = '•';
            this.confPassText.Size = new System.Drawing.Size(301, 26);
            this.confPassText.TabIndex = 5;
            this.confPassText.UseSystemPasswordChar = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(390, 226);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(109, 42);
            this.nextButton.TabIndex = 16;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(37, 226);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(109, 42);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // addUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 312);
            this.Controls.Add(this.panel1);
            this.Name = "addUserForm";
            this.Text = "Add Employee User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox confPassText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.Label confPassLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
    }
}