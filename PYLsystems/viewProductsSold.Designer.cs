namespace PYLsystems
{
    partial class viewProductsSold
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
            this.buttonsGB = new System.Windows.Forms.GroupBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.datePickerGB = new System.Windows.Forms.GroupBox();
            this.endCheck = new System.Windows.Forms.CheckBox();
            this.startCheck = new System.Windows.Forms.CheckBox();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.calcGB = new System.Windows.Forms.GroupBox();
            this.rawTotalLabel = new System.Windows.Forms.Label();
            this.totalSoldTextBox = new System.Windows.Forms.TextBox();
            this.profitListGB = new System.Windows.Forms.GroupBox();
            this.viewProductsSoldGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.buttonsGB.SuspendLayout();
            this.datePickerGB.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.calcGB.SuspendLayout();
            this.profitListGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewProductsSoldGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1055, 745);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonsGB, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.datePickerGB, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(328, 739);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonsGB
            // 
            this.buttonsGB.Controls.Add(this.closeBtn);
            this.buttonsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsGB.Location = new System.Drawing.Point(3, 593);
            this.buttonsGB.Name = "buttonsGB";
            this.buttonsGB.Size = new System.Drawing.Size(322, 143);
            this.buttonsGB.TabIndex = 2;
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
            // datePickerGB
            // 
            this.datePickerGB.Controls.Add(this.endCheck);
            this.datePickerGB.Controls.Add(this.startCheck);
            this.datePickerGB.Controls.Add(this.endDatePicker);
            this.datePickerGB.Controls.Add(this.startDatePicker);
            this.datePickerGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePickerGB.Location = new System.Drawing.Point(3, 3);
            this.datePickerGB.Name = "datePickerGB";
            this.datePickerGB.Size = new System.Drawing.Size(322, 141);
            this.datePickerGB.TabIndex = 1;
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
            this.endDatePicker.Size = new System.Drawing.Size(199, 26);
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
            this.startDatePicker.Size = new System.Drawing.Size(199, 26);
            this.startDatePicker.TabIndex = 4;
            this.startDatePicker.Value = new System.DateTime(2019, 1, 4, 0, 0, 0, 0);
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.calcGB, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.profitListGB, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(337, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.95F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.05F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(715, 739);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // calcGB
            // 
            this.calcGB.Controls.Add(this.rawTotalLabel);
            this.calcGB.Controls.Add(this.totalSoldTextBox);
            this.calcGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calcGB.Location = new System.Drawing.Point(3, 482);
            this.calcGB.Name = "calcGB";
            this.calcGB.Size = new System.Drawing.Size(709, 254);
            this.calcGB.TabIndex = 3;
            this.calcGB.TabStop = false;
            this.calcGB.Text = "Summary";
            // 
            // rawTotalLabel
            // 
            this.rawTotalLabel.AutoSize = true;
            this.rawTotalLabel.Location = new System.Drawing.Point(32, 65);
            this.rawTotalLabel.Name = "rawTotalLabel";
            this.rawTotalLabel.Size = new System.Drawing.Size(84, 20);
            this.rawTotalLabel.TabIndex = 9;
            this.rawTotalLabel.Text = "Total Sold:";
            // 
            // totalSoldTextBox
            // 
            this.totalSoldTextBox.Location = new System.Drawing.Point(135, 65);
            this.totalSoldTextBox.Name = "totalSoldTextBox";
            this.totalSoldTextBox.ReadOnly = true;
            this.totalSoldTextBox.Size = new System.Drawing.Size(170, 26);
            this.totalSoldTextBox.TabIndex = 8;
            // 
            // profitListGB
            // 
            this.profitListGB.Controls.Add(this.viewProductsSoldGrid);
            this.profitListGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profitListGB.Location = new System.Drawing.Point(3, 3);
            this.profitListGB.Name = "profitListGB";
            this.profitListGB.Size = new System.Drawing.Size(709, 473);
            this.profitListGB.TabIndex = 2;
            this.profitListGB.TabStop = false;
            this.profitListGB.Text = "List";
            // 
            // viewProductsSoldGrid
            // 
            this.viewProductsSoldGrid.AllowUserToAddRows = false;
            this.viewProductsSoldGrid.AllowUserToDeleteRows = false;
            this.viewProductsSoldGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewProductsSoldGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewProductsSoldGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewProductsSoldGrid.Location = new System.Drawing.Point(3, 22);
            this.viewProductsSoldGrid.Name = "viewProductsSoldGrid";
            this.viewProductsSoldGrid.ReadOnly = true;
            this.viewProductsSoldGrid.RowHeadersVisible = false;
            this.viewProductsSoldGrid.RowTemplate.Height = 28;
            this.viewProductsSoldGrid.Size = new System.Drawing.Size(703, 448);
            this.viewProductsSoldGrid.TabIndex = 0;
            // 
            // viewProductsSold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1055, 745);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "viewProductsSold";
            this.Text = "viewProductsSold";
            this.Load += new System.EventHandler(this.viewProductsSold_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.buttonsGB.ResumeLayout(false);
            this.datePickerGB.ResumeLayout(false);
            this.datePickerGB.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.calcGB.ResumeLayout(false);
            this.calcGB.PerformLayout();
            this.profitListGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewProductsSoldGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox datePickerGB;
        private System.Windows.Forms.CheckBox endCheck;
        private System.Windows.Forms.CheckBox startCheck;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.GroupBox buttonsGB;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.GroupBox profitListGB;
        private System.Windows.Forms.DataGridView viewProductsSoldGrid;
        private System.Windows.Forms.GroupBox calcGB;
        private System.Windows.Forms.Label rawTotalLabel;
        private System.Windows.Forms.TextBox totalSoldTextBox;
    }
}