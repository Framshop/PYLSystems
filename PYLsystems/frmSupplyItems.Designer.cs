namespace PYLsystems
{
    partial class frmSupplyItems
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSupplyCategory = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblValidate = new System.Windows.Forms.Label();
            this.lblSupplyItemsID = new System.Windows.Forms.Label();
            this.cboSupplyCategory = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gpWhole = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gpMeasurements = new System.Windows.Forms.GroupBox();
            this.cboWhole = new System.Windows.Forms.ComboBox();
            this.lblWhole = new System.Windows.Forms.Label();
            this.txtPurchaseUnitPrice = new System.Windows.Forms.TextBox();
            this.lblPurchaseUnitPrice = new System.Windows.Forms.Label();
            this.cboWeight = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.txtArea2 = new System.Windows.Forms.TextBox();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.txtArea1 = new System.Windows.Forms.TextBox();
            this.cboLength = new System.Windows.Forms.ComboBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboActive = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gpButtons = new System.Windows.Forms.GroupBox();
            this.btnStockInSelectedItem = new System.Windows.Forms.Button();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gpSupplyDetails = new System.Windows.Forms.GroupBox();
            this.dgSupplyItems = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gpWhole.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.gpMeasurements.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpButtons.SuspendLayout();
            this.gpSupplyDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplyItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(472, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 28;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(536, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(268, 20);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(103, 90);
            this.txtItemDescription.Multiline = true;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(184, 39);
            this.txtItemDescription.TabIndex = 5;
            this.txtItemDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(103, 51);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(184, 20);
            this.txtItemName.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(39, 92);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            // 
            // lblSupplyCategory
            // 
            this.lblSupplyCategory.AutoSize = true;
            this.lblSupplyCategory.Location = new System.Drawing.Point(12, 19);
            this.lblSupplyCategory.Name = "lblSupplyCategory";
            this.lblSupplyCategory.Size = new System.Drawing.Size(87, 13);
            this.lblSupplyCategory.TabIndex = 2;
            this.lblSupplyCategory.Text = "Supply Category:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(37, 58);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(61, 13);
            this.lblItemName.TabIndex = 4;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblValidate
            // 
            this.lblValidate.AutoSize = true;
            this.lblValidate.ForeColor = System.Drawing.Color.Red;
            this.lblValidate.Location = new System.Drawing.Point(127, 48);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(0, 13);
            this.lblValidate.TabIndex = 31;
            // 
            // lblSupplyItemsID
            // 
            this.lblSupplyItemsID.AutoSize = true;
            this.lblSupplyItemsID.Location = new System.Drawing.Point(471, 148);
            this.lblSupplyItemsID.Name = "lblSupplyItemsID";
            this.lblSupplyItemsID.Size = new System.Drawing.Size(0, 13);
            this.lblSupplyItemsID.TabIndex = 32;
            this.lblSupplyItemsID.Visible = false;
            // 
            // cboSupplyCategory
            // 
            this.cboSupplyCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplyCategory.FormattingEnabled = true;
            this.cboSupplyCategory.Location = new System.Drawing.Point(103, 18);
            this.cboSupplyCategory.Name = "cboSupplyCategory";
            this.cboSupplyCategory.Size = new System.Drawing.Size(184, 21);
            this.cboSupplyCategory.TabIndex = 1;
            this.cboSupplyCategory.SelectedIndexChanged += new System.EventHandler(this.cboSupplyCategory_SelectedIndexChanged);
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(913, 667);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gpWhole, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(47, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.832298F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.26915F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.898551F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(817, 663);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gpWhole
            // 
            this.gpWhole.Controls.Add(this.txtSearch);
            this.gpWhole.Controls.Add(this.lblSearch);
            this.gpWhole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpWhole.Location = new System.Drawing.Point(2, 2);
            this.gpWhole.Margin = new System.Windows.Forms.Padding(2);
            this.gpWhole.Name = "gpWhole";
            this.gpWhole.Padding = new System.Windows.Forms.Padding(2);
            this.gpWhole.Size = new System.Drawing.Size(813, 41);
            this.gpWhole.TabIndex = 0;
            this.gpWhole.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.99927F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.00073F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gpSupplyDetails, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 47);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(813, 594);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.gpMeasurements, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.gpButtons, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.96338F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.39734F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.5283F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(296, 590);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // gpMeasurements
            // 
            this.gpMeasurements.Controls.Add(this.cboWhole);
            this.gpMeasurements.Controls.Add(this.lblWhole);
            this.gpMeasurements.Controls.Add(this.txtPurchaseUnitPrice);
            this.gpMeasurements.Controls.Add(this.lblPurchaseUnitPrice);
            this.gpMeasurements.Controls.Add(this.cboWeight);
            this.gpMeasurements.Controls.Add(this.txtWeight);
            this.gpMeasurements.Controls.Add(this.lblX);
            this.gpMeasurements.Controls.Add(this.txtArea2);
            this.gpMeasurements.Controls.Add(this.cboArea);
            this.gpMeasurements.Controls.Add(this.txtArea1);
            this.gpMeasurements.Controls.Add(this.cboLength);
            this.gpMeasurements.Controls.Add(this.txtLength);
            this.gpMeasurements.Controls.Add(this.lblWeight);
            this.gpMeasurements.Controls.Add(this.lblArea);
            this.gpMeasurements.Controls.Add(this.lblLength);
            this.gpMeasurements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpMeasurements.Location = new System.Drawing.Point(2, 196);
            this.gpMeasurements.Margin = new System.Windows.Forms.Padding(2);
            this.gpMeasurements.Name = "gpMeasurements";
            this.gpMeasurements.Padding = new System.Windows.Forms.Padding(2);
            this.gpMeasurements.Size = new System.Drawing.Size(292, 246);
            this.gpMeasurements.TabIndex = 1;
            this.gpMeasurements.TabStop = false;
            this.gpMeasurements.Text = "Measurements";
            // 
            // cboWhole
            // 
            this.cboWhole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWhole.FormattingEnabled = true;
            this.cboWhole.ItemHeight = 13;
            this.cboWhole.Items.AddRange(new object[] {
            "pieces",
            "sheets"});
            this.cboWhole.Location = new System.Drawing.Point(221, 186);
            this.cboWhole.Name = "cboWhole";
            this.cboWhole.Size = new System.Drawing.Size(66, 21);
            this.cboWhole.TabIndex = 20;
            this.cboWhole.Visible = false;
            this.cboWhole.SelectedIndexChanged += new System.EventHandler(this.cboWhole_SelectedIndexChanged);
            // 
            // lblWhole
            // 
            this.lblWhole.AutoSize = true;
            this.lblWhole.Location = new System.Drawing.Point(45, 194);
            this.lblWhole.Name = "lblWhole";
            this.lblWhole.Size = new System.Drawing.Size(41, 13);
            this.lblWhole.TabIndex = 20;
            this.lblWhole.Text = "Whole:";
            this.lblWhole.Visible = false;
            // 
            // txtPurchaseUnitPrice
            // 
            this.txtPurchaseUnitPrice.Location = new System.Drawing.Point(129, 218);
            this.txtPurchaseUnitPrice.Name = "txtPurchaseUnitPrice";
            this.txtPurchaseUnitPrice.Size = new System.Drawing.Size(159, 20);
            this.txtPurchaseUnitPrice.TabIndex = 21;
            this.txtPurchaseUnitPrice.TextChanged += new System.EventHandler(this.txtPurchaseUnitPrice_TextChanged);
            this.txtPurchaseUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchaseUnitPrice_KeyPress);
            // 
            // lblPurchaseUnitPrice
            // 
            this.lblPurchaseUnitPrice.AutoSize = true;
            this.lblPurchaseUnitPrice.Location = new System.Drawing.Point(22, 218);
            this.lblPurchaseUnitPrice.Name = "lblPurchaseUnitPrice";
            this.lblPurchaseUnitPrice.Size = new System.Drawing.Size(104, 13);
            this.lblPurchaseUnitPrice.TabIndex = 22;
            this.lblPurchaseUnitPrice.Text = "Purchase Unit Price:";
            // 
            // cboWeight
            // 
            this.cboWeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWeight.FormattingEnabled = true;
            this.cboWeight.ItemHeight = 13;
            this.cboWeight.Items.AddRange(new object[] {
            "ounce",
            "kilogram/s",
            "gram/s"});
            this.cboWeight.Location = new System.Drawing.Point(221, 133);
            this.cboWeight.Name = "cboWeight";
            this.cboWeight.Size = new System.Drawing.Size(66, 21);
            this.cboWeight.TabIndex = 16;
            this.cboWeight.Visible = false;
            this.cboWeight.SelectedIndexChanged += new System.EventHandler(this.cboWeight_SelectedIndexChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(67, 135);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(129, 20);
            this.txtWeight.TabIndex = 17;
            this.txtWeight.Visible = false;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(126, 84);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 14;
            this.lblX.Text = "X";
            this.lblX.Visible = false;
            // 
            // txtArea2
            // 
            this.txtArea2.Location = new System.Drawing.Point(149, 83);
            this.txtArea2.Name = "txtArea2";
            this.txtArea2.Size = new System.Drawing.Size(47, 20);
            this.txtArea2.TabIndex = 13;
            this.txtArea2.Visible = false;
            this.txtArea2.TextChanged += new System.EventHandler(this.txtArea2_TextChanged);
            // 
            // cboArea
            // 
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.FormattingEnabled = true;
            this.cboArea.ItemHeight = 13;
            this.cboArea.Items.AddRange(new object[] {
            "feet",
            "inches",
            "meters",
            "centimeters",
            "millimeters"});
            this.cboArea.Location = new System.Drawing.Point(221, 81);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(66, 21);
            this.cboArea.TabIndex = 12;
            this.cboArea.Visible = false;
            this.cboArea.SelectedIndexChanged += new System.EventHandler(this.cboArea_SelectedIndexChanged);
            // 
            // txtArea1
            // 
            this.txtArea1.Location = new System.Drawing.Point(69, 83);
            this.txtArea1.Name = "txtArea1";
            this.txtArea1.Size = new System.Drawing.Size(47, 20);
            this.txtArea1.TabIndex = 14;
            this.txtArea1.Visible = false;
            this.txtArea1.TextChanged += new System.EventHandler(this.txtArea1_TextChanged);
            // 
            // cboLength
            // 
            this.cboLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLength.FormattingEnabled = true;
            this.cboLength.Items.AddRange(new object[] {
            "feet",
            "inches",
            "meters",
            "centimeters",
            "millimeters"});
            this.cboLength.Location = new System.Drawing.Point(221, 36);
            this.cboLength.Name = "cboLength";
            this.cboLength.Size = new System.Drawing.Size(66, 21);
            this.cboLength.TabIndex = 9;
            this.cboLength.Visible = false;
            this.cboLength.SelectedIndexChanged += new System.EventHandler(this.cboLength_SelectedIndexChanged);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(67, 38);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(129, 20);
            this.txtLength.TabIndex = 10;
            this.txtLength.Visible = false;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(45, 112);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(44, 13);
            this.lblWeight.TabIndex = 18;
            this.lblWeight.Text = "Weight:";
            this.lblWeight.Visible = false;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(53, 66);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 15;
            this.lblArea.Text = "Area:";
            this.lblArea.Visible = false;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(45, 19);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(43, 13);
            this.lblLength.TabIndex = 11;
            this.lblLength.Text = "Length:";
            this.lblLength.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboActive);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.cboSupplyCategory);
            this.groupBox2.Controls.Add(this.lblSupplyCategory);
            this.groupBox2.Controls.Add(this.txtItemName);
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Controls.Add(this.txtItemDescription);
            this.groupBox2.Controls.Add(this.lblItemName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(292, 190);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supply Details";
            // 
            // cboActive
            // 
            this.cboActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActive.FormattingEnabled = true;
            this.cboActive.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboActive.Location = new System.Drawing.Point(103, 155);
            this.cboActive.Name = "cboActive";
            this.cboActive.Size = new System.Drawing.Size(184, 21);
            this.cboActive.TabIndex = 7;
            this.cboActive.SelectedIndexChanged += new System.EventHandler(this.cboActive_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(58, 157);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status:";
            // 
            // gpButtons
            // 
            this.gpButtons.Controls.Add(this.btnStockInSelectedItem);
            this.gpButtons.Controls.Add(this.btnUpdateDetails);
            this.gpButtons.Controls.Add(this.btnCreateItem);
            this.gpButtons.Controls.Add(this.btnClose);
            this.gpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpButtons.Location = new System.Drawing.Point(2, 446);
            this.gpButtons.Margin = new System.Windows.Forms.Padding(2);
            this.gpButtons.Name = "gpButtons";
            this.gpButtons.Padding = new System.Windows.Forms.Padding(2);
            this.gpButtons.Size = new System.Drawing.Size(292, 142);
            this.gpButtons.TabIndex = 2;
            this.gpButtons.TabStop = false;
            // 
            // btnStockInSelectedItem
            // 
            this.btnStockInSelectedItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStockInSelectedItem.Enabled = false;
            this.btnStockInSelectedItem.Location = new System.Drawing.Point(78, 77);
            this.btnStockInSelectedItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnStockInSelectedItem.Name = "btnStockInSelectedItem";
            this.btnStockInSelectedItem.Size = new System.Drawing.Size(138, 24);
            this.btnStockInSelectedItem.TabIndex = 25;
            this.btnStockInSelectedItem.Text = "Stock In Selected Item";
            this.btnStockInSelectedItem.UseVisualStyleBackColor = true;
            this.btnStockInSelectedItem.Click += new System.EventHandler(this.btnStockInSelectedItem_Click);
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateDetails.Enabled = false;
            this.btnUpdateDetails.Location = new System.Drawing.Point(78, 49);
            this.btnUpdateDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(138, 24);
            this.btnUpdateDetails.TabIndex = 24;
            this.btnUpdateDetails.Text = "Update Details";
            this.btnUpdateDetails.UseVisualStyleBackColor = true;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateItem.Enabled = false;
            this.btnCreateItem.Location = new System.Drawing.Point(78, 21);
            this.btnCreateItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(138, 24);
            this.btnCreateItem.TabIndex = 23;
            this.btnCreateItem.Text = "Create Item";
            this.btnCreateItem.UseVisualStyleBackColor = true;
            this.btnCreateItem.Click += new System.EventHandler(this.btnCreateItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(78, 105);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 24);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gpSupplyDetails
            // 
            this.gpSupplyDetails.Controls.Add(this.dgSupplyItems);
            this.gpSupplyDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpSupplyDetails.Location = new System.Drawing.Point(302, 2);
            this.gpSupplyDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gpSupplyDetails.Name = "gpSupplyDetails";
            this.gpSupplyDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gpSupplyDetails.Size = new System.Drawing.Size(509, 590);
            this.gpSupplyDetails.TabIndex = 1;
            this.gpSupplyDetails.TabStop = false;
            this.gpSupplyDetails.Text = "Supply Items";
            // 
            // dgSupplyItems
            // 
            this.dgSupplyItems.AllowUserToAddRows = false;
            this.dgSupplyItems.AllowUserToDeleteRows = false;
            this.dgSupplyItems.AllowUserToResizeRows = false;
            this.dgSupplyItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSupplyItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSupplyItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSupplyItems.Location = new System.Drawing.Point(2, 15);
            this.dgSupplyItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgSupplyItems.Name = "dgSupplyItems";
            this.dgSupplyItems.ReadOnly = true;
            this.dgSupplyItems.RowHeadersVisible = false;
            this.dgSupplyItems.RowTemplate.Height = 28;
            this.dgSupplyItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSupplyItems.Size = new System.Drawing.Size(505, 573);
            this.dgSupplyItems.TabIndex = 29;
            this.dgSupplyItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSupplyItems_CellClick);
            this.dgSupplyItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSupplyItems_CellContentClick);
            // 
            // frmSupplyItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 667);
            this.Controls.Add(this.lblSupplyItemsID);
            this.Controls.Add(this.lblValidate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSupplyItems";
            this.Text = "Supply Items";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gpWhole.ResumeLayout(false);
            this.gpWhole.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.gpMeasurements.ResumeLayout(false);
            this.gpMeasurements.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpButtons.ResumeLayout(false);
            this.gpSupplyDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplyItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSupplyCategory;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblValidate;
        private System.Windows.Forms.Label lblSupplyItemsID;
        private System.Windows.Forms.ComboBox cboSupplyCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gpWhole;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox gpMeasurements;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gpButtons;
        private System.Windows.Forms.GroupBox gpSupplyDetails;
        private System.Windows.Forms.Button btnStockInSelectedItem;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.Button btnCreateItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.DataGridView dgSupplyItems;
        private System.Windows.Forms.ComboBox cboWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtArea2;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.TextBox txtArea1;
        private System.Windows.Forms.ComboBox cboLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtPurchaseUnitPrice;
        private System.Windows.Forms.Label lblPurchaseUnitPrice;
        private System.Windows.Forms.ComboBox cboActive;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboWhole;
        private System.Windows.Forms.Label lblWhole;
    }
}