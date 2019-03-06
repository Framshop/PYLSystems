namespace PYLsystems
{
    partial class frmPayroll
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
            this.GBPayrollCalculate = new System.Windows.Forms.GroupBox();
            this.datagridPayrollCalc = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GBButtons = new System.Windows.Forms.GroupBox();
            this.btnAddPayroll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.GBExtrabox = new System.Windows.Forms.GroupBox();
            this.GBSetPayrollDate = new System.Windows.Forms.GroupBox();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.GBPayrollCalculate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPayrollCalc)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.GBButtons.SuspendLayout();
            this.GBSetPayrollDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.43475F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.56525F));
            this.tableLayoutPanel1.Controls.Add(this.GBPayrollCalculate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1341, 873);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GBPayrollCalculate
            // 
            this.GBPayrollCalculate.Controls.Add(this.datagridPayrollCalc);
            this.GBPayrollCalculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBPayrollCalculate.Location = new System.Drawing.Point(504, 3);
            this.GBPayrollCalculate.Name = "GBPayrollCalculate";
            this.GBPayrollCalculate.Size = new System.Drawing.Size(834, 867);
            this.GBPayrollCalculate.TabIndex = 1;
            this.GBPayrollCalculate.TabStop = false;
            this.GBPayrollCalculate.Text = "Payroll";
            // 
            // datagridPayrollCalc
            // 
            this.datagridPayrollCalc.AllowUserToAddRows = false;
            this.datagridPayrollCalc.AllowUserToDeleteRows = false;
            this.datagridPayrollCalc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridPayrollCalc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPayrollCalc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridPayrollCalc.Location = new System.Drawing.Point(3, 22);
            this.datagridPayrollCalc.Name = "datagridPayrollCalc";
            this.datagridPayrollCalc.ReadOnly = true;
            this.datagridPayrollCalc.RowHeadersVisible = false;
            this.datagridPayrollCalc.RowTemplate.Height = 28;
            this.datagridPayrollCalc.Size = new System.Drawing.Size(828, 842);
            this.datagridPayrollCalc.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.GBButtons, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.GBExtrabox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.GBSetPayrollDate, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(495, 867);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // GBButtons
            // 
            this.GBButtons.Controls.Add(this.btnAddPayroll);
            this.GBButtons.Controls.Add(this.btnClose);
            this.GBButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBButtons.Location = new System.Drawing.Point(3, 581);
            this.GBButtons.Name = "GBButtons";
            this.GBButtons.Size = new System.Drawing.Size(489, 283);
            this.GBButtons.TabIndex = 2;
            this.GBButtons.TabStop = false;
            // 
            // btnAddPayroll
            // 
            this.btnAddPayroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPayroll.Location = new System.Drawing.Point(167, 138);
            this.btnAddPayroll.Name = "btnAddPayroll";
            this.btnAddPayroll.Size = new System.Drawing.Size(130, 37);
            this.btnAddPayroll.TabIndex = 5;
            this.btnAddPayroll.Text = "Add Payroll";
            this.btnAddPayroll.UseVisualStyleBackColor = true;
            this.btnAddPayroll.Click += new System.EventHandler(this.btnAddPayroll_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(167, 210);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GBExtrabox
            // 
            this.GBExtrabox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBExtrabox.Location = new System.Drawing.Point(3, 292);
            this.GBExtrabox.Name = "GBExtrabox";
            this.GBExtrabox.Size = new System.Drawing.Size(489, 283);
            this.GBExtrabox.TabIndex = 1;
            this.GBExtrabox.TabStop = false;
            // 
            // GBSetPayrollDate
            // 
            this.GBSetPayrollDate.Controls.Add(this.endLabel);
            this.GBSetPayrollDate.Controls.Add(this.startLabel);
            this.GBSetPayrollDate.Controls.Add(this.endDatePicker);
            this.GBSetPayrollDate.Controls.Add(this.startDatePicker);
            this.GBSetPayrollDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBSetPayrollDate.Location = new System.Drawing.Point(3, 3);
            this.GBSetPayrollDate.Name = "GBSetPayrollDate";
            this.GBSetPayrollDate.Size = new System.Drawing.Size(489, 283);
            this.GBSetPayrollDate.TabIndex = 0;
            this.GBSetPayrollDate.TabStop = false;
            this.GBSetPayrollDate.Text = "Set Payroll Date";
            // 
            // endLabel
            // 
            this.endLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(28, 109);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(81, 20);
            this.endLabel.TabIndex = 18;
            this.endLabel.Text = "End Date:";
            // 
            // startLabel
            // 
            this.startLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(28, 74);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(87, 20);
            this.startLabel.TabIndex = 17;
            this.startLabel.Text = "Start Date:";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endDatePicker.CustomFormat = "yyyy/MM/dd";
            this.endDatePicker.Enabled = false;
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(117, 104);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(350, 26);
            this.endDatePicker.TabIndex = 16;
            this.endDatePicker.Value = new System.DateTime(2019, 1, 5, 0, 0, 0, 0);
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDatePicker.CustomFormat = "yyyy/MM/dd";
            this.startDatePicker.Enabled = false;
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(117, 69);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(350, 26);
            this.startDatePicker.TabIndex = 15;
            this.startDatePicker.Value = new System.DateTime(2019, 1, 4, 0, 0, 0, 0);
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // frmPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 873);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmPayroll";
            this.Text = "frmPayroll";
            this.Load += new System.EventHandler(this.frmPayroll_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GBPayrollCalculate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridPayrollCalc)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.GBButtons.ResumeLayout(false);
            this.GBSetPayrollDate.ResumeLayout(false);
            this.GBSetPayrollDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GBSetPayrollDate;
        private System.Windows.Forms.GroupBox GBPayrollCalculate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox GBButtons;
        private System.Windows.Forms.GroupBox GBExtrabox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddPayroll;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DataGridView datagridPayrollCalc;
    }
}