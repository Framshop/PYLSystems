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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplyItems));
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
            this.txtReOrderPoint = new System.Windows.Forms.TextBox();
            this.lblReOrderPoint = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.cboVolume = new System.Windows.Forms.ComboBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.cboWhole = new System.Windows.Forms.ComboBox();
            this.lblWhole = new System.Windows.Forms.Label();
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
            this.gpButtons = new System.Windows.Forms.GroupBox();
            this.btnDamageItem = new System.Windows.Forms.Button();
            this.imgAll = new System.Windows.Forms.ImageList(this.components);
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
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(465, 13);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(115, 24);
            this.lblSearch.TabIndex = 28;
            this.lblSearch.Text = "Search Item:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(611, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(268, 29);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemDescription.Location = new System.Drawing.Point(114, 134);
            this.txtItemDescription.Multiline = true;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(184, 60);
            this.txtItemDescription.TabIndex = 5;
            this.txtItemDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(114, 91);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(184, 26);
            this.txtItemName.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(10, 137);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(103, 20);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description: *";
            // 
            // lblSupplyCategory
            // 
            this.lblSupplyCategory.AutoSize = true;
            this.lblSupplyCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplyCategory.Location = new System.Drawing.Point(10, 45);
            this.lblSupplyCategory.Name = "lblSupplyCategory";
            this.lblSupplyCategory.Size = new System.Drawing.Size(87, 40);
            this.lblSupplyCategory.TabIndex = 2;
            this.lblSupplyCategory.Text = " Supply \r\nCategory: *";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(12, 97);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(101, 20);
            this.lblItemName.TabIndex = 4;
            this.lblItemName.Text = "Item Name: *";
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
            this.cboSupplyCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSupplyCategory.FormattingEnabled = true;
            this.cboSupplyCategory.Location = new System.Drawing.Point(114, 45);
            this.cboSupplyCategory.Name = "cboSupplyCategory";
            this.cboSupplyCategory.Size = new System.Drawing.Size(184, 28);
            this.cboSupplyCategory.TabIndex = 1;
            this.cboSupplyCategory.SelectedIndexChanged += new System.EventHandler(this.cboSupplyCategory_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9857612F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.24754F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8762322F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(913, 749);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gpWhole, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.832298F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.08054F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.208054F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(892, 745);
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
            this.gpWhole.Size = new System.Drawing.Size(888, 46);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 52);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(888, 681);
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
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.96338F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.40361F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.76506F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(324, 677);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // gpMeasurements
            // 
            this.gpMeasurements.Controls.Add(this.txtReOrderPoint);
            this.gpMeasurements.Controls.Add(this.lblReOrderPoint);
            this.gpMeasurements.Controls.Add(this.txtVolume);
            this.gpMeasurements.Controls.Add(this.cboVolume);
            this.gpMeasurements.Controls.Add(this.lblVolume);
            this.gpMeasurements.Controls.Add(this.cboWhole);
            this.gpMeasurements.Controls.Add(this.lblWhole);
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
            this.gpMeasurements.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpMeasurements.Location = new System.Drawing.Point(2, 224);
            this.gpMeasurements.Margin = new System.Windows.Forms.Padding(2);
            this.gpMeasurements.Name = "gpMeasurements";
            this.gpMeasurements.Padding = new System.Windows.Forms.Padding(2);
            this.gpMeasurements.Size = new System.Drawing.Size(320, 255);
            this.gpMeasurements.TabIndex = 1;
            this.gpMeasurements.TabStop = false;
            this.gpMeasurements.Text = "Measurements";
            // 
            // txtReOrderPoint
            // 
            this.txtReOrderPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReOrderPoint.Location = new System.Drawing.Point(97, 210);
            this.txtReOrderPoint.Name = "txtReOrderPoint";
            this.txtReOrderPoint.Size = new System.Drawing.Size(211, 26);
            this.txtReOrderPoint.TabIndex = 27;
            this.txtReOrderPoint.TextChanged += new System.EventHandler(this.txtReOrderPoint_TextChanged);
            this.txtReOrderPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReOrderPoint_KeyPress);
            // 
            // lblReOrderPoint
            // 
            this.lblReOrderPoint.AutoSize = true;
            this.lblReOrderPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReOrderPoint.Location = new System.Drawing.Point(10, 210);
            this.lblReOrderPoint.Name = "lblReOrderPoint";
            this.lblReOrderPoint.Size = new System.Drawing.Size(79, 40);
            this.lblReOrderPoint.TabIndex = 26;
            this.lblReOrderPoint.Text = "Re-Order \r\nPoint: *";
            // 
            // txtVolume
            // 
            this.txtVolume.Enabled = false;
            this.txtVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(86, 129);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(129, 26);
            this.txtVolume.TabIndex = 25;
            this.txtVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVolume_KeyPress);
            // 
            // cboVolume
            // 
            this.cboVolume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVolume.Enabled = false;
            this.cboVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVolume.FormattingEnabled = true;
            this.cboVolume.ItemHeight = 20;
            this.cboVolume.Items.AddRange(new object[] {
            "ounces",
            "liters",
            "mililiters"});
            this.cboVolume.Location = new System.Drawing.Point(221, 127);
            this.cboVolume.Name = "cboVolume";
            this.cboVolume.Size = new System.Drawing.Size(87, 28);
            this.cboVolume.TabIndex = 24;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Enabled = false;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(12, 135);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(77, 20);
            this.lblVolume.TabIndex = 23;
            this.lblVolume.Text = "Volume: *";
            // 
            // cboWhole
            // 
            this.cboWhole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWhole.Enabled = false;
            this.cboWhole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWhole.FormattingEnabled = true;
            this.cboWhole.ItemHeight = 20;
            this.cboWhole.Items.AddRange(new object[] {
            "pieces",
            "sheets"});
            this.cboWhole.Location = new System.Drawing.Point(221, 161);
            this.cboWhole.Name = "cboWhole";
            this.cboWhole.Size = new System.Drawing.Size(87, 28);
            this.cboWhole.TabIndex = 20;
            this.cboWhole.SelectedIndexChanged += new System.EventHandler(this.cboWhole_SelectedIndexChanged);
            // 
            // lblWhole
            // 
            this.lblWhole.AutoSize = true;
            this.lblWhole.Enabled = false;
            this.lblWhole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhole.Location = new System.Drawing.Point(12, 169);
            this.lblWhole.Name = "lblWhole";
            this.lblWhole.Size = new System.Drawing.Size(68, 20);
            this.lblWhole.TabIndex = 20;
            this.lblWhole.Text = "Whole: *";
            // 
            // cboWeight
            // 
            this.cboWeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWeight.Enabled = false;
            this.cboWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWeight.FormattingEnabled = true;
            this.cboWeight.ItemHeight = 20;
            this.cboWeight.Items.AddRange(new object[] {
            "ounce",
            "kilogram/s",
            "gram/s"});
            this.cboWeight.Location = new System.Drawing.Point(221, 93);
            this.cboWeight.Name = "cboWeight";
            this.cboWeight.Size = new System.Drawing.Size(87, 28);
            this.cboWeight.TabIndex = 16;
            this.cboWeight.SelectedIndexChanged += new System.EventHandler(this.cboWeight_SelectedIndexChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Enabled = false;
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(86, 95);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(129, 26);
            this.txtWeight.TabIndex = 17;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Enabled = false;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(142, 68);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 20);
            this.lblX.TabIndex = 14;
            this.lblX.Text = "X";
            // 
            // txtArea2
            // 
            this.txtArea2.Enabled = false;
            this.txtArea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea2.Location = new System.Drawing.Point(168, 62);
            this.txtArea2.Name = "txtArea2";
            this.txtArea2.Size = new System.Drawing.Size(47, 26);
            this.txtArea2.TabIndex = 13;
            this.txtArea2.TextChanged += new System.EventHandler(this.txtArea2_TextChanged);
            this.txtArea2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArea2_KeyPress);
            // 
            // cboArea
            // 
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.Enabled = false;
            this.cboArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArea.FormattingEnabled = true;
            this.cboArea.ItemHeight = 20;
            this.cboArea.Items.AddRange(new object[] {
            "feet",
            "inches",
            "meters",
            "centimeters",
            "millimeters"});
            this.cboArea.Location = new System.Drawing.Point(221, 59);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(87, 28);
            this.cboArea.TabIndex = 12;
            this.cboArea.SelectedIndexChanged += new System.EventHandler(this.cboArea_SelectedIndexChanged);
            // 
            // txtArea1
            // 
            this.txtArea1.Enabled = false;
            this.txtArea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea1.Location = new System.Drawing.Point(86, 63);
            this.txtArea1.Name = "txtArea1";
            this.txtArea1.Size = new System.Drawing.Size(47, 26);
            this.txtArea1.TabIndex = 14;
            this.txtArea1.TextChanged += new System.EventHandler(this.txtArea1_TextChanged);
            this.txtArea1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArea1_KeyPress);
            // 
            // cboLength
            // 
            this.cboLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLength.Enabled = false;
            this.cboLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLength.FormattingEnabled = true;
            this.cboLength.Items.AddRange(new object[] {
            "feet",
            "inches",
            "meters",
            "centimeters",
            "millimeters"});
            this.cboLength.Location = new System.Drawing.Point(221, 25);
            this.cboLength.Name = "cboLength";
            this.cboLength.Size = new System.Drawing.Size(87, 28);
            this.cboLength.TabIndex = 9;
            this.cboLength.SelectedIndexChanged += new System.EventHandler(this.cboLength_SelectedIndexChanged);
            // 
            // txtLength
            // 
            this.txtLength.Enabled = false;
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(86, 27);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(129, 26);
            this.txtLength.TabIndex = 10;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLength_KeyPress);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Enabled = false;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(12, 101);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(73, 20);
            this.lblWeight.TabIndex = 18;
            this.lblWeight.Text = "Weight: *";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Enabled = false;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(12, 69);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(57, 20);
            this.lblArea.TabIndex = 15;
            this.lblArea.Text = "Area: *";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Enabled = false;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(12, 33);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(73, 20);
            this.lblLength.TabIndex = 11;
            this.lblLength.Text = "Length: *";
            // 
            // groupBox2
            // 
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
            this.groupBox2.Size = new System.Drawing.Size(320, 218);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supply Details";
            // 
            // gpButtons
            // 
            this.gpButtons.Controls.Add(this.btnDamageItem);
            this.gpButtons.Controls.Add(this.btnStockInSelectedItem);
            this.gpButtons.Controls.Add(this.btnUpdateDetails);
            this.gpButtons.Controls.Add(this.btnCreateItem);
            this.gpButtons.Controls.Add(this.btnClose);
            this.gpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpButtons.Location = new System.Drawing.Point(2, 483);
            this.gpButtons.Margin = new System.Windows.Forms.Padding(2);
            this.gpButtons.Name = "gpButtons";
            this.gpButtons.Padding = new System.Windows.Forms.Padding(2);
            this.gpButtons.Size = new System.Drawing.Size(320, 192);
            this.gpButtons.TabIndex = 2;
            this.gpButtons.TabStop = false;
            // 
            // btnDamageItem
            // 
            this.btnDamageItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDamageItem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDamageItem.Enabled = false;
            this.btnDamageItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDamageItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDamageItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDamageItem.ImageIndex = 5;
            this.btnDamageItem.ImageList = this.imgAll;
            this.btnDamageItem.Location = new System.Drawing.Point(4, 75);
            this.btnDamageItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnDamageItem.Name = "btnDamageItem";
            this.btnDamageItem.Size = new System.Drawing.Size(312, 33);
            this.btnDamageItem.TabIndex = 27;
            this.btnDamageItem.Text = "Stock Out as Damage Item";
            this.btnDamageItem.UseVisualStyleBackColor = false;
            this.btnDamageItem.Click += new System.EventHandler(this.btnDamageItem_Click);
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
            // btnStockInSelectedItem
            // 
            this.btnStockInSelectedItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStockInSelectedItem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnStockInSelectedItem.Enabled = false;
            this.btnStockInSelectedItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStockInSelectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockInSelectedItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockInSelectedItem.ImageIndex = 6;
            this.btnStockInSelectedItem.ImageList = this.imgAll;
            this.btnStockInSelectedItem.Location = new System.Drawing.Point(4, 38);
            this.btnStockInSelectedItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnStockInSelectedItem.Name = "btnStockInSelectedItem";
            this.btnStockInSelectedItem.Size = new System.Drawing.Size(312, 33);
            this.btnStockInSelectedItem.TabIndex = 25;
            this.btnStockInSelectedItem.Text = "Stock In Selected Item";
            this.btnStockInSelectedItem.UseVisualStyleBackColor = false;
            this.btnStockInSelectedItem.Click += new System.EventHandler(this.btnStockInSelectedItem_Click);
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateDetails.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUpdateDetails.Enabled = false;
            this.btnUpdateDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateDetails.ImageIndex = 2;
            this.btnUpdateDetails.ImageList = this.imgAll;
            this.btnUpdateDetails.Location = new System.Drawing.Point(4, 112);
            this.btnUpdateDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(312, 33);
            this.btnUpdateDetails.TabIndex = 24;
            this.btnUpdateDetails.Text = "Update Details";
            this.btnUpdateDetails.UseVisualStyleBackColor = false;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateItem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCreateItem.Enabled = false;
            this.btnCreateItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateItem.ImageIndex = 1;
            this.btnCreateItem.ImageList = this.imgAll;
            this.btnCreateItem.Location = new System.Drawing.Point(4, 3);
            this.btnCreateItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(312, 31);
            this.btnCreateItem.TabIndex = 23;
            this.btnCreateItem.Text = "Create Item";
            this.btnCreateItem.UseVisualStyleBackColor = false;
            this.btnCreateItem.Click += new System.EventHandler(this.btnCreateItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.PaleGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImageIndex = 0;
            this.btnClose.ImageList = this.imgAll;
            this.btnClose.Location = new System.Drawing.Point(4, 149);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(312, 33);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gpSupplyDetails
            // 
            this.gpSupplyDetails.Controls.Add(this.dgSupplyItems);
            this.gpSupplyDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpSupplyDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSupplyDetails.Location = new System.Drawing.Point(330, 2);
            this.gpSupplyDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gpSupplyDetails.Name = "gpSupplyDetails";
            this.gpSupplyDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gpSupplyDetails.Size = new System.Drawing.Size(556, 677);
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
            this.dgSupplyItems.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgSupplyItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSupplyItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSupplyItems.GridColor = System.Drawing.Color.White;
            this.dgSupplyItems.Location = new System.Drawing.Point(2, 30);
            this.dgSupplyItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgSupplyItems.Name = "dgSupplyItems";
            this.dgSupplyItems.ReadOnly = true;
            this.dgSupplyItems.RowHeadersVisible = false;
            this.dgSupplyItems.RowTemplate.Height = 28;
            this.dgSupplyItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSupplyItems.Size = new System.Drawing.Size(552, 645);
            this.dgSupplyItems.TabIndex = 29;
            this.dgSupplyItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSupplyItems_CellClick);
            this.dgSupplyItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSupplyItems_CellContentClick);
            // 
            // frmSupplyItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(913, 749);
            this.Controls.Add(this.lblSupplyItemsID);
            this.Controls.Add(this.lblValidate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSupplyItems";
            this.Text = "Supply Items";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSupplyItems_Load_1);
            this.Shown += new System.EventHandler(this.frmSupplyItems_Shown);
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
        private System.Windows.Forms.ComboBox cboWhole;
        private System.Windows.Forms.Label lblWhole;
        private System.Windows.Forms.Button btnDamageItem;
        private System.Windows.Forms.ComboBox cboVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtReOrderPoint;
        private System.Windows.Forms.Label lblReOrderPoint;
        private System.Windows.Forms.ImageList imgAll;
    }
}