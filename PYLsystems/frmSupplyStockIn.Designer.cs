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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplyStockIn));
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
            this.imgAll = new System.Windows.Forms.ImageList(this.components);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.533406F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.69989F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8762322F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(913, 613);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblsupply_itemsID, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.477833F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.04433F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.477833F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(887, 609);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.38745F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.61255F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 11);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(883, 586);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.88889F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.84563F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.41509F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(396, 582);
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
            this.gpSupply.Location = new System.Drawing.Point(2, 2);
            this.gpSupply.Margin = new System.Windows.Forms.Padding(2);
            this.gpSupply.Name = "gpSupply";
            this.gpSupply.Padding = new System.Windows.Forms.Padding(2);
            this.gpSupply.Size = new System.Drawing.Size(392, 251);
            this.gpSupply.TabIndex = 0;
            this.gpSupply.TabStop = false;
            this.gpSupply.Text = "Supply";
            // 
            // lblActualPurchasePrice
            // 
            this.lblActualPurchasePrice.AutoSize = true;
            this.lblActualPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualPurchasePrice.Location = new System.Drawing.Point(4, 170);
            this.lblActualPurchasePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActualPurchasePrice.Name = "lblActualPurchasePrice";
            this.lblActualPurchasePrice.Size = new System.Drawing.Size(191, 58);
            this.lblActualPurchasePrice.TabIndex = 13;
            this.lblActualPurchasePrice.Text = "Actual Purchase \r\nPrice:";
            // 
            // txtActualPurchasePrice
            // 
            this.txtActualPurchasePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualPurchasePrice.Location = new System.Drawing.Point(199, 170);
            this.txtActualPurchasePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualPurchasePrice.Name = "txtActualPurchasePrice";
            this.txtActualPurchasePrice.ReadOnly = true;
            this.txtActualPurchasePrice.Size = new System.Drawing.Size(184, 35);
            this.txtActualPurchasePrice.TabIndex = 12;
            this.txtActualPurchasePrice.TextChanged += new System.EventHandler(this.txtActualPurchasePrice_TextChanged);
            this.txtActualPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // lblRawPurchasePrice
            // 
            this.lblRawPurchasePrice.AutoSize = true;
            this.lblRawPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRawPurchasePrice.Location = new System.Drawing.Point(4, 137);
            this.lblRawPurchasePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRawPurchasePrice.Name = "lblRawPurchasePrice";
            this.lblRawPurchasePrice.Size = new System.Drawing.Size(178, 25);
            this.lblRawPurchasePrice.TabIndex = 11;
            this.lblRawPurchasePrice.Text = "Purchase Price: *";
            // 
            // txtRawPurchasePrice
            // 
            this.txtRawPurchasePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRawPurchasePrice.Location = new System.Drawing.Point(199, 131);
            this.txtRawPurchasePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtRawPurchasePrice.Name = "txtRawPurchasePrice";
            this.txtRawPurchasePrice.Size = new System.Drawing.Size(184, 35);
            this.txtRawPurchasePrice.TabIndex = 10;
            this.txtRawPurchasePrice.Text = "0";
            this.txtRawPurchasePrice.TextChanged += new System.EventHandler(this.txtRawPurchasePrice_TextChanged);
            this.txtRawPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRawPurchasePrice_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(4, 98);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(122, 29);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity: *";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Location = new System.Drawing.Point(199, 92);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(184, 35);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.Text = "0";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(4, 59);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(136, 29);
            this.lblItemName.TabIndex = 7;
            this.lblItemName.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemName.Location = new System.Drawing.Point(199, 53);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(184, 35);
            this.txtItemName.TabIndex = 6;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // gpSelectSupplier
            // 
            this.gpSelectSupplier.Controls.Add(this.dgvSupplier);
            this.gpSelectSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpSelectSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSelectSupplier.Location = new System.Drawing.Point(2, 257);
            this.gpSelectSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.gpSelectSupplier.Name = "gpSelectSupplier";
            this.gpSelectSupplier.Padding = new System.Windows.Forms.Padding(2);
            this.gpSelectSupplier.Size = new System.Drawing.Size(392, 169);
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
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.White;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupplier.GridColor = System.Drawing.Color.White;
            this.dgvSupplier.Location = new System.Drawing.Point(2, 30);
            this.dgvSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowHeadersVisible = false;
            this.dgvSupplier.RowTemplate.Height = 28;
            this.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplier.Size = new System.Drawing.Size(388, 137);
            this.dgvSupplier.TabIndex = 3;
            this.dgvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEditDetails);
            this.groupBox3.Controls.Add(this.btnStockInItem);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(2, 430);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(392, 150);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDetails.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEditDetails.Enabled = false;
            this.btnEditDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDetails.ImageIndex = 2;
            this.btnEditDetails.ImageList = this.imgAll;
            this.btnEditDetails.Location = new System.Drawing.Point(67, 53);
            this.btnEditDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(268, 45);
            this.btnEditDetails.TabIndex = 36;
            this.btnEditDetails.Text = "Edit Details";
            this.btnEditDetails.UseVisualStyleBackColor = false;
            this.btnEditDetails.Click += new System.EventHandler(this.btnEditDetails_Click);
            // 
            // imgAll
            // 
            this.imgAll.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgAll.ImageStream")));
            this.imgAll.TransparentColor = System.Drawing.Color.Transparent;
            this.imgAll.Images.SetKeyName(0, "iconfinder_068_Cancel_183197.png");
            this.imgAll.Images.SetKeyName(1, "iconfinder_199_CircledPlus_183316.png");
            this.imgAll.Images.SetKeyName(2, "iconfinder_ic_system_update_tv_48px_352158.png");
            this.imgAll.Images.SetKeyName(3, "iconfinder_OUTLINE_Bussiness_and_Media-01_4041192.png");
            this.imgAll.Images.SetKeyName(4, "iconfinder_kthememgr_6507.png");
            this.imgAll.Images.SetKeyName(5, "iconfinder_14_4157084.png");
            this.imgAll.Images.SetKeyName(6, "iconfinder_729_Business_career_employee_entrepreneur_leader_Business_Management_4" +
        "178944.png");
            this.imgAll.Images.SetKeyName(7, "iconfinder_folder-open-archive-document-archives_3643772.png");
            this.imgAll.Images.SetKeyName(8, "iconfinder_f-check_256_282474.png");
            // 
            // btnStockInItem
            // 
            this.btnStockInItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStockInItem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnStockInItem.Enabled = false;
            this.btnStockInItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStockInItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockInItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockInItem.ImageIndex = 1;
            this.btnStockInItem.ImageList = this.imgAll;
            this.btnStockInItem.Location = new System.Drawing.Point(67, 4);
            this.btnStockInItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnStockInItem.Name = "btnStockInItem";
            this.btnStockInItem.Size = new System.Drawing.Size(268, 45);
            this.btnStockInItem.TabIndex = 35;
            this.btnStockInItem.Text = "Stock In Item";
            this.btnStockInItem.UseVisualStyleBackColor = false;
            this.btnStockInItem.Click += new System.EventHandler(this.btnStockInItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.PaleGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImageIndex = 0;
            this.btnClose.ImageList = this.imgAll;
            this.btnClose.Location = new System.Drawing.Point(67, 102);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(268, 45);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.gpStockIn, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(402, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.07407F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.92593F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(479, 582);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // gpStockIn
            // 
            this.gpStockIn.Controls.Add(this.lblEndDate);
            this.gpStockIn.Controls.Add(this.lblStartDate);
            this.gpStockIn.Controls.Add(this.endDatePicker);
            this.gpStockIn.Controls.Add(this.startDatePicker);
            this.gpStockIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpStockIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpStockIn.Location = new System.Drawing.Point(2, 2);
            this.gpStockIn.Margin = new System.Windows.Forms.Padding(2);
            this.gpStockIn.Name = "gpStockIn";
            this.gpStockIn.Padding = new System.Windows.Forms.Padding(2);
            this.gpStockIn.Size = new System.Drawing.Size(475, 194);
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
            this.lblEndDate.Location = new System.Drawing.Point(10, 117);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(118, 29);
            this.lblEndDate.TabIndex = 22;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(10, 68);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(124, 29);
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
            this.endDatePicker.Location = new System.Drawing.Point(184, 111);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(243, 35);
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
            this.startDatePicker.Location = new System.Drawing.Point(184, 62);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(243, 35);
            this.startDatePicker.TabIndex = 19;
            this.startDatePicker.Value = new System.DateTime(2019, 1, 4, 0, 0, 0, 0);
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvStockIn);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(2, 200);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(475, 380);
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
            this.dgvStockIn.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockIn.GridColor = System.Drawing.Color.White;
            this.dgvStockIn.Location = new System.Drawing.Point(2, 30);
            this.dgvStockIn.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStockIn.Name = "dgvStockIn";
            this.dgvStockIn.ReadOnly = true;
            this.dgvStockIn.RowHeadersVisible = false;
            this.dgvStockIn.RowTemplate.Height = 28;
            this.dgvStockIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockIn.Size = new System.Drawing.Size(471, 348);
            this.dgvStockIn.TabIndex = 4;
            this.dgvStockIn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockIn_CellClick);
            // 
            // lblsupply_itemsID
            // 
            this.lblsupply_itemsID.AutoSize = true;
            this.lblsupply_itemsID.Location = new System.Drawing.Point(3, 0);
            this.lblsupply_itemsID.Name = "lblsupply_itemsID";
            this.lblsupply_itemsID.Size = new System.Drawing.Size(0, 9);
            this.lblsupply_itemsID.TabIndex = 1;
            // 
            // frmSupplyStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(913, 613);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSupplyStockIn";
            this.Text = "Supply Stock In";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ImageList imgAll;
    }
}