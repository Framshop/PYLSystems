namespace PYLsystems
{
    partial class frmSupplier
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
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblSupplierDescription = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblValidate = new System.Windows.Forms.Label();
            this.msktxtContactNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlTaskBar = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gpListOfSuppliers = new System.Windows.Forms.GroupBox();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.gpSoldBySelectedSupplier = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.gpCategories = new System.Windows.Forms.GroupBox();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.gpItems = new System.Windows.Forms.GroupBox();
            this.dgvsupply_Items = new System.Windows.Forms.DataGridView();
            this.gpCreateSupplier = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.gpSupplierDetails = new System.Windows.Forms.GroupBox();
            this.gpItemSoldBySupplier = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvItemsSold = new System.Windows.Forms.DataGridView();
            this.gpButtonNewForm = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gpButtons = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlTaskBar.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.gpListOfSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.gpSoldBySelectedSupplier.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.gpCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.gpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsupply_Items)).BeginInit();
            this.gpCreateSupplier.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.gpSupplierDetails.SuspendLayout();
            this.gpItemSoldBySupplier.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsSold)).BeginInit();
            this.gpButtonNewForm.SuspendLayout();
            this.gpButtons.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(49, 19);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(76, 13);
            this.lblSupplierName.TabIndex = 2;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(41, 71);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 6;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblSupplierDescription
            // 
            this.lblSupplierDescription.AutoSize = true;
            this.lblSupplierDescription.Location = new System.Drawing.Point(23, 99);
            this.lblSupplierDescription.Name = "lblSupplierDescription";
            this.lblSupplierDescription.Size = new System.Drawing.Size(101, 13);
            this.lblSupplierDescription.TabIndex = 4;
            this.lblSupplierDescription.Text = "Supplier Description";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(143, 15);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(155, 20);
            this.txtSupplierName.TabIndex = 1;
            this.txtSupplierName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(143, 97);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(155, 88);
            this.txtDetails.TabIndex = 4;
            this.txtDetails.TextAlignChanged += new System.EventHandler(this.txtDetails_TextAlignChanged);
            this.txtDetails.TextChanged += new System.EventHandler(this.txtDetails_TextChanged);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Enabled = false;
            this.btnAddSupplier.Location = new System.Drawing.Point(53, 18);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(112, 24);
            this.btnAddSupplier.TabIndex = 7;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(185, 18);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 24);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(639, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(265, 20);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(552, 11);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(85, 13);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search Supplier:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(53, 49);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 24);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblValidate
            // 
            this.lblValidate.AutoSize = true;
            this.lblValidate.ForeColor = System.Drawing.Color.Red;
            this.lblValidate.Location = new System.Drawing.Point(111, 47);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(0, 13);
            this.lblValidate.TabIndex = 16;
            // 
            // msktxtContactNumber
            // 
            this.msktxtContactNumber.Location = new System.Drawing.Point(143, 70);
            this.msktxtContactNumber.Name = "msktxtContactNumber";
            this.msktxtContactNumber.PromptChar = ' ';
            this.msktxtContactNumber.Size = new System.Drawing.Size(155, 20);
            this.msktxtContactNumber.TabIndex = 3;
            this.msktxtContactNumber.TextChanged += new System.EventHandler(this.msktxtContactNumber_TextChanged);
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Enabled = false;
            this.lblSupplierID.Location = new System.Drawing.Point(111, 15);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(0, 13);
            this.lblSupplierID.TabIndex = 18;
            this.lblSupplierID.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(79, 43);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 19;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(143, 41);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(155, 20);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.tlTaskBar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(913, 682);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // tlTaskBar
            // 
            this.tlTaskBar.ColumnCount = 1;
            this.tlTaskBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlTaskBar.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tlTaskBar.Controls.Add(this.groupBox10, 0, 0);
            this.tlTaskBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlTaskBar.Location = new System.Drawing.Point(47, 2);
            this.tlTaskBar.Margin = new System.Windows.Forms.Padding(2);
            this.tlTaskBar.Name = "tlTaskBar";
            this.tlTaskBar.RowCount = 3;
            this.tlTaskBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlTaskBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlTaskBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlTaskBar.Size = new System.Drawing.Size(817, 678);
            this.tlTaskBar.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.07274F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.92726F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.gpCreateSupplier, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 35);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(813, 606);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.gpListOfSuppliers, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.gpSoldBySelectedSupplier, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(335, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.97619F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.02381F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(476, 602);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // gpListOfSuppliers
            // 
            this.gpListOfSuppliers.Controls.Add(this.dgvSuppliers);
            this.gpListOfSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpListOfSuppliers.Location = new System.Drawing.Point(2, 2);
            this.gpListOfSuppliers.Margin = new System.Windows.Forms.Padding(2);
            this.gpListOfSuppliers.Name = "gpListOfSuppliers";
            this.gpListOfSuppliers.Padding = new System.Windows.Forms.Padding(2);
            this.gpListOfSuppliers.Size = new System.Drawing.Size(472, 194);
            this.gpListOfSuppliers.TabIndex = 0;
            this.gpListOfSuppliers.TabStop = false;
            this.gpListOfSuppliers.Text = "List of Suppliers";
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToResizeRows = false;
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuppliers.Location = new System.Drawing.Point(2, 15);
            this.dgvSuppliers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersVisible = false;
            this.dgvSuppliers.RowTemplate.Height = 28;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(468, 177);
            this.dgvSuppliers.TabIndex = 1;
            this.dgvSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellClick);
            // 
            // gpSoldBySelectedSupplier
            // 
            this.gpSoldBySelectedSupplier.Controls.Add(this.tableLayoutPanel5);
            this.gpSoldBySelectedSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpSoldBySelectedSupplier.Location = new System.Drawing.Point(2, 200);
            this.gpSoldBySelectedSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.gpSoldBySelectedSupplier.Name = "gpSoldBySelectedSupplier";
            this.gpSoldBySelectedSupplier.Padding = new System.Windows.Forms.Padding(2);
            this.gpSoldBySelectedSupplier.Size = new System.Drawing.Size(472, 400);
            this.gpSoldBySelectedSupplier.TabIndex = 1;
            this.gpSoldBySelectedSupplier.TabStop = false;
            this.gpSoldBySelectedSupplier.Text = "Sold by Selected Supplier";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.26152F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.73848F));
            this.tableLayoutPanel5.Controls.Add(this.gpCategories, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.gpItems, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(468, 383);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // gpCategories
            // 
            this.gpCategories.Controls.Add(this.dgvCategories);
            this.gpCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpCategories.Location = new System.Drawing.Point(2, 2);
            this.gpCategories.Margin = new System.Windows.Forms.Padding(2);
            this.gpCategories.Name = "gpCategories";
            this.gpCategories.Padding = new System.Windows.Forms.Padding(2);
            this.gpCategories.Size = new System.Drawing.Size(137, 379);
            this.gpCategories.TabIndex = 0;
            this.gpCategories.TabStop = false;
            this.gpCategories.Text = "Categories";
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AllowUserToResizeRows = false;
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategories.Location = new System.Drawing.Point(2, 15);
            this.dgvCategories.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.RowTemplate.Height = 28;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.Size = new System.Drawing.Size(133, 362);
            this.dgvCategories.TabIndex = 1;
            this.dgvCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellClick);
            // 
            // gpItems
            // 
            this.gpItems.Controls.Add(this.dgvsupply_Items);
            this.gpItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpItems.Location = new System.Drawing.Point(143, 2);
            this.gpItems.Margin = new System.Windows.Forms.Padding(2);
            this.gpItems.Name = "gpItems";
            this.gpItems.Padding = new System.Windows.Forms.Padding(2);
            this.gpItems.Size = new System.Drawing.Size(323, 379);
            this.gpItems.TabIndex = 1;
            this.gpItems.TabStop = false;
            this.gpItems.Text = "Items";
            // 
            // dgvsupply_Items
            // 
            this.dgvsupply_Items.AllowUserToAddRows = false;
            this.dgvsupply_Items.AllowUserToDeleteRows = false;
            this.dgvsupply_Items.AllowUserToResizeRows = false;
            this.dgvsupply_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsupply_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsupply_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsupply_Items.Location = new System.Drawing.Point(2, 15);
            this.dgvsupply_Items.Margin = new System.Windows.Forms.Padding(2);
            this.dgvsupply_Items.Name = "dgvsupply_Items";
            this.dgvsupply_Items.ReadOnly = true;
            this.dgvsupply_Items.RowHeadersVisible = false;
            this.dgvsupply_Items.RowTemplate.Height = 28;
            this.dgvsupply_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsupply_Items.Size = new System.Drawing.Size(319, 362);
            this.dgvsupply_Items.TabIndex = 1;
            // 
            // gpCreateSupplier
            // 
            this.gpCreateSupplier.Controls.Add(this.tableLayoutPanel6);
            this.gpCreateSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpCreateSupplier.Location = new System.Drawing.Point(2, 2);
            this.gpCreateSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.gpCreateSupplier.Name = "gpCreateSupplier";
            this.gpCreateSupplier.Padding = new System.Windows.Forms.Padding(2);
            this.gpCreateSupplier.Size = new System.Drawing.Size(329, 602);
            this.gpCreateSupplier.TabIndex = 1;
            this.gpCreateSupplier.TabStop = false;
            this.gpCreateSupplier.Text = "Create Supplier";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.gpSupplierDetails, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.gpItemSoldBySupplier, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.gpButtons, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.27778F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.06565F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78283F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(325, 585);
            this.tableLayoutPanel6.TabIndex = 20;
            // 
            // gpSupplierDetails
            // 
            this.gpSupplierDetails.Controls.Add(this.lblAddress);
            this.gpSupplierDetails.Controls.Add(this.txtDetails);
            this.gpSupplierDetails.Controls.Add(this.txtAddress);
            this.gpSupplierDetails.Controls.Add(this.lblSupplierName);
            this.gpSupplierDetails.Controls.Add(this.msktxtContactNumber);
            this.gpSupplierDetails.Controls.Add(this.txtSupplierName);
            this.gpSupplierDetails.Controls.Add(this.lblSupplierDescription);
            this.gpSupplierDetails.Controls.Add(this.lblContactNumber);
            this.gpSupplierDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpSupplierDetails.Location = new System.Drawing.Point(2, 2);
            this.gpSupplierDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gpSupplierDetails.Name = "gpSupplierDetails";
            this.gpSupplierDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gpSupplierDetails.Size = new System.Drawing.Size(321, 231);
            this.gpSupplierDetails.TabIndex = 0;
            this.gpSupplierDetails.TabStop = false;
            this.gpSupplierDetails.Text = "SupplierDetails";
            // 
            // gpItemSoldBySupplier
            // 
            this.gpItemSoldBySupplier.Controls.Add(this.tableLayoutPanel7);
            this.gpItemSoldBySupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpItemSoldBySupplier.Location = new System.Drawing.Point(2, 237);
            this.gpItemSoldBySupplier.Margin = new System.Windows.Forms.Padding(2);
            this.gpItemSoldBySupplier.Name = "gpItemSoldBySupplier";
            this.gpItemSoldBySupplier.Padding = new System.Windows.Forms.Padding(2);
            this.gpItemSoldBySupplier.Size = new System.Drawing.Size(321, 253);
            this.gpItemSoldBySupplier.TabIndex = 1;
            this.gpItemSoldBySupplier.TabStop = false;
            this.gpItemSoldBySupplier.Text = "Items Sold by Supplier";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.dgvItemsSold, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.gpButtonNewForm, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.02524F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.97476F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(317, 236);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // dgvItemsSold
            // 
            this.dgvItemsSold.AllowUserToAddRows = false;
            this.dgvItemsSold.AllowUserToDeleteRows = false;
            this.dgvItemsSold.AllowUserToResizeRows = false;
            this.dgvItemsSold.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemsSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsSold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemsSold.Location = new System.Drawing.Point(2, 2);
            this.dgvItemsSold.Margin = new System.Windows.Forms.Padding(2);
            this.dgvItemsSold.Name = "dgvItemsSold";
            this.dgvItemsSold.ReadOnly = true;
            this.dgvItemsSold.RowHeadersVisible = false;
            this.dgvItemsSold.RowTemplate.Height = 28;
            this.dgvItemsSold.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsSold.Size = new System.Drawing.Size(313, 175);
            this.dgvItemsSold.TabIndex = 2;
            // 
            // gpButtonNewForm
            // 
            this.gpButtonNewForm.Controls.Add(this.btnDelete);
            this.gpButtonNewForm.Controls.Add(this.btnAdd);
            this.gpButtonNewForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpButtonNewForm.Location = new System.Drawing.Point(2, 181);
            this.gpButtonNewForm.Margin = new System.Windows.Forms.Padding(2);
            this.gpButtonNewForm.Name = "gpButtonNewForm";
            this.gpButtonNewForm.Padding = new System.Windows.Forms.Padding(2);
            this.gpButtonNewForm.Size = new System.Drawing.Size(313, 53);
            this.gpButtonNewForm.TabIndex = 0;
            this.gpButtonNewForm.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(199, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 24);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(67, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 24);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gpButtons
            // 
            this.gpButtons.Controls.Add(this.btnAddSupplier);
            this.gpButtons.Controls.Add(this.btnCancel);
            this.gpButtons.Controls.Add(this.btnUpdate);
            this.gpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpButtons.Location = new System.Drawing.Point(2, 494);
            this.gpButtons.Margin = new System.Windows.Forms.Padding(2);
            this.gpButtons.Name = "gpButtons";
            this.gpButtons.Padding = new System.Windows.Forms.Padding(2);
            this.gpButtons.Size = new System.Drawing.Size(321, 89);
            this.gpButtons.TabIndex = 2;
            this.gpButtons.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblSearch);
            this.groupBox10.Controls.Add(this.txtSearch);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(2, 2);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox10.Size = new System.Drawing.Size(813, 29);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 682);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.lblValidate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSupplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlTaskBar.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.gpListOfSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.gpSoldBySelectedSupplier.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.gpCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.gpItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsupply_Items)).EndInit();
            this.gpCreateSupplier.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.gpSupplierDetails.ResumeLayout(false);
            this.gpSupplierDetails.PerformLayout();
            this.gpItemSoldBySupplier.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsSold)).EndInit();
            this.gpButtonNewForm.ResumeLayout(false);
            this.gpButtons.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblSupplierDescription;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblValidate;
        private System.Windows.Forms.MaskedTextBox msktxtContactNumber;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlTaskBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox gpListOfSuppliers;
        private System.Windows.Forms.GroupBox gpSoldBySelectedSupplier;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox gpCategories;
        private System.Windows.Forms.GroupBox gpItems;
        private System.Windows.Forms.GroupBox gpCreateSupplier;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.DataGridView dgvsupply_Items;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox gpSupplierDetails;
        private System.Windows.Forms.GroupBox gpItemSoldBySupplier;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.DataGridView dgvItemsSold;
        private System.Windows.Forms.GroupBox gpButtonNewForm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gpButtons;
        private System.Windows.Forms.GroupBox groupBox10;
    }
}