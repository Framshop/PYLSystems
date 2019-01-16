namespace PYLsystems
{
    partial class addSales
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnsGB = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.TotalGB = new System.Windows.Forms.GroupBox();
            this.totalPaidLabel = new System.Windows.Forms.Label();
            this.totalPaidTextBox = new System.Windows.Forms.TextBox();
            this.trueTotalLabel = new System.Windows.Forms.Label();
            this.trueTotalTextBox = new System.Windows.Forms.TextBox();
            this.discountLabel = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.rawTotalLabel = new System.Windows.Forms.Label();
            this.rawTotalTextBox = new System.Windows.Forms.TextBox();
            this.AddSalesGB = new System.Windows.Forms.GroupBox();
            this.addSalesGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.btnsGB.SuspendLayout();
            this.TotalGB.SuspendLayout();
            this.AddSalesGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addSalesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddSalesGB, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.22819F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.77181F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1055, 745);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.55767F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.44233F));
            this.tableLayoutPanel2.Controls.Add(this.btnsGB, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TotalGB, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 555);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1049, 187);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnsGB
            // 
            this.btnsGB.Controls.Add(this.cancelBtn);
            this.btnsGB.Controls.Add(this.confirmBtn);
            this.btnsGB.Location = new System.Drawing.Point(3, 3);
            this.btnsGB.Name = "btnsGB";
            this.btnsGB.Size = new System.Drawing.Size(366, 141);
            this.btnsGB.TabIndex = 0;
            this.btnsGB.TabStop = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(35, 36);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 37);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(196, 36);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(130, 37);
            this.confirmBtn.TabIndex = 1;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            // 
            // TotalGB
            // 
            this.TotalGB.Controls.Add(this.totalPaidLabel);
            this.TotalGB.Controls.Add(this.totalPaidTextBox);
            this.TotalGB.Controls.Add(this.trueTotalLabel);
            this.TotalGB.Controls.Add(this.trueTotalTextBox);
            this.TotalGB.Controls.Add(this.discountLabel);
            this.TotalGB.Controls.Add(this.discountTextBox);
            this.TotalGB.Controls.Add(this.rawTotalLabel);
            this.TotalGB.Controls.Add(this.rawTotalTextBox);
            this.TotalGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalGB.Location = new System.Drawing.Point(375, 3);
            this.TotalGB.Name = "TotalGB";
            this.TotalGB.Size = new System.Drawing.Size(671, 181);
            this.TotalGB.TabIndex = 1;
            this.TotalGB.TabStop = false;
            this.TotalGB.Text = "Total";
            // 
            // totalPaidLabel
            // 
            this.totalPaidLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPaidLabel.AutoSize = true;
            this.totalPaidLabel.Location = new System.Drawing.Point(375, 121);
            this.totalPaidLabel.Name = "totalPaidLabel";
            this.totalPaidLabel.Size = new System.Drawing.Size(83, 20);
            this.totalPaidLabel.TabIndex = 17;
            this.totalPaidLabel.Text = "Total Paid:";
            // 
            // totalPaidTextBox
            // 
            this.totalPaidTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPaidTextBox.Location = new System.Drawing.Point(477, 121);
            this.totalPaidTextBox.Name = "totalPaidTextBox";
            this.totalPaidTextBox.Size = new System.Drawing.Size(170, 26);
            this.totalPaidTextBox.TabIndex = 16;
            // 
            // trueTotalLabel
            // 
            this.trueTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trueTotalLabel.AutoSize = true;
            this.trueTotalLabel.Location = new System.Drawing.Point(325, 89);
            this.trueTotalLabel.Name = "trueTotalLabel";
            this.trueTotalLabel.Size = new System.Drawing.Size(133, 20);
            this.trueTotalLabel.TabIndex = 15;
            this.trueTotalLabel.Text = "Discounted Total:";
            // 
            // trueTotalTextBox
            // 
            this.trueTotalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trueTotalTextBox.Enabled = false;
            this.trueTotalTextBox.Location = new System.Drawing.Point(477, 89);
            this.trueTotalTextBox.Name = "trueTotalTextBox";
            this.trueTotalTextBox.Size = new System.Drawing.Size(170, 26);
            this.trueTotalTextBox.TabIndex = 14;
            // 
            // discountLabel
            // 
            this.discountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(382, 57);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(76, 20);
            this.discountLabel.TabIndex = 13;
            this.discountLabel.Text = "Discount:";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountTextBox.Location = new System.Drawing.Point(477, 57);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(170, 26);
            this.discountTextBox.TabIndex = 12;
            // 
            // rawTotalLabel
            // 
            this.rawTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rawTotalLabel.AutoSize = true;
            this.rawTotalLabel.Location = new System.Drawing.Point(410, 25);
            this.rawTotalLabel.Name = "rawTotalLabel";
            this.rawTotalLabel.Size = new System.Drawing.Size(48, 20);
            this.rawTotalLabel.TabIndex = 9;
            this.rawTotalLabel.Text = "Total:";
            // 
            // rawTotalTextBox
            // 
            this.rawTotalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rawTotalTextBox.Enabled = false;
            this.rawTotalTextBox.Location = new System.Drawing.Point(477, 25);
            this.rawTotalTextBox.Name = "rawTotalTextBox";
            this.rawTotalTextBox.Size = new System.Drawing.Size(170, 26);
            this.rawTotalTextBox.TabIndex = 8;
            // 
            // AddSalesGB
            // 
            this.AddSalesGB.Controls.Add(this.addSalesGrid);
            this.AddSalesGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddSalesGB.Location = new System.Drawing.Point(3, 3);
            this.AddSalesGB.Name = "AddSalesGB";
            this.AddSalesGB.Size = new System.Drawing.Size(1049, 546);
            this.AddSalesGB.TabIndex = 1;
            this.AddSalesGB.TabStop = false;
            this.AddSalesGB.Text = "New Sales Order";
            // 
            // addSalesGrid
            // 
            this.addSalesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addSalesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addSalesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSalesGrid.Location = new System.Drawing.Point(3, 22);
            this.addSalesGrid.Name = "addSalesGrid";
            this.addSalesGrid.ReadOnly = true;
            this.addSalesGrid.RowHeadersVisible = false;
            this.addSalesGrid.RowTemplate.Height = 28;
            this.addSalesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addSalesGrid.Size = new System.Drawing.Size(1043, 521);
            this.addSalesGrid.TabIndex = 0;
            this.addSalesGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addSalesGrid_CellDoubleClick);
            // 
            // addSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 745);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "addSales";
            this.Text = "AddSales";
            this.Load += new System.EventHandler(this.addSales_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.btnsGB.ResumeLayout(false);
            this.TotalGB.ResumeLayout(false);
            this.TotalGB.PerformLayout();
            this.AddSalesGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addSalesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox btnsGB;
        private System.Windows.Forms.GroupBox AddSalesGB;
        private System.Windows.Forms.DataGridView addSalesGrid;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.GroupBox TotalGB;
        private System.Windows.Forms.Label rawTotalLabel;
        private System.Windows.Forms.TextBox rawTotalTextBox;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Label trueTotalLabel;
        private System.Windows.Forms.TextBox trueTotalTextBox;
        private System.Windows.Forms.Label totalPaidLabel;
        private System.Windows.Forms.TextBox totalPaidTextBox;
    }
}

