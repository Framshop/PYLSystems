namespace PYLsystems
{
    partial class viewTotalProfit
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
            this.datePickerGB = new System.Windows.Forms.GroupBox();
            this.endCheck = new System.Windows.Forms.CheckBox();
            this.startCheck = new System.Windows.Forms.CheckBox();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonsGB = new System.Windows.Forms.GroupBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.profitListGB = new System.Windows.Forms.GroupBox();
            this.viewTotalProfitGrid = new System.Windows.Forms.DataGridView();
            this.calcGB = new System.Windows.Forms.GroupBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.datePickerGB.SuspendLayout();
            this.buttonsGB.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.profitListGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewTotalProfitGrid)).BeginInit();
            this.calcGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.75356F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.24644F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1055, 745);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.datePickerGB, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonsGB, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(329, 739);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // datePickerGB
            // 
            this.datePickerGB.Controls.Add(this.endCheck);
            this.datePickerGB.Controls.Add(this.startCheck);
            this.datePickerGB.Controls.Add(this.endDatePicker);
            this.datePickerGB.Controls.Add(this.startDatePicker);
            this.datePickerGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePickerGB.Location = new System.Drawing.Point(3, 3);
            this.datePickerGB.Name = "datePickerGB";
            this.datePickerGB.Size = new System.Drawing.Size(323, 141);
            this.datePickerGB.TabIndex = 0;
            this.datePickerGB.TabStop = false;
            this.datePickerGB.Text = "Select Dates";
            // 
            // endCheck
            // 
            this.endCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endCheck.AutoSize = true;
            this.endCheck.Location = new System.Drawing.Point(5, 88);
            this.endCheck.Name = "endCheck";
            this.endCheck.Size = new System.Drawing.Size(103, 24);
            this.endCheck.TabIndex = 7;
            this.endCheck.Text = "End Date";
            this.endCheck.UseVisualStyleBackColor = true;
            this.endCheck.CheckedChanged += new System.EventHandler(this.endCheck_CheckedChanged);
            // 
            // startCheck
            // 
            this.startCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startCheck.AutoSize = true;
            this.startCheck.Checked = true;
            this.startCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startCheck.Location = new System.Drawing.Point(5, 48);
            this.startCheck.Name = "startCheck";
            this.startCheck.Size = new System.Drawing.Size(109, 24);
            this.startCheck.TabIndex = 6;
            this.startCheck.Text = "Start Date";
            this.startCheck.UseVisualStyleBackColor = true;
            this.startCheck.CheckedChanged += new System.EventHandler(this.startCheck_CheckedChanged);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endDatePicker.CustomFormat = "yyyy/MM/dd";
            this.endDatePicker.Enabled = false;
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(117, 84);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 26);
            this.endDatePicker.TabIndex = 5;
            this.endDatePicker.Value = new System.DateTime(2019, 1, 5, 0, 0, 0, 0);
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDatePicker.CustomFormat = "yyyy/MM/dd";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(117, 49);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 26);
            this.startDatePicker.TabIndex = 4;
            this.startDatePicker.Value = new System.DateTime(2019, 1, 4, 0, 0, 0, 0);
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // buttonsGB
            // 
            this.buttonsGB.Controls.Add(this.closeBtn);
            this.buttonsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsGB.Location = new System.Drawing.Point(3, 593);
            this.buttonsGB.Name = "buttonsGB";
            this.buttonsGB.Size = new System.Drawing.Size(323, 143);
            this.buttonsGB.TabIndex = 1;
            this.buttonsGB.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.closeBtn.Location = new System.Drawing.Point(94, 68);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(130, 37);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.profitListGB, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.calcGB, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(338, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.95264F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.04736F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(714, 739);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // profitListGB
            // 
            this.profitListGB.Controls.Add(this.viewTotalProfitGrid);
            this.profitListGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profitListGB.Location = new System.Drawing.Point(3, 3);
            this.profitListGB.Name = "profitListGB";
            this.profitListGB.Size = new System.Drawing.Size(708, 473);
            this.profitListGB.TabIndex = 1;
            this.profitListGB.TabStop = false;
            this.profitListGB.Text = "List";
            // 
            // viewTotalProfitGrid
            // 
            this.viewTotalProfitGrid.AllowUserToAddRows = false;
            this.viewTotalProfitGrid.AllowUserToDeleteRows = false;
            this.viewTotalProfitGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewTotalProfitGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewTotalProfitGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewTotalProfitGrid.Location = new System.Drawing.Point(3, 22);
            this.viewTotalProfitGrid.Name = "viewTotalProfitGrid";
            this.viewTotalProfitGrid.ReadOnly = true;
            this.viewTotalProfitGrid.RowHeadersVisible = false;
            this.viewTotalProfitGrid.RowTemplate.Height = 28;
            this.viewTotalProfitGrid.Size = new System.Drawing.Size(702, 448);
            this.viewTotalProfitGrid.TabIndex = 0;
            // 
            // calcGB
            // 
            this.calcGB.Controls.Add(this.TotalLabel);
            this.calcGB.Controls.Add(this.totalTextBox);
            this.calcGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calcGB.Location = new System.Drawing.Point(3, 482);
            this.calcGB.Name = "calcGB";
            this.calcGB.Size = new System.Drawing.Size(708, 254);
            this.calcGB.TabIndex = 2;
            this.calcGB.TabStop = false;
            this.calcGB.Text = "Summary";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(35, 73);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(48, 20);
            this.TotalLabel.TabIndex = 9;
            this.TotalLabel.Text = "Total:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(102, 73);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(170, 26);
            this.totalTextBox.TabIndex = 8;
            // 
            // viewTotalProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1055, 745);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "viewTotalProfit";
            this.Text = "viewTotalProfit";
            this.Load += new System.EventHandler(this.viewTotalProfit_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.datePickerGB.ResumeLayout(false);
            this.datePickerGB.PerformLayout();
            this.buttonsGB.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.profitListGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewTotalProfitGrid)).EndInit();
            this.calcGB.ResumeLayout(false);
            this.calcGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox datePickerGB;
        private System.Windows.Forms.GroupBox buttonsGB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox profitListGB;
        private System.Windows.Forms.GroupBox calcGB;
        private System.Windows.Forms.CheckBox endCheck;
        private System.Windows.Forms.CheckBox startCheck;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DataGridView viewTotalProfitGrid;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button closeBtn;
    }
}