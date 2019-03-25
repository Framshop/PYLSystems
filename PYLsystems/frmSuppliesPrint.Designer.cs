namespace PYLsystems
{
    partial class frmSuppliesPrint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbSelectSupplier = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.gbGenerateDates = new System.Windows.Forms.GroupBox();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.GBBrowser = new System.Windows.Forms.GroupBox();
            this.wBSuppliesStockInReport = new System.Windows.Forms.WebBrowser();
            this.gbPrintControl = new System.Windows.Forms.GroupBox();
            this.datagridSuppliersList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbSelectSupplier.SuspendLayout();
            this.gbGenerateDates.SuspendLayout();
            this.GBBrowser.SuspendLayout();
            this.gbPrintControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSuppliersList)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1256, 938);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.gbSelectSupplier, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gbGenerateDates, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.gbPrintControl, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1250, 260);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gbSelectSupplier
            // 
            this.gbSelectSupplier.Controls.Add(this.datagridSuppliersList);
            this.gbSelectSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSelectSupplier.Location = new System.Drawing.Point(3, 3);
            this.gbSelectSupplier.Name = "gbSelectSupplier";
            this.gbSelectSupplier.Size = new System.Drawing.Size(410, 254);
            this.gbSelectSupplier.TabIndex = 0;
            this.gbSelectSupplier.TabStop = false;
            this.gbSelectSupplier.Text = "Select Supplier";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGenerate.Location = new System.Drawing.Point(104, 166);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(234, 54);
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
            this.endLabel.Location = new System.Drawing.Point(15, 92);
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
            this.startLabel.Location = new System.Drawing.Point(15, 57);
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
            this.endDatePicker.Location = new System.Drawing.Point(104, 87);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(241, 26);
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
            this.startDatePicker.Location = new System.Drawing.Point(104, 52);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(241, 26);
            this.startDatePicker.TabIndex = 19;
            this.startDatePicker.Value = new System.DateTime(2019, 1, 4, 0, 0, 0, 0);
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // gbGenerateDates
            // 
            this.gbGenerateDates.Controls.Add(this.btnGenerate);
            this.gbGenerateDates.Controls.Add(this.startDatePicker);
            this.gbGenerateDates.Controls.Add(this.endLabel);
            this.gbGenerateDates.Controls.Add(this.endDatePicker);
            this.gbGenerateDates.Controls.Add(this.startLabel);
            this.gbGenerateDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGenerateDates.Location = new System.Drawing.Point(419, 3);
            this.gbGenerateDates.Name = "gbGenerateDates";
            this.gbGenerateDates.Size = new System.Drawing.Size(410, 254);
            this.gbGenerateDates.TabIndex = 1;
            this.gbGenerateDates.TabStop = false;
            this.gbGenerateDates.Text = "Select Dates";
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReport.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPrintReport.Location = new System.Drawing.Point(81, 87);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(234, 54);
            this.btnPrintReport.TabIndex = 31;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = false;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // GBBrowser
            // 
            this.GBBrowser.Controls.Add(this.wBSuppliesStockInReport);
            this.GBBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBBrowser.Location = new System.Drawing.Point(3, 269);
            this.GBBrowser.Name = "GBBrowser";
            this.GBBrowser.Size = new System.Drawing.Size(1250, 666);
            this.GBBrowser.TabIndex = 1;
            this.GBBrowser.TabStop = false;
            this.GBBrowser.Text = "Preview";
            // 
            // wBSuppliesStockInReport
            // 
            this.wBSuppliesStockInReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wBSuppliesStockInReport.Location = new System.Drawing.Point(3, 22);
            this.wBSuppliesStockInReport.MinimumSize = new System.Drawing.Size(20, 20);
            this.wBSuppliesStockInReport.Name = "wBSuppliesStockInReport";
            this.wBSuppliesStockInReport.Size = new System.Drawing.Size(1244, 641);
            this.wBSuppliesStockInReport.TabIndex = 0;
            // 
            // gbPrintControl
            // 
            this.gbPrintControl.Controls.Add(this.btnPrintReport);
            this.gbPrintControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPrintControl.Location = new System.Drawing.Point(835, 3);
            this.gbPrintControl.Name = "gbPrintControl";
            this.gbPrintControl.Size = new System.Drawing.Size(412, 254);
            this.gbPrintControl.TabIndex = 2;
            this.gbPrintControl.TabStop = false;
            // 
            // datagridSuppliersList
            // 
            this.datagridSuppliersList.AllowUserToAddRows = false;
            this.datagridSuppliersList.AllowUserToDeleteRows = false;
            this.datagridSuppliersList.AllowUserToResizeRows = false;
            this.datagridSuppliersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridSuppliersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridSuppliersList.DefaultCellStyle = dataGridViewCellStyle1;
            this.datagridSuppliersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridSuppliersList.Location = new System.Drawing.Point(3, 22);
            this.datagridSuppliersList.Name = "datagridSuppliersList";
            this.datagridSuppliersList.ReadOnly = true;
            this.datagridSuppliersList.RowHeadersVisible = false;
            this.datagridSuppliersList.RowTemplate.Height = 28;
            this.datagridSuppliersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridSuppliersList.Size = new System.Drawing.Size(404, 229);
            this.datagridSuppliersList.TabIndex = 4;
            // 
            // frmSuppliesPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1256, 938);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSuppliesPrint";
            this.Text = "Stock In Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSuppliesPrint_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbSelectSupplier.ResumeLayout(false);
            this.gbGenerateDates.ResumeLayout(false);
            this.gbGenerateDates.PerformLayout();
            this.GBBrowser.ResumeLayout(false);
            this.gbPrintControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridSuppliersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gbSelectSupplier;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.GroupBox gbGenerateDates;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.GroupBox GBBrowser;
        private System.Windows.Forms.WebBrowser wBSuppliesStockInReport;
        private System.Windows.Forms.GroupBox gbPrintControl;
        private System.Windows.Forms.DataGridView datagridSuppliersList;
    }
}