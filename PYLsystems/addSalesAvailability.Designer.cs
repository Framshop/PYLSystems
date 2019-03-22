namespace PYLsystems
{
    partial class addSalesAvailability
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.frameListGB = new System.Windows.Forms.GroupBox();
            this.frameInvGrid = new System.Windows.Forms.DataGridView();
            this.searchGB = new System.Windows.Forms.GroupBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.buttonsGB = new System.Windows.Forms.GroupBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.frameListGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameInvGrid)).BeginInit();
            this.searchGB.SuspendLayout();
            this.buttonsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.frameListGB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.searchGB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonsGB, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(932, 703);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // frameListGB
            // 
            this.frameListGB.Controls.Add(this.frameInvGrid);
            this.frameListGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameListGB.Location = new System.Drawing.Point(3, 73);
            this.frameListGB.Name = "frameListGB";
            this.frameListGB.Size = new System.Drawing.Size(926, 542);
            this.frameListGB.TabIndex = 0;
            this.frameListGB.TabStop = false;
            this.frameListGB.Text = "Frame List";
            // 
            // frameInvGrid
            // 
            this.frameInvGrid.AllowUserToAddRows = false;
            this.frameInvGrid.AllowUserToDeleteRows = false;
            this.frameInvGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.frameInvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frameInvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameInvGrid.Location = new System.Drawing.Point(3, 22);
            this.frameInvGrid.Name = "frameInvGrid";
            this.frameInvGrid.ReadOnly = true;
            this.frameInvGrid.RowHeadersVisible = false;
            this.frameInvGrid.RowTemplate.Height = 28;
            this.frameInvGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.frameInvGrid.Size = new System.Drawing.Size(920, 517);
            this.frameInvGrid.TabIndex = 0;
            // 
            // searchGB
            // 
            this.searchGB.Controls.Add(this.searchLabel);
            this.searchGB.Controls.Add(this.searchTextBox);
            this.searchGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchGB.Location = new System.Drawing.Point(3, 3);
            this.searchGB.Name = "searchGB";
            this.searchGB.Size = new System.Drawing.Size(926, 64);
            this.searchGB.TabIndex = 1;
            this.searchGB.TabStop = false;
            this.searchGB.Text = "Search";
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(270, 28);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(64, 20);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Search:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(340, 25);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(220, 26);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // buttonsGB
            // 
            this.buttonsGB.Controls.Add(this.quantityLabel);
            this.buttonsGB.Controls.Add(this.quantityTextBox);
            this.buttonsGB.Controls.Add(this.addBtn);
            this.buttonsGB.Controls.Add(this.cancelBtn);
            this.buttonsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsGB.Location = new System.Drawing.Point(3, 621);
            this.buttonsGB.Name = "buttonsGB";
            this.buttonsGB.Size = new System.Drawing.Size(926, 79);
            this.buttonsGB.TabIndex = 2;
            this.buttonsGB.TabStop = false;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(125, 33);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(72, 20);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(203, 30);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 26);
            this.quantityTextBox.TabIndex = 3;
            this.quantityTextBox.Text = "1";
            this.quantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Location = new System.Drawing.Point(775, 25);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(130, 37);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(627, 25);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 37);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addSalesAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 703);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "addSalesAvailability";
            this.Text = "Frame Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.addSalesAvailability_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.frameListGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frameInvGrid)).EndInit();
            this.searchGB.ResumeLayout(false);
            this.searchGB.PerformLayout();
            this.buttonsGB.ResumeLayout(false);
            this.buttonsGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox frameListGB;
        private System.Windows.Forms.DataGridView frameInvGrid;
        private System.Windows.Forms.GroupBox searchGB;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.GroupBox buttonsGB;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
    }
}