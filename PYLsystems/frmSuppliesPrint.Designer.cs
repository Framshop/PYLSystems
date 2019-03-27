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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuppliesPrint));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbSelectSupplier = new System.Windows.Forms.GroupBox();
            this.datagridSuppliersList = new System.Windows.Forms.DataGridView();
            this.gbGenerateDates = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.gbPrintControl = new System.Windows.Forms.GroupBox();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.GBBrowser = new System.Windows.Forms.GroupBox();
            this.wBSuppliesStockInReport = new System.Windows.Forms.WebBrowser();
            this.imgGenerate = new System.Windows.Forms.ImageList(this.components);
            this.imgPrint = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbSelectSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSuppliersList)).BeginInit();
            this.gbGenerateDates.SuspendLayout();
            this.gbPrintControl.SuspendLayout();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1076, 585);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1072, 282);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gbSelectSupplier
            // 
            this.gbSelectSupplier.Controls.Add(this.datagridSuppliersList);
            this.gbSelectSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSelectSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSelectSupplier.Location = new System.Drawing.Point(2, 2);
            this.gbSelectSupplier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSelectSupplier.Name = "gbSelectSupplier";
            this.gbSelectSupplier.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSelectSupplier.Size = new System.Drawing.Size(353, 278);
            this.gbSelectSupplier.TabIndex = 0;
            this.gbSelectSupplier.TabStop = false;
            this.gbSelectSupplier.Text = "Select Supplier";
            // 
            // datagridSuppliersList
            // 
            this.datagridSuppliersList.AllowUserToAddRows = false;
            this.datagridSuppliersList.AllowUserToDeleteRows = false;
            this.datagridSuppliersList.AllowUserToResizeRows = false;
            this.datagridSuppliersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridSuppliersList.BackgroundColor = System.Drawing.Color.White;
            this.datagridSuppliersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSuppliersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridSuppliersList.GridColor = System.Drawing.Color.White;
            this.datagridSuppliersList.Location = new System.Drawing.Point(2, 30);
            this.datagridSuppliersList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datagridSuppliersList.Name = "datagridSuppliersList";
            this.datagridSuppliersList.ReadOnly = true;
            this.datagridSuppliersList.RowHeadersVisible = false;
            this.datagridSuppliersList.RowTemplate.Height = 28;
            this.datagridSuppliersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridSuppliersList.Size = new System.Drawing.Size(349, 246);
            this.datagridSuppliersList.TabIndex = 4;
            // 
            // gbGenerateDates
            // 
            this.gbGenerateDates.Controls.Add(this.btnGenerate);
            this.gbGenerateDates.Controls.Add(this.startDatePicker);
            this.gbGenerateDates.Controls.Add(this.endLabel);
            this.gbGenerateDates.Controls.Add(this.endDatePicker);
            this.gbGenerateDates.Controls.Add(this.startLabel);
            this.gbGenerateDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGenerateDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenerateDates.Location = new System.Drawing.Point(359, 2);
            this.gbGenerateDates.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbGenerateDates.Name = "gbGenerateDates";
            this.gbGenerateDates.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbGenerateDates.Size = new System.Drawing.Size(353, 278);
            this.gbGenerateDates.TabIndex = 1;
            this.gbGenerateDates.TabStop = false;
            this.gbGenerateDates.Text = "Date Selection";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerate.Location = new System.Drawing.Point(17, 225);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(236, 35);
            this.btnGenerate.TabIndex = 30;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDatePicker.CustomFormat = "yyyy/MM/dd";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(17, 78);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(242, 35);
            this.startDatePicker.TabIndex = 19;
            this.startDatePicker.Value = new System.DateTime(2019, 1, 4, 0, 0, 0, 0);
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // endLabel
            // 
            this.endLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(12, 115);
            this.endLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(118, 29);
            this.endLabel.TabIndex = 22;
            this.endLabel.Text = "End Date:";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endDatePicker.CustomFormat = "yyyy/MM/dd";
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(17, 146);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(242, 35);
            this.endDatePicker.TabIndex = 20;
            this.endDatePicker.Value = new System.DateTime(2019, 1, 5, 0, 0, 0, 0);
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // startLabel
            // 
            this.startLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(12, 47);
            this.startLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(124, 29);
            this.startLabel.TabIndex = 21;
            this.startLabel.Text = "Start Date:";
            // 
            // gbPrintControl
            // 
            this.gbPrintControl.Controls.Add(this.btnPrintReport);
            this.gbPrintControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPrintControl.Location = new System.Drawing.Point(716, 2);
            this.gbPrintControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPrintControl.Name = "gbPrintControl";
            this.gbPrintControl.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPrintControl.Size = new System.Drawing.Size(354, 278);
            this.gbPrintControl.TabIndex = 2;
            this.gbPrintControl.TabStop = false;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReport.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintReport.Location = new System.Drawing.Point(73, 82);
            this.btnPrintReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(225, 103);
            this.btnPrintReport.TabIndex = 31;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = false;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // GBBrowser
            // 
            this.GBBrowser.Controls.Add(this.wBSuppliesStockInReport);
            this.GBBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBBrowser.Location = new System.Drawing.Point(2, 288);
            this.GBBrowser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBBrowser.Name = "GBBrowser";
            this.GBBrowser.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBBrowser.Size = new System.Drawing.Size(1072, 295);
            this.GBBrowser.TabIndex = 1;
            this.GBBrowser.TabStop = false;
            this.GBBrowser.Text = "Preview";
            // 
            // wBSuppliesStockInReport
            // 
            this.wBSuppliesStockInReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wBSuppliesStockInReport.Location = new System.Drawing.Point(2, 30);
            this.wBSuppliesStockInReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wBSuppliesStockInReport.MinimumSize = new System.Drawing.Size(13, 13);
            this.wBSuppliesStockInReport.Name = "wBSuppliesStockInReport";
            this.wBSuppliesStockInReport.Size = new System.Drawing.Size(1068, 263);
            this.wBSuppliesStockInReport.TabIndex = 0;
            // 
            // imgGenerate
            // 
            this.imgGenerate.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgGenerate.ImageStream")));
            this.imgGenerate.TransparentColor = System.Drawing.Color.Transparent;
            this.imgGenerate.Images.SetKeyName(0, "iconfinder_Generate-tables_85519.png");
            // 
            // imgPrint
            // 
            this.imgPrint.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgPrint.ImageStream")));
            this.imgPrint.TransparentColor = System.Drawing.Color.Transparent;
            this.imgPrint.Images.SetKeyName(0, "iconfinder_print_326675.png");
            // 
            // frmSuppliesPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1076, 585);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSuppliesPrint";
            this.Text = "Stock In Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSuppliesPrint_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbSelectSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridSuppliersList)).EndInit();
            this.gbGenerateDates.ResumeLayout(false);
            this.gbGenerateDates.PerformLayout();
            this.gbPrintControl.ResumeLayout(false);
            this.GBBrowser.ResumeLayout(false);
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
        private System.Windows.Forms.ImageList imgGenerate;
        private System.Windows.Forms.ImageList imgPrint;
    }
}