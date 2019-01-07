namespace PYLsystems
{
    partial class cancelSalesConfirm
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
            this.cancelTextLabel = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelTextLabel
            // 
            this.cancelTextLabel.AutoSize = true;
            this.cancelTextLabel.Location = new System.Drawing.Point(63, 56);
            this.cancelTextLabel.Name = "cancelTextLabel";
            this.cancelTextLabel.Size = new System.Drawing.Size(330, 40);
            this.cancelTextLabel.TabIndex = 0;
            this.cancelTextLabel.Text = "Cancelled Sales Order cannot be undone.\r\nAre you sure you want to cancel Sales Or" +
    "der?";
            this.cancelTextLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(51, 161);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(130, 37);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(263, 161);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(130, 37);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // cancelSalesConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 228);
            this.ControlBox = false;
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.cancelTextLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "cancelSalesConfirm";
            this.Text = "Cancel Sales Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cancelTextLabel;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button backBtn;
    }
}