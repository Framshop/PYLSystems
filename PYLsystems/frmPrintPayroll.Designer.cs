namespace PYLsystems
{
    partial class frmPrintPayroll
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
            this.gbGenerateDates = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.gbPrintControls = new System.Windows.Forms.GroupBox();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.GBBrowser = new System.Windows.Forms.GroupBox();
            this.wBPayrollReport = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbGenerateDates.SuspendLayout();
            this.gbPrintControls.SuspendLayout();
            this.GBBrowser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GBBrowser, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.45445F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.54555F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1132, 977);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gbGenerateDates, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gbPrintControls, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1126, 271);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gbGenerateDates
            // 
            this.gbGenerateDates.Controls.Add(this.btnGenerate);
            this.gbGenerateDates.Controls.Add(this.endLabel);
            this.gbGenerateDates.Controls.Add(this.startLabel);
            this.gbGenerateDates.Controls.Add(this.endDatePicker);
            this.gbGenerateDates.Controls.Add(this.startDatePicker);
            this.gbGenerateDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGenerateDates.Location = new System.Drawing.Point(3, 3);
            this.gbGenerateDates.Name = "gbGenerateDates";
            this.gbGenerateDates.Size = new System.Drawing.Size(557, 265);
            this.gbGenerateDates.TabIndex = 0;
            this.gbGenerateDates.TabStop = false;
            this.gbGenerateDates.Text = "Select Dates";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGenerate.Location = new System.Drawing.Point(217, 171);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(182, 54);
            this.btnGenerate.TabIndex = 30;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // endLabel
            // 
            this.endLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(47, 99);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(81, 20);
            this.endLabel.TabIndex = 22;
            this.endLabel.Text = "End Date:";
            // 
            // startLabel
            // 
            this.startLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(47, 64);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(87, 20);
            this.startLabel.TabIndex = 21;
            this.startLabel.Text = "Start Date:";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endDatePicker.CustomFormat = "yyyy/MM/dd";
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(136, 94);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(388, 26);
            this.endDatePicker.TabIndex = 20;
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
            this.startDatePicker.Location = new System.Drawing.Point(136, 59);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(388, 26);
            this.startDatePicker.TabIndex = 19;
            this.startDatePicker.Value = new System.DateTime(2019, 1, 4, 0, 0, 0, 0);
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // gbPrintControls
            // 
            this.gbPrintControls.Controls.Add(this.btnPrintReport);
            this.gbPrintControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPrintControls.Location = new System.Drawing.Point(566, 3);
            this.gbPrintControls.Name = "gbPrintControls";
            this.gbPrintControls.Size = new System.Drawing.Size(557, 265);
            this.gbPrintControls.TabIndex = 1;
            this.gbPrintControls.TabStop = false;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReport.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPrintReport.Location = new System.Drawing.Point(187, 105);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(182, 54);
            this.btnPrintReport.TabIndex = 31;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = false;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // GBBrowser
            // 
            this.GBBrowser.Controls.Add(this.wBPayrollReport);
            this.GBBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBBrowser.Location = new System.Drawing.Point(3, 280);
            this.GBBrowser.Name = "GBBrowser";
            this.GBBrowser.Size = new System.Drawing.Size(1126, 694);
            this.GBBrowser.TabIndex = 1;
            this.GBBrowser.TabStop = false;
            this.GBBrowser.Text = "Preview";
            // 
            // wBPayrollReport
            // 
            this.wBPayrollReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wBPayrollReport.Location = new System.Drawing.Point(3, 22);
            this.wBPayrollReport.MinimumSize = new System.Drawing.Size(20, 20);
            this.wBPayrollReport.Name = "wBPayrollReport";
            this.wBPayrollReport.Size = new System.Drawing.Size(1120, 669);
            this.wBPayrollReport.TabIndex = 0;
            // 
            // frmPrintPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1132, 977);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmPrintPayroll";
            this.Text = "frmPrintPayroll";
            this.Load += new System.EventHandler(this.frmPrintPayroll_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbGenerateDates.ResumeLayout(false);
            this.gbGenerateDates.PerformLayout();
            this.gbPrintControls.ResumeLayout(false);
            this.GBBrowser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gbGenerateDates;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.GroupBox gbPrintControls;
        private System.Windows.Forms.GroupBox GBBrowser;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.WebBrowser wBPayrollReport;
        private System.Windows.Forms.Button btnPrintReport;
    }
}