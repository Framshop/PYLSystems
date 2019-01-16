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
            this.buttonsGB = new System.Windows.Forms.GroupBox();
            this.profitListGB = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.calcGB = new System.Windows.Forms.GroupBox();
            this.endCheck = new System.Windows.Forms.CheckBox();
            this.startCheck = new System.Windows.Forms.CheckBox();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rawTotalLabel = new System.Windows.Forms.Label();
            this.rawTotalTextBox = new System.Windows.Forms.TextBox();
            this.productsSoldBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.datePickerGB.SuspendLayout();
            this.buttonsGB.SuspendLayout();
            this.profitListGB.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.calcGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // buttonsGB
            // 
            this.buttonsGB.Controls.Add(this.closeBtn);
            this.buttonsGB.Controls.Add(this.productsSoldBtn);
            this.buttonsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsGB.Location = new System.Drawing.Point(3, 593);
            this.buttonsGB.Name = "buttonsGB";
            this.buttonsGB.Size = new System.Drawing.Size(323, 143);
            this.buttonsGB.TabIndex = 1;
            this.buttonsGB.TabStop = false;
            // 
            // profitListGB
            // 
            this.profitListGB.Controls.Add(this.dataGridView1);
            this.profitListGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profitListGB.Location = new System.Drawing.Point(3, 3);
            this.profitListGB.Name = "profitListGB";
            this.profitListGB.Size = new System.Drawing.Size(708, 473);
            this.profitListGB.TabIndex = 1;
            this.profitListGB.TabStop = false;
            this.profitListGB.Text = "List";
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
            // calcGB
            // 
            this.calcGB.Controls.Add(this.rawTotalLabel);
            this.calcGB.Controls.Add(this.rawTotalTextBox);
            this.calcGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calcGB.Location = new System.Drawing.Point(3, 482);
            this.calcGB.Name = "calcGB";
            this.calcGB.Size = new System.Drawing.Size(708, 254);
            this.calcGB.TabIndex = 2;
            this.calcGB.TabStop = false;
            this.calcGB.Text = "Summary";
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
            // 
            // startCheck
            // 
            this.startCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startCheck.AutoSize = true;
            this.startCheck.Location = new System.Drawing.Point(5, 48);
            this.startCheck.Name = "startCheck";
            this.startCheck.Size = new System.Drawing.Size(109, 24);
            this.startCheck.TabIndex = 6;
            this.startCheck.Text = "Start Date";
            this.startCheck.UseVisualStyleBackColor = true;
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
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDatePicker.CustomFormat = "yyyy/MM/dd";
            this.startDatePicker.Enabled = false;
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(117, 49);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 26);
            this.startDatePicker.TabIndex = 4;
            this.startDatePicker.Value = new System.DateTime(2019, 1, 4, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(702, 448);
            this.dataGridView1.TabIndex = 0;
            // 
            // rawTotalLabel
            // 
            this.rawTotalLabel.AutoSize = true;
            this.rawTotalLabel.Location = new System.Drawing.Point(35, 73);
            this.rawTotalLabel.Name = "rawTotalLabel";
            this.rawTotalLabel.Size = new System.Drawing.Size(48, 20);
            this.rawTotalLabel.TabIndex = 9;
            this.rawTotalLabel.Text = "Total:";
            // 
            // rawTotalTextBox
            // 
            this.rawTotalTextBox.Enabled = false;
            this.rawTotalTextBox.Location = new System.Drawing.Point(102, 73);
            this.rawTotalTextBox.Name = "rawTotalTextBox";
            this.rawTotalTextBox.Size = new System.Drawing.Size(170, 26);
            this.rawTotalTextBox.TabIndex = 8;
            // 
            // productsSoldBtn
            // 
            this.productsSoldBtn.Enabled = false;
            this.productsSoldBtn.Location = new System.Drawing.Point(94, 25);
            this.productsSoldBtn.Name = "productsSoldBtn";
            this.productsSoldBtn.Size = new System.Drawing.Size(130, 37);
            this.productsSoldBtn.TabIndex = 1;
            this.productsSoldBtn.Text = "Products Sold";
            this.productsSoldBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Enabled = false;
            this.closeBtn.Location = new System.Drawing.Point(94, 68);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(130, 37);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // viewTotalProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 745);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "viewTotalProfit";
            this.Text = "viewTotalProfit";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.datePickerGB.ResumeLayout(false);
            this.datePickerGB.PerformLayout();
            this.buttonsGB.ResumeLayout(false);
            this.profitListGB.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.calcGB.ResumeLayout(false);
            this.calcGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label rawTotalLabel;
        private System.Windows.Forms.TextBox rawTotalTextBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button productsSoldBtn;
    }
}