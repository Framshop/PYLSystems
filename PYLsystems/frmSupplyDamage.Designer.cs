namespace PYLsystems
{
    partial class frmSupplyDamage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplyDamage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.gpStockOut = new System.Windows.Forms.GroupBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvStockOut = new System.Windows.Forms.DataGridView();
            this.gpStockOutDamageSupplies = new System.Windows.Forms.GroupBox();
            this.txtUnitMeasure = new System.Windows.Forms.TextBox();
            this.lblUnitMeasure = new System.Windows.Forms.Label();
            this.txtSupplyCategory = new System.Windows.Forms.TextBox();
            this.txtDamageReason = new System.Windows.Forms.TextBox();
            this.lblDamageReason = new System.Windows.Forms.Label();
            this.lblCalculatedStockedQuantity = new System.Windows.Forms.Label();
            this.txtCalculatedStockedQuantity = new System.Windows.Forms.TextBox();
            this.lblSupplyCategory = new System.Windows.Forms.Label();
            this.btnStockOutItem = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboVolumeUnit = new System.Windows.Forms.ComboBox();
            this.txtBoxVolume = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtBoxWhole = new System.Windows.Forms.TextBox();
            this.cboWholeUnit = new System.Windows.Forms.ComboBox();
            this.lblWhole = new System.Windows.Forms.Label();
            this.cboWeightUnit = new System.Windows.Forms.ComboBox();
            this.txtBoxWeight = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.txtBoxAreaWidth = new System.Windows.Forms.TextBox();
            this.cboAreaUnit = new System.Windows.Forms.ComboBox();
            this.txtBoxAreaLength = new System.Windows.Forms.TextBox();
            this.cboLengthUnit = new System.Windows.Forms.ComboBox();
            this.txtBoxLength = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lbLength = new System.Windows.Forms.Label();
            this.lblTotalDamageCost = new System.Windows.Forms.Label();
            this.txtTotalDamageCost = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.imgAll = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.gpStockOut.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOut)).BeginInit();
            this.gpStockOutDamageSupplies.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.011236F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.20225F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8988764F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(890, 648);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.552795F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.20497F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.242236F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(869, 644);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.50298F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.49702F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gpStockOutDamageSupplies, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 12);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(865, 622);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.gpStockOut, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(430, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.44984F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.55016F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(433, 618);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // gpStockOut
            // 
            this.gpStockOut.Controls.Add(this.lblEndDate);
            this.gpStockOut.Controls.Add(this.lblStartDate);
            this.gpStockOut.Controls.Add(this.endDatePicker);
            this.gpStockOut.Controls.Add(this.startDatePicker);
            this.gpStockOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpStockOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpStockOut.Location = new System.Drawing.Point(2, 2);
            this.gpStockOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpStockOut.Name = "gpStockOut";
            this.gpStockOut.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpStockOut.Size = new System.Drawing.Size(429, 178);
            this.gpStockOut.TabIndex = 0;
            this.gpStockOut.TabStop = false;
            this.gpStockOut.Text = "View Stock Out Records By Dates";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(19, 125);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(93, 24);
            this.lblEndDate.TabIndex = 22;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(18, 67);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(94, 24);
            this.lblStartDate.TabIndex = 21;
            this.lblStartDate.Text = "Start Date:";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endDatePicker.CustomFormat = "yyyy-MM-dd";
            this.endDatePicker.Enabled = false;
            this.endDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(153, 120);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(247, 29);
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
            this.startDatePicker.Enabled = false;
            this.startDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(153, 62);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(247, 29);
            this.startDatePicker.TabIndex = 19;
            this.startDatePicker.Value = new System.DateTime(2019, 1, 4, 0, 0, 0, 0);
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvStockOut);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(2, 184);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(429, 432);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Stock Out Records";
            // 
            // dgvStockOut
            // 
            this.dgvStockOut.AllowUserToAddRows = false;
            this.dgvStockOut.AllowUserToDeleteRows = false;
            this.dgvStockOut.AllowUserToResizeRows = false;
            this.dgvStockOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockOut.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockOut.GridColor = System.Drawing.Color.White;
            this.dgvStockOut.Location = new System.Drawing.Point(2, 30);
            this.dgvStockOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvStockOut.Name = "dgvStockOut";
            this.dgvStockOut.ReadOnly = true;
            this.dgvStockOut.RowHeadersVisible = false;
            this.dgvStockOut.RowTemplate.Height = 28;
            this.dgvStockOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockOut.Size = new System.Drawing.Size(425, 400);
            this.dgvStockOut.TabIndex = 5;
            // 
            // gpStockOutDamageSupplies
            // 
            this.gpStockOutDamageSupplies.Controls.Add(this.txtUnitMeasure);
            this.gpStockOutDamageSupplies.Controls.Add(this.lblUnitMeasure);
            this.gpStockOutDamageSupplies.Controls.Add(this.txtSupplyCategory);
            this.gpStockOutDamageSupplies.Controls.Add(this.txtDamageReason);
            this.gpStockOutDamageSupplies.Controls.Add(this.lblDamageReason);
            this.gpStockOutDamageSupplies.Controls.Add(this.lblCalculatedStockedQuantity);
            this.gpStockOutDamageSupplies.Controls.Add(this.txtCalculatedStockedQuantity);
            this.gpStockOutDamageSupplies.Controls.Add(this.lblSupplyCategory);
            this.gpStockOutDamageSupplies.Controls.Add(this.btnStockOutItem);
            this.gpStockOutDamageSupplies.Controls.Add(this.btnClose);
            this.gpStockOutDamageSupplies.Controls.Add(this.cboVolumeUnit);
            this.gpStockOutDamageSupplies.Controls.Add(this.txtBoxVolume);
            this.gpStockOutDamageSupplies.Controls.Add(this.lblVolume);
            this.gpStockOutDamageSupplies.Controls.Add(this.txtBoxWhole);
            this.gpStockOutDamageSupplies.Controls.Add(this.cboWholeUnit);
            this.gpStockOutDamageSupplies.Controls.Add(this.lblWhole);
            this.gpStockOutDamageSupplies.Controls.Add(this.cboWeightUnit);
            this.gpStockOutDamageSupplies.Controls.Add(this.txtBoxWeight);
            this.gpStockOutDamageSupplies.Controls.Add(this.lblX);
            this.gpStockOutDamageSupplies.Controls.Add(this.txtBoxAreaWidth);
            this.gpStockOutDamageSupplies.Controls.Add(this.cboAreaUnit);
            this.gpStockOutDamageSupplies.Controls.Add(this.txtBoxAreaLength);
            this.gpStockOutDamageSupplies.Controls.Add(this.cboLengthUnit);
            this.gpStockOutDamageSupplies.Controls.Add(this.txtBoxLength);
            this.gpStockOutDamageSupplies.Controls.Add(this.lblWeight);
            this.gpStockOutDamageSupplies.Controls.Add(this.lblArea);
            this.gpStockOutDamageSupplies.Controls.Add(this.lbLength);
            this.gpStockOutDamageSupplies.Controls.Add(this.lblTotalDamageCost);
            this.gpStockOutDamageSupplies.Controls.Add(this.txtTotalDamageCost);
            this.gpStockOutDamageSupplies.Controls.Add(this.lblItemName);
            this.gpStockOutDamageSupplies.Controls.Add(this.txtItemName);
            this.gpStockOutDamageSupplies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpStockOutDamageSupplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpStockOutDamageSupplies.Location = new System.Drawing.Point(2, 2);
            this.gpStockOutDamageSupplies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpStockOutDamageSupplies.Name = "gpStockOutDamageSupplies";
            this.gpStockOutDamageSupplies.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpStockOutDamageSupplies.Size = new System.Drawing.Size(424, 618);
            this.gpStockOutDamageSupplies.TabIndex = 1;
            this.gpStockOutDamageSupplies.TabStop = false;
            this.gpStockOutDamageSupplies.Text = "Stock Out Damaged Supplies";
            // 
            // txtUnitMeasure
            // 
            this.txtUnitMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnitMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitMeasure.Location = new System.Drawing.Point(194, 126);
            this.txtUnitMeasure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUnitMeasure.Name = "txtUnitMeasure";
            this.txtUnitMeasure.ReadOnly = true;
            this.txtUnitMeasure.Size = new System.Drawing.Size(222, 27);
            this.txtUnitMeasure.TabIndex = 68;
            // 
            // lblUnitMeasure
            // 
            this.lblUnitMeasure.AutoSize = true;
            this.lblUnitMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitMeasure.Location = new System.Drawing.Point(9, 133);
            this.lblUnitMeasure.Name = "lblUnitMeasure";
            this.lblUnitMeasure.Size = new System.Drawing.Size(114, 20);
            this.lblUnitMeasure.TabIndex = 67;
            this.lblUnitMeasure.Text = "Unit Measure:";
            // 
            // txtSupplyCategory
            // 
            this.txtSupplyCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSupplyCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplyCategory.Location = new System.Drawing.Point(193, 64);
            this.txtSupplyCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSupplyCategory.Name = "txtSupplyCategory";
            this.txtSupplyCategory.ReadOnly = true;
            this.txtSupplyCategory.Size = new System.Drawing.Size(222, 27);
            this.txtSupplyCategory.TabIndex = 66;
            // 
            // txtDamageReason
            // 
            this.txtDamageReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDamageReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDamageReason.Location = new System.Drawing.Point(194, 158);
            this.txtDamageReason.Multiline = true;
            this.txtDamageReason.Name = "txtDamageReason";
            this.txtDamageReason.Size = new System.Drawing.Size(222, 49);
            this.txtDamageReason.TabIndex = 65;
            // 
            // lblDamageReason
            // 
            this.lblDamageReason.AutoSize = true;
            this.lblDamageReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamageReason.Location = new System.Drawing.Point(11, 158);
            this.lblDamageReason.Name = "lblDamageReason";
            this.lblDamageReason.Size = new System.Drawing.Size(150, 20);
            this.lblDamageReason.TabIndex = 64;
            this.lblDamageReason.Text = "Damage Reason: *";
            // 
            // lblCalculatedStockedQuantity
            // 
            this.lblCalculatedStockedQuantity.AutoSize = true;
            this.lblCalculatedStockedQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculatedStockedQuantity.Location = new System.Drawing.Point(10, 399);
            this.lblCalculatedStockedQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalculatedStockedQuantity.Name = "lblCalculatedStockedQuantity";
            this.lblCalculatedStockedQuantity.Size = new System.Drawing.Size(158, 40);
            this.lblCalculatedStockedQuantity.TabIndex = 63;
            this.lblCalculatedStockedQuantity.Text = "Calculated Stocked \r\nOut Quantity:";
            // 
            // txtCalculatedStockedQuantity
            // 
            this.txtCalculatedStockedQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCalculatedStockedQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalculatedStockedQuantity.Location = new System.Drawing.Point(208, 399);
            this.txtCalculatedStockedQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCalculatedStockedQuantity.Name = "txtCalculatedStockedQuantity";
            this.txtCalculatedStockedQuantity.ReadOnly = true;
            this.txtCalculatedStockedQuantity.Size = new System.Drawing.Size(208, 27);
            this.txtCalculatedStockedQuantity.TabIndex = 62;
            // 
            // lblSupplyCategory
            // 
            this.lblSupplyCategory.AutoSize = true;
            this.lblSupplyCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplyCategory.Location = new System.Drawing.Point(11, 71);
            this.lblSupplyCategory.Name = "lblSupplyCategory";
            this.lblSupplyCategory.Size = new System.Drawing.Size(141, 20);
            this.lblSupplyCategory.TabIndex = 61;
            this.lblSupplyCategory.Text = "Supply Category: ";
            // 
            // btnStockOutItem
            // 
            this.btnStockOutItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStockOutItem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnStockOutItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStockOutItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockOutItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockOutItem.ImageIndex = 6;
            this.btnStockOutItem.ImageList = this.imgAll;
            this.btnStockOutItem.Location = new System.Drawing.Point(4, 506);
            this.btnStockOutItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStockOutItem.Name = "btnStockOutItem";
            this.btnStockOutItem.Size = new System.Drawing.Size(201, 53);
            this.btnStockOutItem.TabIndex = 58;
            this.btnStockOutItem.Text = "Stock Out Item";
            this.btnStockOutItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStockOutItem.UseVisualStyleBackColor = false;
            this.btnStockOutItem.Click += new System.EventHandler(this.btnStockOutItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.PaleGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImageIndex = 0;
            this.btnClose.ImageList = this.imgAll;
            this.btnClose.Location = new System.Drawing.Point(219, 506);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(201, 53);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboVolumeUnit
            // 
            this.cboVolumeUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVolumeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVolumeUnit.Enabled = false;
            this.cboVolumeUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVolumeUnit.FormattingEnabled = true;
            this.cboVolumeUnit.Items.AddRange(new object[] {
            "ounces",
            "liters",
            "milliliters"});
            this.cboVolumeUnit.Location = new System.Drawing.Point(309, 348);
            this.cboVolumeUnit.Name = "cboVolumeUnit";
            this.cboVolumeUnit.Size = new System.Drawing.Size(107, 28);
            this.cboVolumeUnit.TabIndex = 56;
            this.cboVolumeUnit.SelectedIndexChanged += new System.EventHandler(this.cboValueChanged);
            // 
            // txtBoxVolume
            // 
            this.txtBoxVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxVolume.Enabled = false;
            this.txtBoxVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxVolume.Location = new System.Drawing.Point(174, 349);
            this.txtBoxVolume.Name = "txtBoxVolume";
            this.txtBoxVolume.Size = new System.Drawing.Size(129, 27);
            this.txtBoxVolume.TabIndex = 55;
            this.txtBoxVolume.TextChanged += new System.EventHandler(this.txtBoxValueChange);
            this.txtBoxVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxVolume_KeyPress);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(11, 356);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(70, 20);
            this.lblVolume.TabIndex = 54;
            this.lblVolume.Text = "Volume:";
            // 
            // txtBoxWhole
            // 
            this.txtBoxWhole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxWhole.Enabled = false;
            this.txtBoxWhole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWhole.Location = new System.Drawing.Point(174, 315);
            this.txtBoxWhole.Name = "txtBoxWhole";
            this.txtBoxWhole.Size = new System.Drawing.Size(129, 27);
            this.txtBoxWhole.TabIndex = 53;
            this.txtBoxWhole.TextChanged += new System.EventHandler(this.txtBoxValueChange);
            this.txtBoxWhole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxWhole_KeyPress);
            // 
            // cboWholeUnit
            // 
            this.cboWholeUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboWholeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWholeUnit.Enabled = false;
            this.cboWholeUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWholeUnit.FormattingEnabled = true;
            this.cboWholeUnit.Items.AddRange(new object[] {
            "sheets",
            "pieces"});
            this.cboWholeUnit.Location = new System.Drawing.Point(309, 314);
            this.cboWholeUnit.Name = "cboWholeUnit";
            this.cboWholeUnit.Size = new System.Drawing.Size(107, 28);
            this.cboWholeUnit.TabIndex = 52;
            this.cboWholeUnit.SelectedIndexChanged += new System.EventHandler(this.cboValueChanged);
            // 
            // lblWhole
            // 
            this.lblWhole.AutoSize = true;
            this.lblWhole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhole.Location = new System.Drawing.Point(11, 322);
            this.lblWhole.Name = "lblWhole";
            this.lblWhole.Size = new System.Drawing.Size(61, 20);
            this.lblWhole.TabIndex = 51;
            this.lblWhole.Text = "Whole:";
            // 
            // cboWeightUnit
            // 
            this.cboWeightUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboWeightUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWeightUnit.Enabled = false;
            this.cboWeightUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWeightUnit.FormattingEnabled = true;
            this.cboWeightUnit.Items.AddRange(new object[] {
            "ounce",
            "kilogram/s",
            "gram/s"});
            this.cboWeightUnit.Location = new System.Drawing.Point(309, 280);
            this.cboWeightUnit.Name = "cboWeightUnit";
            this.cboWeightUnit.Size = new System.Drawing.Size(107, 28);
            this.cboWeightUnit.TabIndex = 50;
            this.cboWeightUnit.SelectedIndexChanged += new System.EventHandler(this.cboValueChanged);
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxWeight.Enabled = false;
            this.txtBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWeight.Location = new System.Drawing.Point(173, 281);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.Size = new System.Drawing.Size(129, 27);
            this.txtBoxWeight.TabIndex = 49;
            this.txtBoxWeight.TextChanged += new System.EventHandler(this.txtBoxValueChange);
            this.txtBoxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxWeight_KeyPress);
            // 
            // lblX
            // 
            this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX.AutoSize = true;
            this.lblX.Enabled = false;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(226, 254);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 20);
            this.lblX.TabIndex = 48;
            this.lblX.Text = "X";
            // 
            // txtBoxAreaWidth
            // 
            this.txtBoxAreaWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAreaWidth.Enabled = false;
            this.txtBoxAreaWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAreaWidth.Location = new System.Drawing.Point(256, 247);
            this.txtBoxAreaWidth.Name = "txtBoxAreaWidth";
            this.txtBoxAreaWidth.Size = new System.Drawing.Size(47, 27);
            this.txtBoxAreaWidth.TabIndex = 47;
            this.txtBoxAreaWidth.TextChanged += new System.EventHandler(this.txtBoxValueChange);
            this.txtBoxAreaWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAreaWidth_KeyPress);
            // 
            // cboAreaUnit
            // 
            this.cboAreaUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAreaUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAreaUnit.Enabled = false;
            this.cboAreaUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAreaUnit.FormattingEnabled = true;
            this.cboAreaUnit.Items.AddRange(new object[] {
            "feet",
            "inches",
            "meters",
            "centimeters",
            "millimeters"});
            this.cboAreaUnit.Location = new System.Drawing.Point(309, 246);
            this.cboAreaUnit.Name = "cboAreaUnit";
            this.cboAreaUnit.Size = new System.Drawing.Size(107, 28);
            this.cboAreaUnit.TabIndex = 46;
            this.cboAreaUnit.SelectedIndexChanged += new System.EventHandler(this.cboValueChanged);
            // 
            // txtBoxAreaLength
            // 
            this.txtBoxAreaLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAreaLength.Enabled = false;
            this.txtBoxAreaLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAreaLength.Location = new System.Drawing.Point(173, 247);
            this.txtBoxAreaLength.Name = "txtBoxAreaLength";
            this.txtBoxAreaLength.Size = new System.Drawing.Size(47, 27);
            this.txtBoxAreaLength.TabIndex = 45;
            this.txtBoxAreaLength.TextChanged += new System.EventHandler(this.txtBoxValueChange);
            this.txtBoxAreaLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAreaLength_KeyPress);
            // 
            // cboLengthUnit
            // 
            this.cboLengthUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLengthUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLengthUnit.Enabled = false;
            this.cboLengthUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLengthUnit.FormattingEnabled = true;
            this.cboLengthUnit.Items.AddRange(new object[] {
            "feet",
            "inches",
            "meters",
            "centimeters",
            "millimeters"});
            this.cboLengthUnit.Location = new System.Drawing.Point(309, 213);
            this.cboLengthUnit.Name = "cboLengthUnit";
            this.cboLengthUnit.Size = new System.Drawing.Size(107, 28);
            this.cboLengthUnit.TabIndex = 44;
            this.cboLengthUnit.SelectedIndexChanged += new System.EventHandler(this.cboValueChanged);
            // 
            // txtBoxLength
            // 
            this.txtBoxLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxLength.Enabled = false;
            this.txtBoxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLength.Location = new System.Drawing.Point(173, 214);
            this.txtBoxLength.Name = "txtBoxLength";
            this.txtBoxLength.Size = new System.Drawing.Size(129, 27);
            this.txtBoxLength.TabIndex = 43;
            this.txtBoxLength.TextChanged += new System.EventHandler(this.txtBoxValueChange);
            this.txtBoxLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxLength_KeyPress);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(11, 288);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(66, 20);
            this.lblWeight.TabIndex = 40;
            this.lblWeight.Text = "Weight:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(11, 254);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(49, 20);
            this.lblArea.TabIndex = 42;
            this.lblArea.Text = "Area:";
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLength.Location = new System.Drawing.Point(10, 221);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(65, 20);
            this.lbLength.TabIndex = 41;
            this.lbLength.Text = "Length:";
            // 
            // lblTotalDamageCost
            // 
            this.lblTotalDamageCost.AutoSize = true;
            this.lblTotalDamageCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDamageCost.Location = new System.Drawing.Point(9, 457);
            this.lblTotalDamageCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDamageCost.Name = "lblTotalDamageCost";
            this.lblTotalDamageCost.Size = new System.Drawing.Size(159, 20);
            this.lblTotalDamageCost.TabIndex = 19;
            this.lblTotalDamageCost.Text = "Total Damage Cost:";
            // 
            // txtTotalDamageCost
            // 
            this.txtTotalDamageCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalDamageCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDamageCost.Location = new System.Drawing.Point(208, 450);
            this.txtTotalDamageCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalDamageCost.Name = "txtTotalDamageCost";
            this.txtTotalDamageCost.ReadOnly = true;
            this.txtTotalDamageCost.Size = new System.Drawing.Size(208, 27);
            this.txtTotalDamageCost.TabIndex = 18;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(11, 102);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(95, 20);
            this.lblItemName.TabIndex = 15;
            this.lblItemName.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(193, 95);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(222, 27);
            this.txtItemName.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(2, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(865, 6);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // imgAll
            // 
            this.imgAll.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgAll.ImageStream")));
            this.imgAll.TransparentColor = System.Drawing.Color.Transparent;
            this.imgAll.Images.SetKeyName(0, "iconfinder_068_Cancel_183197.png");
            this.imgAll.Images.SetKeyName(1, "iconfinder_199_CircledPlus_183316.png");
            this.imgAll.Images.SetKeyName(2, "iconfinder_ic_system_update_tv_48px_352158.png");
            this.imgAll.Images.SetKeyName(3, "iconfinder_folder-open-archive-document-archives_3643772.png");
            this.imgAll.Images.SetKeyName(4, "iconfinder_f-check_256_282474.png");
            this.imgAll.Images.SetKeyName(5, "stock out.png");
            this.imgAll.Images.SetKeyName(6, "iconfinder_sign-in_298868.png");
            // 
            // frmSupplyDamage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(890, 648);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSupplyDamage";
            this.Text = "Stock Out Damaged Supplies";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSupplyDamage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.gpStockOut.ResumeLayout(false);
            this.gpStockOut.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOut)).EndInit();
            this.gpStockOutDamageSupplies.ResumeLayout(false);
            this.gpStockOutDamageSupplies.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox gpStockOutDamageSupplies;
        private System.Windows.Forms.Label lblTotalDamageCost;
        public System.Windows.Forms.TextBox txtTotalDamageCost;
        private System.Windows.Forms.Label lblItemName;
        public System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnStockOutItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSupplyCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox gpStockOut;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblCalculatedStockedQuantity;
        public System.Windows.Forms.TextBox txtCalculatedStockedQuantity;
        private System.Windows.Forms.TextBox txtDamageReason;
        private System.Windows.Forms.Label lblDamageReason;
        public System.Windows.Forms.TextBox txtUnitMeasure;
        private System.Windows.Forms.Label lblUnitMeasure;
        public System.Windows.Forms.TextBox txtSupplyCategory;
        public System.Windows.Forms.ComboBox cboVolumeUnit;
        public System.Windows.Forms.TextBox txtBoxVolume;
        public System.Windows.Forms.Label lblVolume;
        public System.Windows.Forms.TextBox txtBoxWhole;
        public System.Windows.Forms.ComboBox cboWholeUnit;
        public System.Windows.Forms.Label lblWhole;
        public System.Windows.Forms.ComboBox cboWeightUnit;
        public System.Windows.Forms.TextBox txtBoxWeight;
        public System.Windows.Forms.Label lblX;
        public System.Windows.Forms.TextBox txtBoxAreaWidth;
        public System.Windows.Forms.ComboBox cboAreaUnit;
        public System.Windows.Forms.TextBox txtBoxAreaLength;
        public System.Windows.Forms.ComboBox cboLengthUnit;
        public System.Windows.Forms.TextBox txtBoxLength;
        public System.Windows.Forms.Label lblWeight;
        public System.Windows.Forms.Label lblArea;
        public System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.DataGridView dgvStockOut;
        private System.Windows.Forms.ImageList imgAll;
    }
}