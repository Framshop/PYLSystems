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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(935, 480);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.datePickerGB, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonsGB, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.22293F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.72399F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.84076F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(292, 476);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // datePickerGB
            // 
            this.datePickerGB.Controls.Add(this.endCheck);
            this.datePickerGB.Controls.Add(this.startCheck);
            this.datePickerGB.Controls.Add(this.endDatePicker);
            this.datePickerGB.Controls.Add(this.startDatePicker);
            this.datePickerGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePickerGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerGB.Location = new System.Drawing.Point(2, 2);
            this.datePickerGB.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerGB.Name = "datePickerGB";
            this.datePickerGB.Padding = new System.Windows.Forms.Padding(2);
            this.datePickerGB.Size = new System.Drawing.Size(288, 211);
            this.datePickerGB.TabIndex = 0;
            this.datePickerGB.TabStop = false;
            this.datePickerGB.Text = "Date Selection";
            // 
            // endCheck
            // 
            this.endCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endCheck.AutoSize = true;
            this.endCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endCheck.Location = new System.Drawing.Point(7, 115);
            this.endCheck.Margin = new System.Windows.Forms.Padding(2);
            this.endCheck.Name = "endCheck";
            this.endCheck.Size = new System.Drawing.Size(131, 33);
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
            this.startCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCheck.Location = new System.Drawing.Point(7, 39);
            this.startCheck.Margin = new System.Windows.Forms.Padding(2);
            this.startCheck.Name = "startCheck";
            this.startCheck.Size = new System.Drawing.Size(137, 33);
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
            this.endDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(7, 152);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(208, 35);
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
            this.startDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(7, 76);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(208, 35);
            this.startDatePicker.TabIndex = 4;
            this.startDatePicker.Value = new System.DateTime(2019, 1, 4, 0, 0, 0, 0);
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // buttonsGB
            // 
            this.buttonsGB.Controls.Add(this.closeBtn);
            this.buttonsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsGB.Location = new System.Drawing.Point(2, 358);
            this.buttonsGB.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsGB.Name = "buttonsGB";
            this.buttonsGB.Padding = new System.Windows.Forms.Padding(2);
            this.buttonsGB.Size = new System.Drawing.Size(288, 116);
            this.buttonsGB.TabIndex = 1;
            this.buttonsGB.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(78, 17);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(137, 60);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(298, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.95264F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.04736F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(635, 476);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // profitListGB
            // 
            this.profitListGB.Controls.Add(this.viewTotalProfitGrid);
            this.profitListGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profitListGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitListGB.Location = new System.Drawing.Point(2, 2);
            this.profitListGB.Margin = new System.Windows.Forms.Padding(2);
            this.profitListGB.Name = "profitListGB";
            this.profitListGB.Padding = new System.Windows.Forms.Padding(2);
            this.profitListGB.Size = new System.Drawing.Size(631, 305);
            this.profitListGB.TabIndex = 1;
            this.profitListGB.TabStop = false;
            this.profitListGB.Text = "List";
            // 
            // viewTotalProfitGrid
            // 
            this.viewTotalProfitGrid.AllowUserToAddRows = false;
            this.viewTotalProfitGrid.AllowUserToDeleteRows = false;
            this.viewTotalProfitGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewTotalProfitGrid.BackgroundColor = System.Drawing.Color.Honeydew;
            this.viewTotalProfitGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewTotalProfitGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewTotalProfitGrid.GridColor = System.Drawing.Color.White;
            this.viewTotalProfitGrid.Location = new System.Drawing.Point(2, 30);
            this.viewTotalProfitGrid.Margin = new System.Windows.Forms.Padding(2);
            this.viewTotalProfitGrid.Name = "viewTotalProfitGrid";
            this.viewTotalProfitGrid.ReadOnly = true;
            this.viewTotalProfitGrid.RowHeadersVisible = false;
            this.viewTotalProfitGrid.RowTemplate.Height = 28;
            this.viewTotalProfitGrid.Size = new System.Drawing.Size(627, 273);
            this.viewTotalProfitGrid.TabIndex = 0;
            // 
            // calcGB
            // 
            this.calcGB.Controls.Add(this.TotalLabel);
            this.calcGB.Controls.Add(this.totalTextBox);
            this.calcGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calcGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcGB.Location = new System.Drawing.Point(2, 311);
            this.calcGB.Margin = new System.Windows.Forms.Padding(2);
            this.calcGB.Name = "calcGB";
            this.calcGB.Padding = new System.Windows.Forms.Padding(2);
            this.calcGB.Size = new System.Drawing.Size(631, 163);
            this.calcGB.TabIndex = 2;
            this.calcGB.TabStop = false;
            this.calcGB.Text = "Summary";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(16, 81);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(74, 29);
            this.TotalLabel.TabIndex = 9;
            this.TotalLabel.Text = "Total:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(134, 75);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(417, 35);
            this.totalTextBox.TabIndex = 8;
            // 
            // viewTotalProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(935, 480);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "viewTotalProfit";
            this.Text = "Total Profit";
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