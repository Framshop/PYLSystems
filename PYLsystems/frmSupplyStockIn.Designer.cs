namespace PYLsystems
{
    partial class frmSupplyStockIn
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gpSupply = new System.Windows.Forms.GroupBox();
            this.lblActualPurchasePrice = new System.Windows.Forms.Label();
            this.txtActualPurchasePrice = new System.Windows.Forms.TextBox();
            this.lblRawPurchasePrice = new System.Windows.Forms.Label();
            this.txtRawPurchasePrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.gpSelectSupplier = new System.Windows.Forms.GroupBox();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEditDetails = new System.Windows.Forms.Button();
            this.btnStockInItem = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.gpStockIn = new System.Windows.Forms.GroupBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvStockIn = new System.Windows.Forms.DataGridView();
            this.lblsupply_itemsID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.gpSupply.SuspendLayout();
            this.gpSelectSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.gpStockIn.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIn)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 975);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblsupply_itemsID, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(71, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1227, 969);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.25F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 51);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1221, 866);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.gpSupply, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.gpSelectSupplier, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(467, 860);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // gpSupply
            // 
            this.gpSupply.Controls.Add(this.lblActualPurchasePrice);
            this.gpSupply.Controls.Add(this.txtActualPurchasePrice);
            this.gpSupply.Controls.Add(this.lblRawPurchasePrice);
            this.gpSupply.Controls.Add(this.txtRawPurchasePrice);
            this.gpSupply.Controls.Add(this.lblQuantity);
            this.gpSupply.Controls.Add(this.txtQuantity);
            this.gpSupply.Controls.Add(this.lblItemName);
            this.gpSupply.Controls.Add(this.txtItemName);
            this.gpSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpSupply.Location = new System.Drawing.Point(3, 3);
            this.gpSupply.Name = "gpSupply";
            this.gpSupply.Size = new System.Drawing.Size(461, 280);
            this.gpSupply.TabIndex = 0;
            this.gpSupply.TabStop = false;
            this.gpSupply.Text = "Supply";
            // 
            // lblActualPurchasePrice
            // 
            this.lblActualPurchasePrice.AutoSize = true;
            this.lblActualPurchasePrice.Location = new System.Drawing.Point(16, 206);
            this.lblActualPurchasePrice.Name = "lblActualPurchasePrice";
            this.lblActualPurchasePrice.Size = new System.Drawing.Size(168, 20);
            this.lblActualPurchasePrice.TabIndex = 13;
            this.lblActualPurchasePrice.Text = "Actual Purchase Price:";
            // 
            // txtActualPurchasePrice
            // 
            this.txtActualPurchasePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualPurchasePrice.Location = new System.Drawing.Point(199, 203);
            this.txtActualPurchasePrice.Name = "txtActualPurchasePrice";
            this.txtActualPurchasePrice.Size = new System.Drawing.Size(244, 26);
            this.txtActualPurchasePrice.TabIndex = 12;
            this.txtActualPurchasePrice.TextChanged += new System.EventHandler(this.txtActualPurchasePrice_TextChanged);
            this.txtActualPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // lblRawPurchasePrice
            // 
            this.lblRawPurchasePrice.AutoSize = true;
            this.lblRawPurchasePrice.Location = new System.Drawing.Point(28, 155);
            this.lblRawPurchasePrice.Name = "lblRawPurchasePrice";
            this.lblRawPurchasePrice.Size = new System.Drawing.Size(155, 20);
            this.lblRawPurchasePrice.TabIndex = 11;
            this.lblRawPurchasePrice.Text = "Raw Purchase Price:";
            // 
            // txtRawPurchasePrice
            // 
            this.txtRawPurchasePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRawPurchasePrice.Location = new System.Drawing.Point(199, 152);
            this.txtRawPurchasePrice.Name = "txtRawPurchasePrice";
            this.txtRawPurchasePrice.ReadOnly = true;
            this.txtRawPurchasePrice.Size = new System.Drawing.Size(244, 26);
            this.txtRawPurchasePrice.TabIndex = 10;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(112, 105);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(72, 20);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Location = new System.Drawing.Point(199, 102);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(244, 26);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(90, 49);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(91, 20);
            this.lblItemName.TabIndex = 7;
            this.lblItemName.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemName.Location = new System.Drawing.Point(199, 48);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(244, 26);
            this.txtItemName.TabIndex = 6;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // gpSelectSupplier
            // 
            this.gpSelectSupplier.Controls.Add(this.dgvSupplier);
            this.gpSelectSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpSelectSupplier.Location = new System.Drawing.Point(3, 289);
            this.gpSelectSupplier.Name = "gpSelectSupplier";
            this.gpSelectSupplier.Size = new System.Drawing.Size(461, 280);
            this.gpSelectSupplier.TabIndex = 1;
            this.gpSelectSupplier.TabStop = false;
            this.gpSelectSupplier.Text = "Select Supplier";
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AllowUserToDeleteRows = false;
            this.dgvSupplier.AllowUserToResizeRows = false;
            this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupplier.Location = new System.Drawing.Point(3, 22);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowHeadersVisible = false;
            this.dgvSupplier.RowTemplate.Height = 28;
            this.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplier.Size = new System.Drawing.Size(455, 255);
            this.dgvSupplier.TabIndex = 3;
            this.dgvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEditDetails);
            this.groupBox3.Controls.Add(this.btnStockInItem);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 575);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 282);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDetails.Enabled = false;
            this.btnEditDetails.Location = new System.Drawing.Point(94, 105);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(273, 37);
            this.btnEditDetails.TabIndex = 36;
            this.btnEditDetails.Text = "Edit Details";
            this.btnEditDetails.UseVisualStyleBackColor = true;
            this.btnEditDetails.Click += new System.EventHandler(this.btnEditDetails_Click);
            // 
            // btnStockInItem
            // 
            this.btnStockInItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStockInItem.Enabled = false;
            this.btnStockInItem.Location = new System.Drawing.Point(94, 52);
            this.btnStockInItem.Name = "btnStockInItem";
            this.btnStockInItem.Size = new System.Drawing.Size(273, 37);
            this.btnStockInItem.TabIndex = 35;
            this.btnStockInItem.Text = "Stock In Item";
            this.btnStockInItem.UseVisualStyleBackColor = true;
            this.btnStockInItem.Click += new System.EventHandler(this.btnStockInItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(94, 155);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(273, 37);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.gpStockIn, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(476, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.04113F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.95887F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(742, 860);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // gpStockIn
            // 
            this.gpStockIn.Controls.Add(this.lblEndDate);
            this.gpStockIn.Controls.Add(this.lblStartDate);
            this.gpStockIn.Controls.Add(this.endDatePicker);
            this.gpStockIn.Controls.Add(this.startDatePicker);
            this.gpStockIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpStockIn.Location = new System.Drawing.Point(3, 3);
            this.gpStockIn.Name = "gpStockIn";
            this.gpStockIn.Size = new System.Drawing.Size(736, 123);
            this.gpStockIn.TabIndex = 0;
            this.gpStockIn.TabStop = false;
            this.gpStockIn.Text = "View Stock In Records By Delivery Dates";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(136, 71);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(81, 20);
            this.lblEndDate.TabIndex = 22;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(130, 35);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(87, 20);
            this.lblStartDate.TabIndex = 21;
            this.lblStartDate.Text = "Start Date:";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endDatePicker.CustomFormat = "yyyy-MM-dd";
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(219, 66);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(387, 26);
            this.endDatePicker.TabIndex = 20;
            this.endDatePicker.Value = new System.DateTime(2019, 1, 5, 0, 0, 0, 0);
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDatePicker.CustomFormat = "yyyy-MM-dd";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(219, 31);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(387, 26);
            this.startDatePicker.TabIndex = 19;
            this.startDatePicker.Value = new System.DateTime(2019, 1, 4, 0, 0, 0, 0);
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvStockIn);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 132);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(736, 725);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Stock In Records";
            // 
            // dgvStockIn
            // 
            this.dgvStockIn.AllowUserToAddRows = false;
            this.dgvStockIn.AllowUserToDeleteRows = false;
            this.dgvStockIn.AllowUserToResizeRows = false;
            this.dgvStockIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockIn.Location = new System.Drawing.Point(3, 22);
            this.dgvStockIn.Name = "dgvStockIn";
            this.dgvStockIn.ReadOnly = true;
            this.dgvStockIn.RowHeadersVisible = false;
            this.dgvStockIn.RowTemplate.Height = 28;
            this.dgvStockIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockIn.Size = new System.Drawing.Size(730, 700);
            this.dgvStockIn.TabIndex = 4;
            this.dgvStockIn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockIn_CellClick);
            // 
            // lblsupply_itemsID
            // 
            this.lblsupply_itemsID.AutoSize = true;
            this.lblsupply_itemsID.Location = new System.Drawing.Point(4, 0);
            this.lblsupply_itemsID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsupply_itemsID.Name = "lblsupply_itemsID";
            this.lblsupply_itemsID.Size = new System.Drawing.Size(0, 20);
            this.lblsupply_itemsID.TabIndex = 1;
            // 
            // frmSupplyStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 975);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSupplyStockIn";
            this.Text = "Supply Stock In";
            this.Load += new System.EventHandler(this.frmSupplyStockIn_Load);
            this.ResizeBegin += new System.EventHandler(this.frmSupplyStockIn_ResizeBegin);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.gpSupply.ResumeLayout(false);
            this.gpSupply.PerformLayout();
            this.gpSelectSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.gpStockIn.ResumeLayout(false);
            this.gpStockIn.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox gpSupply;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblActualPurchasePrice;
        private System.Windows.Forms.TextBox txtActualPurchasePrice;
        private System.Windows.Forms.Label lblRawPurchasePrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.GroupBox gpSelectSupplier;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStockInItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.GroupBox gpStockIn;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvStockIn;
        private System.Windows.Forms.Button btnEditDetails;
        public System.Windows.Forms.TextBox txtItemName;
        public System.Windows.Forms.TextBox txtRawPurchasePrice;
        public System.Windows.Forms.Label lblsupply_itemsID;
    }
}