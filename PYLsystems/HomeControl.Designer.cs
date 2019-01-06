namespace PYLsystems
{
    partial class HomeControl
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
            this.settings = new System.Windows.Forms.Button();
            this.empManButtton = new System.Windows.Forms.Button();
            this.inventButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.homePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings
            // 
            this.settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settings.Location = new System.Drawing.Point(447, 462);
            this.settings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(55, 49);
            this.settings.TabIndex = 15;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // empManButtton
            // 
            this.empManButtton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empManButtton.Location = new System.Drawing.Point(143, 81);
            this.empManButtton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.empManButtton.Name = "empManButtton";
            this.empManButtton.Size = new System.Drawing.Size(245, 53);
            this.empManButtton.TabIndex = 12;
            this.empManButtton.Text = "Employee Management";
            this.empManButtton.UseVisualStyleBackColor = true;
            this.empManButtton.Click += new System.EventHandler(this.empManButtton_Click);
            // 
            // inventButton
            // 
            this.inventButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventButton.Location = new System.Drawing.Point(143, 344);
            this.inventButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inventButton.Name = "inventButton";
            this.inventButton.Size = new System.Drawing.Size(245, 53);
            this.inventButton.TabIndex = 14;
            this.inventButton.Text = "Inventory";
            this.inventButton.UseVisualStyleBackColor = true;
            this.inventButton.Click += new System.EventHandler(this.inventButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salesButton.Location = new System.Drawing.Point(143, 210);
            this.salesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(245, 53);
            this.salesButton.TabIndex = 13;
            this.salesButton.Text = "Sales";
            this.salesButton.UseVisualStyleBackColor = true;
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.settings);
            this.homePanel.Controls.Add(this.empManButtton);
            this.homePanel.Controls.Add(this.salesButton);
            this.homePanel.Controls.Add(this.inventButton);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(532, 549);
            this.homePanel.TabIndex = 16;
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.homePanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(532, 549);
            this.homePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button empManButtton;
        private System.Windows.Forms.Button inventButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Panel homePanel;
    }
}
