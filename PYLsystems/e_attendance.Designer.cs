namespace PYLsystems
{
    partial class e_attendance
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
            this.infoGB = new System.Windows.Forms.GroupBox();
            this.dateSelectionGB = new System.Windows.Forms.GroupBox();
            this.timeInOutGB = new System.Windows.Forms.GroupBox();
            this.othersGB = new System.Windows.Forms.GroupBox();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dateNowTextBox = new System.Windows.Forms.TextBox();
            this.timeInBtn = new System.Windows.Forms.Button();
            this.timeOutBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.attendanceDatesGB = new System.Windows.Forms.GroupBox();
            this.attendanceGridView = new System.Windows.Forms.DataGridView();
            this.empNameTextBox = new System.Windows.Forms.TextBox();
            this.dateTodayLabel = new System.Windows.Forms.Label();
            this.empNameLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.infoGB.SuspendLayout();
            this.dateSelectionGB.SuspendLayout();
            this.timeInOutGB.SuspendLayout();
            this.othersGB.SuspendLayout();
            this.attendanceDatesGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.30409F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.69591F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.attendanceDatesGB, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1026, 743);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dateSelectionGB, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.timeInOutGB, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.infoGB, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.othersGB, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(386, 737);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // infoGB
            // 
            this.infoGB.Controls.Add(this.dateTodayLabel);
            this.infoGB.Controls.Add(this.dateNowTextBox);
            this.infoGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoGB.Location = new System.Drawing.Point(3, 187);
            this.infoGB.Name = "infoGB";
            this.infoGB.Size = new System.Drawing.Size(380, 178);
            this.infoGB.TabIndex = 0;
            this.infoGB.TabStop = false;
            // 
            // dateSelectionGB
            // 
            this.dateSelectionGB.Controls.Add(this.endLabel);
            this.dateSelectionGB.Controls.Add(this.startLabel);
            this.dateSelectionGB.Controls.Add(this.endDatePicker);
            this.dateSelectionGB.Controls.Add(this.empNameLabel);
            this.dateSelectionGB.Controls.Add(this.startDatePicker);
            this.dateSelectionGB.Controls.Add(this.empNameTextBox);
            this.dateSelectionGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateSelectionGB.Location = new System.Drawing.Point(3, 3);
            this.dateSelectionGB.Name = "dateSelectionGB";
            this.dateSelectionGB.Size = new System.Drawing.Size(380, 178);
            this.dateSelectionGB.TabIndex = 1;
            this.dateSelectionGB.TabStop = false;
            this.dateSelectionGB.Text = "Information";
            // 
            // timeInOutGB
            // 
            this.timeInOutGB.Controls.Add(this.timeInBtn);
            this.timeInOutGB.Controls.Add(this.timeOutBtn);
            this.timeInOutGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeInOutGB.Location = new System.Drawing.Point(3, 371);
            this.timeInOutGB.Name = "timeInOutGB";
            this.timeInOutGB.Size = new System.Drawing.Size(380, 178);
            this.timeInOutGB.TabIndex = 2;
            this.timeInOutGB.TabStop = false;
            // 
            // othersGB
            // 
            this.othersGB.Controls.Add(this.closeBtn);
            this.othersGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.othersGB.Location = new System.Drawing.Point(3, 555);
            this.othersGB.Name = "othersGB";
            this.othersGB.Size = new System.Drawing.Size(380, 179);
            this.othersGB.TabIndex = 3;
            this.othersGB.TabStop = false;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endDatePicker.CustomFormat = "yyyy/MM/dd";
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(103, 120);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(258, 26);
            this.endDatePicker.TabIndex = 7;
            this.endDatePicker.Value = new System.DateTime(2019, 1, 5, 0, 0, 0, 0);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDatePicker.CustomFormat = "yyyy/MM/dd";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(103, 85);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(258, 26);
            this.startDatePicker.TabIndex = 6;
            this.startDatePicker.Value = new System.DateTime(2019, 1, 4, 0, 0, 0, 0);
            // 
            // dateNowTextBox
            // 
            this.dateNowTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateNowTextBox.Location = new System.Drawing.Point(103, 44);
            this.dateNowTextBox.Name = "dateNowTextBox";
            this.dateNowTextBox.ReadOnly = true;
            this.dateNowTextBox.Size = new System.Drawing.Size(258, 26);
            this.dateNowTextBox.TabIndex = 7;
            // 
            // timeInBtn
            // 
            this.timeInBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeInBtn.Enabled = false;
            this.timeInBtn.Location = new System.Drawing.Point(72, 45);
            this.timeInBtn.Name = "timeInBtn";
            this.timeInBtn.Size = new System.Drawing.Size(218, 37);
            this.timeInBtn.TabIndex = 3;
            this.timeInBtn.Text = "Time In";
            this.timeInBtn.UseVisualStyleBackColor = true;
            // 
            // timeOutBtn
            // 
            this.timeOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeOutBtn.Enabled = false;
            this.timeOutBtn.Location = new System.Drawing.Point(72, 105);
            this.timeOutBtn.Name = "timeOutBtn";
            this.timeOutBtn.Size = new System.Drawing.Size(218, 37);
            this.timeOutBtn.TabIndex = 4;
            this.timeOutBtn.Text = "Time Out";
            this.timeOutBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Enabled = false;
            this.closeBtn.Location = new System.Drawing.Point(72, 65);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(218, 37);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // attendanceDatesGB
            // 
            this.attendanceDatesGB.Controls.Add(this.attendanceGridView);
            this.attendanceDatesGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendanceDatesGB.Location = new System.Drawing.Point(395, 3);
            this.attendanceDatesGB.Name = "attendanceDatesGB";
            this.attendanceDatesGB.Size = new System.Drawing.Size(628, 737);
            this.attendanceDatesGB.TabIndex = 1;
            this.attendanceDatesGB.TabStop = false;
            this.attendanceDatesGB.Text = "Attendance Dates";
            // 
            // attendanceGridView
            // 
            this.attendanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendanceGridView.Location = new System.Drawing.Point(3, 22);
            this.attendanceGridView.Name = "attendanceGridView";
            this.attendanceGridView.RowTemplate.Height = 28;
            this.attendanceGridView.Size = new System.Drawing.Size(622, 712);
            this.attendanceGridView.TabIndex = 2;
            // 
            // empNameTextBox
            // 
            this.empNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empNameTextBox.Location = new System.Drawing.Point(103, 39);
            this.empNameTextBox.Name = "empNameTextBox";
            this.empNameTextBox.ReadOnly = true;
            this.empNameTextBox.Size = new System.Drawing.Size(258, 26);
            this.empNameTextBox.TabIndex = 8;
            // 
            // dateTodayLabel
            // 
            this.dateTodayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTodayLabel.AutoSize = true;
            this.dateTodayLabel.Location = new System.Drawing.Point(2, 47);
            this.dateTodayLabel.Name = "dateTodayLabel";
            this.dateTodayLabel.Size = new System.Drawing.Size(95, 20);
            this.dateTodayLabel.TabIndex = 13;
            this.dateTodayLabel.Text = "Date Today:";
            // 
            // empNameLabel
            // 
            this.empNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empNameLabel.AutoSize = true;
            this.empNameLabel.Location = new System.Drawing.Point(14, 42);
            this.empNameLabel.Name = "empNameLabel";
            this.empNameLabel.Size = new System.Drawing.Size(83, 20);
            this.empNameLabel.TabIndex = 12;
            this.empNameLabel.Text = "Employee:";
            // 
            // startLabel
            // 
            this.startLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(14, 90);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(87, 20);
            this.startLabel.TabIndex = 13;
            this.startLabel.Text = "Start Date:";
            // 
            // endLabel
            // 
            this.endLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(14, 125);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(81, 20);
            this.endLabel.TabIndex = 14;
            this.endLabel.Text = "End Date:";
            // 
            // e_attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 743);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "e_attendance";
            this.Text = "Attendance";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.infoGB.ResumeLayout(false);
            this.infoGB.PerformLayout();
            this.dateSelectionGB.ResumeLayout(false);
            this.dateSelectionGB.PerformLayout();
            this.timeInOutGB.ResumeLayout(false);
            this.othersGB.ResumeLayout(false);
            this.attendanceDatesGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox infoGB;
        private System.Windows.Forms.GroupBox dateSelectionGB;
        private System.Windows.Forms.GroupBox timeInOutGB;
        private System.Windows.Forms.GroupBox othersGB;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.TextBox dateNowTextBox;
        private System.Windows.Forms.Button timeInBtn;
        private System.Windows.Forms.Button timeOutBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.GroupBox attendanceDatesGB;
        private System.Windows.Forms.DataGridView attendanceGridView;
        private System.Windows.Forms.TextBox empNameTextBox;
        private System.Windows.Forms.Label dateTodayLabel;
        private System.Windows.Forms.Label empNameLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
    }
}