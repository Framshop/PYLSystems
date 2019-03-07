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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxAmount = new System.Windows.Forms.TextBox();
            this.lblReceiverName = new System.Windows.Forms.Label();
            this.txtBoxReceiver = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPhilHealth = new System.Windows.Forms.Label();
            this.txtBoxSSS = new System.Windows.Forms.TextBox();
            this.lblSSS = new System.Windows.Forms.Label();
            this.txtBoxPhilhealth = new System.Windows.Forms.TextBox();
            this.lblCashAdv = new System.Windows.Forms.Label();
            this.txtBoxCashAdv = new System.Windows.Forms.TextBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.txtBoxEmployeeName = new System.Windows.Forms.TextBox();
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
            this.GBExtrabox.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1440, 989);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GBPayrollCalculate
            // 
            this.GBPayrollCalculate.Controls.Add(this.datagridPayrollCalc);
            this.GBPayrollCalculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBPayrollCalculate.Location = new System.Drawing.Point(542, 3);
            this.GBPayrollCalculate.Name = "GBPayrollCalculate";
            this.GBPayrollCalculate.Size = new System.Drawing.Size(895, 983);
            this.GBPayrollCalculate.TabIndex = 1;
            this.GBPayrollCalculate.TabStop = false;
            this.GBPayrollCalculate.Text = "Payroll";
            // 
            // datagridPayrollCalc
            // 
            this.datagridPayrollCalc.AllowUserToAddRows = false;
            this.datagridPayrollCalc.AllowUserToDeleteRows = false;
            this.datagridPayrollCalc.AllowUserToResizeRows = false;
            this.datagridPayrollCalc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridPayrollCalc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPayrollCalc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridPayrollCalc.Location = new System.Drawing.Point(3, 22);
            this.datagridPayrollCalc.Name = "datagridPayrollCalc";
            this.datagridPayrollCalc.ReadOnly = true;
            this.datagridPayrollCalc.RowHeadersVisible = false;
            this.datagridPayrollCalc.RowTemplate.Height = 28;
            this.datagridPayrollCalc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridPayrollCalc.Size = new System.Drawing.Size(889, 958);
            this.datagridPayrollCalc.TabIndex = 1;
            this.datagridPayrollCalc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridPayrollCalc_CellClick);
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.33062F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.30417F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.46694F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(533, 983);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // GBButtons
            // 
            this.GBButtons.Controls.Add(this.btnAddPayroll);
            this.GBButtons.Controls.Add(this.btnClose);
            this.GBButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBButtons.Location = new System.Drawing.Point(3, 715);
            this.GBButtons.Name = "GBButtons";
            this.GBButtons.Size = new System.Drawing.Size(527, 265);
            this.GBButtons.TabIndex = 2;
            this.GBButtons.TabStop = false;
            // 
            // btnAddPayroll
            // 
            this.btnAddPayroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPayroll.Location = new System.Drawing.Point(180, 66);
            this.btnAddPayroll.Name = "btnAddPayroll";
            this.btnAddPayroll.Size = new System.Drawing.Size(168, 37);
            this.btnAddPayroll.TabIndex = 5;
            this.btnAddPayroll.Text = "Add Payroll";
            this.btnAddPayroll.UseVisualStyleBackColor = true;
            this.btnAddPayroll.Click += new System.EventHandler(this.btnAddPayroll_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(180, 138);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GBExtrabox
            // 
            this.GBExtrabox.Controls.Add(this.label1);
            this.GBExtrabox.Controls.Add(this.txtBoxAmount);
            this.GBExtrabox.Controls.Add(this.lblReceiverName);
            this.GBExtrabox.Controls.Add(this.txtBoxReceiver);
            this.GBExtrabox.Controls.Add(this.btnEdit);
            this.GBExtrabox.Controls.Add(this.btnSave);
            this.GBExtrabox.Controls.Add(this.lblPhilHealth);
            this.GBExtrabox.Controls.Add(this.txtBoxSSS);
            this.GBExtrabox.Controls.Add(this.lblSSS);
            this.GBExtrabox.Controls.Add(this.txtBoxPhilhealth);
            this.GBExtrabox.Controls.Add(this.lblCashAdv);
            this.GBExtrabox.Controls.Add(this.txtBoxCashAdv);
            this.GBExtrabox.Controls.Add(this.lblEmpName);
            this.GBExtrabox.Controls.Add(this.txtBoxEmployeeName);
            this.GBExtrabox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBExtrabox.Location = new System.Drawing.Point(3, 251);
            this.GBExtrabox.Name = "GBExtrabox";
            this.GBExtrabox.Size = new System.Drawing.Size(527, 458);
            this.GBExtrabox.TabIndex = 1;
            this.GBExtrabox.TabStop = false;
            this.GBExtrabox.Text = "Set Payroll Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total Amount:";
            // 
            // txtBoxAmount
            // 
            this.txtBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAmount.Location = new System.Drawing.Point(167, 255);
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.ReadOnly = true;
            this.txtBoxAmount.Size = new System.Drawing.Size(320, 26);
            this.txtBoxAmount.TabIndex = 15;
            // 
            // lblReceiverName
            // 
            this.lblReceiverName.AutoSize = true;
            this.lblReceiverName.Location = new System.Drawing.Point(84, 308);
            this.lblReceiverName.Name = "lblReceiverName";
            this.lblReceiverName.Size = new System.Drawing.Size(75, 20);
            this.lblReceiverName.TabIndex = 14;
            this.lblReceiverName.Text = "Receiver:";
            // 
            // txtBoxReceiver
            // 
            this.txtBoxReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxReceiver.Location = new System.Drawing.Point(167, 308);
            this.txtBoxReceiver.Name = "txtBoxReceiver";
            this.txtBoxReceiver.Size = new System.Drawing.Size(320, 26);
            this.txtBoxReceiver.TabIndex = 13;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(286, 375);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(146, 37);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(117, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPhilHealth
            // 
            this.lblPhilHealth.AutoSize = true;
            this.lblPhilHealth.Location = new System.Drawing.Point(113, 205);
            this.lblPhilHealth.Name = "lblPhilHealth";
            this.lblPhilHealth.Size = new System.Drawing.Size(46, 20);
            this.lblPhilHealth.TabIndex = 11;
            this.lblPhilHealth.Text = "SSS:";
            // 
            // txtBoxSSS
            // 
            this.txtBoxSSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSSS.Location = new System.Drawing.Point(167, 205);
            this.txtBoxSSS.Name = "txtBoxSSS";
            this.txtBoxSSS.Size = new System.Drawing.Size(320, 26);
            this.txtBoxSSS.TabIndex = 10;
            this.txtBoxSSS.TextChanged += new System.EventHandler(this.txtBoxSSS_TextChanged);
            this.txtBoxSSS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSSS_KeyPress);
            // 
            // lblSSS
            // 
            this.lblSSS.AutoSize = true;
            this.lblSSS.Location = new System.Drawing.Point(76, 151);
            this.lblSSS.Name = "lblSSS";
            this.lblSSS.Size = new System.Drawing.Size(85, 20);
            this.lblSSS.TabIndex = 9;
            this.lblSSS.Text = "PhilHealth:";
            // 
            // txtBoxPhilhealth
            // 
            this.txtBoxPhilhealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPhilhealth.Location = new System.Drawing.Point(167, 151);
            this.txtBoxPhilhealth.Name = "txtBoxPhilhealth";
            this.txtBoxPhilhealth.Size = new System.Drawing.Size(320, 26);
            this.txtBoxPhilhealth.TabIndex = 8;
            this.txtBoxPhilhealth.TextChanged += new System.EventHandler(this.txtBoxPhilhealth_TextChanged);
            this.txtBoxPhilhealth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPhilhealth_KeyPress);
            // 
            // lblCashAdv
            // 
            this.lblCashAdv.AutoSize = true;
            this.lblCashAdv.Location = new System.Drawing.Point(45, 96);
            this.lblCashAdv.Name = "lblCashAdv";
            this.lblCashAdv.Size = new System.Drawing.Size(116, 20);
            this.lblCashAdv.TabIndex = 7;
            this.lblCashAdv.Text = "Cash Advance:";
            // 
            // txtBoxCashAdv
            // 
            this.txtBoxCashAdv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCashAdv.Location = new System.Drawing.Point(167, 96);
            this.txtBoxCashAdv.Name = "txtBoxCashAdv";
            this.txtBoxCashAdv.ReadOnly = true;
            this.txtBoxCashAdv.Size = new System.Drawing.Size(320, 26);
            this.txtBoxCashAdv.TabIndex = 6;
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(32, 46);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(129, 20);
            this.lblEmpName.TabIndex = 5;
            this.lblEmpName.Text = "Employee Name:";
            // 
            // txtBoxEmployeeName
            // 
            this.txtBoxEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxEmployeeName.Location = new System.Drawing.Point(167, 46);
            this.txtBoxEmployeeName.Name = "txtBoxEmployeeName";
            this.txtBoxEmployeeName.ReadOnly = true;
            this.txtBoxEmployeeName.Size = new System.Drawing.Size(320, 26);
            this.txtBoxEmployeeName.TabIndex = 4;
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
            this.GBSetPayrollDate.Size = new System.Drawing.Size(527, 242);
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
            this.endDatePicker.Size = new System.Drawing.Size(388, 26);
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
            this.startDatePicker.Size = new System.Drawing.Size(388, 26);
            this.startDatePicker.TabIndex = 15;
            this.startDatePicker.Value = new System.DateTime(2019, 1, 4, 0, 0, 0, 0);
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // frmPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 989);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmPayroll";
            this.Text = "frmPayroll";
            this.Load += new System.EventHandler(this.frmPayroll_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GBPayrollCalculate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridPayrollCalc)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.GBButtons.ResumeLayout(false);
            this.GBExtrabox.ResumeLayout(false);
            this.GBExtrabox.PerformLayout();
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
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPhilHealth;
        private System.Windows.Forms.TextBox txtBoxSSS;
        private System.Windows.Forms.Label lblSSS;
        private System.Windows.Forms.TextBox txtBoxPhilhealth;
        private System.Windows.Forms.Label lblCashAdv;
        private System.Windows.Forms.TextBox txtBoxCashAdv;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.TextBox txtBoxEmployeeName;
        private System.Windows.Forms.Label lblReceiverName;
        private System.Windows.Forms.TextBox txtBoxReceiver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxAmount;
    }
}