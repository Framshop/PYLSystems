namespace PYLsystems.EmployeeManagement
{
    partial class confirmForm
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
            this.confirmInfoLabel = new System.Windows.Forms.Label();
            this.infoDetail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmButton = new System.Windows.Forms.Button();
            this.backToEmpDetail = new System.Windows.Forms.Button();
            this.backToUserCreate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmInfoLabel
            // 
            this.confirmInfoLabel.AutoSize = true;
            this.confirmInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirmInfoLabel.Location = new System.Drawing.Point(286, 44);
            this.confirmInfoLabel.Name = "confirmInfoLabel";
            this.confirmInfoLabel.Size = new System.Drawing.Size(234, 29);
            this.confirmInfoLabel.TabIndex = 0;
            this.confirmInfoLabel.Text = "Confirm Information?";
            // 
            // infoDetail
            // 
            this.infoDetail.AutoSize = true;
            this.infoDetail.Location = new System.Drawing.Point(37, 38);
            this.infoDetail.Name = "infoDetail";
            this.infoDetail.Size = new System.Drawing.Size(188, 20);
            this.infoDetail.TabIndex = 1;
            this.infoDetail.Text = "Information Detail Output";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.infoDetail);
            this.panel1.Location = new System.Drawing.Point(73, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 212);
            this.panel1.TabIndex = 2;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(544, 354);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(183, 60);
            this.confirmButton.TabIndex = 16;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // backToEmpDetail
            // 
            this.backToEmpDetail.Location = new System.Drawing.Point(73, 354);
            this.backToEmpDetail.Name = "backToEmpDetail";
            this.backToEmpDetail.Size = new System.Drawing.Size(225, 27);
            this.backToEmpDetail.TabIndex = 17;
            this.backToEmpDetail.Text = "Back to Employe Details";
            this.backToEmpDetail.UseVisualStyleBackColor = true;
            // 
            // backToUserCreate
            // 
            this.backToUserCreate.Location = new System.Drawing.Point(73, 387);
            this.backToUserCreate.Name = "backToUserCreate";
            this.backToUserCreate.Size = new System.Drawing.Size(225, 27);
            this.backToUserCreate.TabIndex = 18;
            this.backToUserCreate.Text = "Back to User Creation";
            this.backToUserCreate.UseVisualStyleBackColor = true;
            // 
            // confirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backToUserCreate);
            this.Controls.Add(this.backToEmpDetail);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.confirmInfoLabel);
            this.Name = "confirmForm";
            this.Text = "Confirm Information";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirmInfoLabel;
        private System.Windows.Forms.Label infoDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button backToEmpDetail;
        private System.Windows.Forms.Button backToUserCreate;
    }
}