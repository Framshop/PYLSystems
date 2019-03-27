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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(987, 497);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonsGB, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.datePickerGB, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.625F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.16667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(309, 493);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonsGB
            // 
            this.buttonsGB.Controls.Add(this.closeBtn);
            this.buttonsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsGB.Location = new System.Drawing.Point(2, 396);
            this.buttonsGB.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsGB.Name = "buttonsGB";
            this.buttonsGB.Padding = new System.Windows.Forms.Padding(2);
            this.buttonsGB.Size = new System.Drawing.Size(305, 95);
            this.buttonsGB.TabIndex = 2;
            this.buttonsGB.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(66, 20);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(162, 68);
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
            this.datePickerGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerGB.Location = new System.Drawing.Point(2, 2);
            this.datePickerGB.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerGB.Name = "datePickerGB";
            this.datePickerGB.Padding = new System.Windows.Forms.Padding(2);
            this.datePickerGB.Size = new System.Drawing.Size(305, 246);
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
            this.endCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endCheck.Location = new System.Drawing.Point(7, 135);
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
            this.startCheck.Location = new System.Drawing.Point(7, 59);
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
            this.endDatePicker.Location = new System.Drawing.Point(7, 172);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(224, 35);
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
            this.startDatePicker.Location = new System.Drawing.Point(4, 96);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(224, 35);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(315, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.95F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.05F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(670, 493);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // calcGB
            // 
            this.calcGB.Controls.Add(this.rawTotalLabel);
            this.calcGB.Controls.Add(this.totalSoldTextBox);
            this.calcGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calcGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcGB.Location = new System.Drawing.Point(2, 322);
            this.calcGB.Margin = new System.Windows.Forms.Padding(2);
            this.calcGB.Name = "calcGB";
            this.calcGB.Padding = new System.Windows.Forms.Padding(2);
            this.calcGB.Size = new System.Drawing.Size(666, 169);
            this.calcGB.TabIndex = 3;
            this.calcGB.TabStop = false;
            this.calcGB.Text = "Summary";
            // 
            // rawTotalLabel
            // 
            this.rawTotalLabel.AutoSize = true;
            this.rawTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rawTotalLabel.Location = new System.Drawing.Point(29, 73);
            this.rawTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rawTotalLabel.Name = "rawTotalLabel";
            this.rawTotalLabel.Size = new System.Drawing.Size(130, 29);
            this.rawTotalLabel.TabIndex = 9;
            this.rawTotalLabel.Text = "Total Sold:";
            // 
            // totalSoldTextBox
            // 
            this.totalSoldTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSoldTextBox.Location = new System.Drawing.Point(163, 67);
            this.totalSoldTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalSoldTextBox.Name = "totalSoldTextBox";
            this.totalSoldTextBox.ReadOnly = true;
            this.totalSoldTextBox.Size = new System.Drawing.Size(442, 35);
            this.totalSoldTextBox.TabIndex = 8;
            // 
            // profitListGB
            // 
            this.profitListGB.Controls.Add(this.viewProductsSoldGrid);
            this.profitListGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profitListGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitListGB.Location = new System.Drawing.Point(2, 2);
            this.profitListGB.Margin = new System.Windows.Forms.Padding(2);
            this.profitListGB.Name = "profitListGB";
            this.profitListGB.Padding = new System.Windows.Forms.Padding(2);
            this.profitListGB.Size = new System.Drawing.Size(666, 316);
            this.profitListGB.TabIndex = 2;
            this.profitListGB.TabStop = false;
            this.profitListGB.Text = "List";
            // 
            // viewProductsSoldGrid
            // 
            this.viewProductsSoldGrid.AllowUserToAddRows = false;
            this.viewProductsSoldGrid.AllowUserToDeleteRows = false;
            this.viewProductsSoldGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewProductsSoldGrid.BackgroundColor = System.Drawing.Color.White;
            this.viewProductsSoldGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewProductsSoldGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewProductsSoldGrid.GridColor = System.Drawing.Color.White;
            this.viewProductsSoldGrid.Location = new System.Drawing.Point(2, 30);
            this.viewProductsSoldGrid.Margin = new System.Windows.Forms.Padding(2);
            this.viewProductsSoldGrid.Name = "viewProductsSoldGrid";
            this.viewProductsSoldGrid.ReadOnly = true;
            this.viewProductsSoldGrid.RowHeadersVisible = false;
            this.viewProductsSoldGrid.RowTemplate.Height = 28;
            this.viewProductsSoldGrid.Size = new System.Drawing.Size(662, 284);
            this.viewProductsSoldGrid.TabIndex = 0;
            // 
            // viewProductsSold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(987, 497);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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