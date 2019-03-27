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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(677, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // frameListGB
            // 
            this.frameListGB.Controls.Add(this.frameInvGrid);
            this.frameListGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameListGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameListGB.Location = new System.Drawing.Point(2, 52);
            this.frameListGB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frameListGB.Name = "frameListGB";
            this.frameListGB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frameListGB.Size = new System.Drawing.Size(673, 386);
            this.frameListGB.TabIndex = 0;
            this.frameListGB.TabStop = false;
            this.frameListGB.Text = "Frame List";
            // 
            // frameInvGrid
            // 
            this.frameInvGrid.AllowUserToAddRows = false;
            this.frameInvGrid.AllowUserToDeleteRows = false;
            this.frameInvGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.frameInvGrid.BackgroundColor = System.Drawing.Color.Honeydew;
            this.frameInvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frameInvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameInvGrid.Location = new System.Drawing.Point(2, 18);
            this.frameInvGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frameInvGrid.Name = "frameInvGrid";
            this.frameInvGrid.ReadOnly = true;
            this.frameInvGrid.RowHeadersVisible = false;
            this.frameInvGrid.RowTemplate.Height = 28;
            this.frameInvGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.frameInvGrid.Size = new System.Drawing.Size(669, 366);
            this.frameInvGrid.TabIndex = 0;
            // 
            // searchGB
            // 
            this.searchGB.Controls.Add(this.searchLabel);
            this.searchGB.Controls.Add(this.searchTextBox);
            this.searchGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchGB.Location = new System.Drawing.Point(2, 2);
            this.searchGB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchGB.Name = "searchGB";
            this.searchGB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchGB.Size = new System.Drawing.Size(673, 46);
            this.searchGB.TabIndex = 1;
            this.searchGB.TabStop = false;
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(404, 23);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(57, 17);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Search:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(465, 22);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(204, 20);
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
            this.buttonsGB.Location = new System.Drawing.Point(2, 442);
            this.buttonsGB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonsGB.Name = "buttonsGB";
            this.buttonsGB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonsGB.Size = new System.Drawing.Size(673, 56);
            this.buttonsGB.TabIndex = 2;
            this.buttonsGB.TabStop = false;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(9, 16);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(74, 17);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(87, 13);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(84, 23);
            this.quantityTextBox.TabIndex = 3;
            this.quantityTextBox.Text = "1";
            this.quantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(557, 17);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 31);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(447, 17);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 31);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addSalesAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(677, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addSalesAvailability";
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