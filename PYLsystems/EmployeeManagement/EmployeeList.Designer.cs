namespace PYLsystems.EmployeeManagement
{
    partial class EmployeeList
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.topPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.addEmpButton = new System.Windows.Forms.Button();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.edEmpButton = new System.Windows.Forms.Button();
            this.empListPanel = new System.Windows.Forms.Panel();
            this.infoOut = new System.Windows.Forms.Label();
            this.empDetails = new System.Windows.Forms.GroupBox();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.empListPanel.SuspendLayout();
            this.empDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leftPanel.Controls.Add(this.dataGridView1);
            this.leftPanel.Location = new System.Drawing.Point(31, 171);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(484, 675);
            this.leftPanel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(466, 661);
            this.dataGridView1.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.topPanel.Controls.Add(this.addEmpButton);
            this.topPanel.Controls.Add(this.backButton);
            this.topPanel.Location = new System.Drawing.Point(56, 45);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(948, 92);
            this.topPanel.TabIndex = 16;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.Location = new System.Drawing.Point(6, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(83, 75);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addEmpButton
            // 
            this.addEmpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addEmpButton.Location = new System.Drawing.Point(726, 14);
            this.addEmpButton.Name = "addEmpButton";
            this.addEmpButton.Size = new System.Drawing.Size(178, 64);
            this.addEmpButton.TabIndex = 16;
            this.addEmpButton.Text = "Add Employee";
            this.addEmpButton.UseVisualStyleBackColor = true;
            this.addEmpButton.Click += new System.EventHandler(this.addEmpButton_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rightPanel.Controls.Add(this.edEmpButton);
            this.rightPanel.Controls.Add(this.empDetails);
            this.rightPanel.Location = new System.Drawing.Point(537, 171);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(484, 675);
            this.rightPanel.TabIndex = 1;
            // 
            // edEmpButton
            // 
            this.edEmpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edEmpButton.Location = new System.Drawing.Point(245, 608);
            this.edEmpButton.Name = "edEmpButton";
            this.edEmpButton.Size = new System.Drawing.Size(178, 64);
            this.edEmpButton.TabIndex = 17;
            this.edEmpButton.Text = "Edit Employee";
            this.edEmpButton.UseVisualStyleBackColor = true;
            // 
            // empListPanel
            // 
            this.empListPanel.Controls.Add(this.rightPanel);
            this.empListPanel.Controls.Add(this.topPanel);
            this.empListPanel.Controls.Add(this.leftPanel);
            this.empListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empListPanel.Location = new System.Drawing.Point(0, 0);
            this.empListPanel.Name = "empListPanel";
            this.empListPanel.Size = new System.Drawing.Size(1044, 901);
            this.empListPanel.TabIndex = 17;
            // 
            // infoOut
            // 
            this.infoOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoOut.AutoSize = true;
            this.infoOut.Location = new System.Drawing.Point(162, 110);
            this.infoOut.Name = "infoOut";
            this.infoOut.Size = new System.Drawing.Size(143, 20);
            this.infoOut.TabIndex = 18;
            this.infoOut.Text = "Information Output";
            // 
            // empDetails
            // 
            this.empDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empDetails.Controls.Add(this.infoOut);
            this.empDetails.Location = new System.Drawing.Point(24, 27);
            this.empDetails.Name = "empDetails";
            this.empDetails.Size = new System.Drawing.Size(443, 538);
            this.empDetails.TabIndex = 19;
            this.empDetails.TabStop = false;
            this.empDetails.Text = "Employee Details";
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.empListPanel);
            this.Name = "EmployeeList";
            this.Size = new System.Drawing.Size(1044, 901);
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.empListPanel.ResumeLayout(false);
            this.empDetails.ResumeLayout(false);
            this.empDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button addEmpButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Button edEmpButton;
        private System.Windows.Forms.Panel empListPanel;
        private System.Windows.Forms.Label infoOut;
        private System.Windows.Forms.GroupBox empDetails;
    }
}
