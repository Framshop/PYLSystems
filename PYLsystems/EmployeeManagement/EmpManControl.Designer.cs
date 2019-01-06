namespace PYLsystems
{
    partial class EmpManControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backButton = new System.Windows.Forms.Button();
            this.empListButtton = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.attendButton = new System.Windows.Forms.Button();
            this.payrollButton = new System.Windows.Forms.Button();
            this.empManPanel = new System.Windows.Forms.Panel();
            this.empManPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.Location = new System.Drawing.Point(44, 24);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(83, 75);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // empListButtton
            // 
            this.empListButtton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empListButtton.Location = new System.Drawing.Point(215, 128);
            this.empListButtton.Name = "empListButtton";
            this.empListButtton.Size = new System.Drawing.Size(368, 81);
            this.empListButtton.TabIndex = 10;
            this.empListButtton.Text = "Employees List";
            this.empListButtton.UseVisualStyleBackColor = true;
            this.empListButtton.Click += new System.EventHandler(this.empListButtton_Click);
            // 
            // settings
            // 
            this.settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settings.Location = new System.Drawing.Point(671, 711);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(83, 75);
            this.settings.TabIndex = 13;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // attendButton
            // 
            this.attendButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attendButton.Location = new System.Drawing.Point(215, 323);
            this.attendButton.Name = "attendButton";
            this.attendButton.Size = new System.Drawing.Size(368, 81);
            this.attendButton.TabIndex = 11;
            this.attendButton.Text = "Attendance";
            this.attendButton.UseVisualStyleBackColor = true;
            // 
            // payrollButton
            // 
            this.payrollButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.payrollButton.Location = new System.Drawing.Point(215, 529);
            this.payrollButton.Name = "payrollButton";
            this.payrollButton.Size = new System.Drawing.Size(368, 81);
            this.payrollButton.TabIndex = 12;
            this.payrollButton.Text = "Payroll";
            this.payrollButton.UseVisualStyleBackColor = true;
            // 
            // empManPanel
            // 
            this.empManPanel.Controls.Add(this.backButton);
            this.empManPanel.Controls.Add(this.attendButton);
            this.empManPanel.Controls.Add(this.empListButtton);
            this.empManPanel.Controls.Add(this.payrollButton);
            this.empManPanel.Controls.Add(this.settings);
            this.empManPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empManPanel.Location = new System.Drawing.Point(0, 0);
            this.empManPanel.Name = "empManPanel";
            this.empManPanel.Size = new System.Drawing.Size(798, 844);
            this.empManPanel.TabIndex = 15;
            // 
            // EmpManControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.empManPanel);
            this.Name = "EmpManControl";
            this.Size = new System.Drawing.Size(798, 844);
            this.empManPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button empListButtton;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button attendButton;
        private System.Windows.Forms.Button payrollButton;
        private System.Windows.Forms.Panel empManPanel;
    }
}
