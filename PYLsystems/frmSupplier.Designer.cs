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
            this.lblsupply_categoryID = new System.Windows.Forms.Label();
            this.gpItemSoldBySupplier = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.gpButtonNewForm = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvwItemSold = new System.Windows.Forms.ListView();
            this.lvwSupply_Items_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwSupply_Category_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwCategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwSupplyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpButtons = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
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
            this.gpButtonNewForm.SuspendLayout();
            this.gpButtons.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(74, 29);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(113, 20);
            this.lblSupplierName.TabIndex = 2;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(62, 109);
            this.lblContactNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(125, 20);
            this.lblContactNumber.TabIndex = 6;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblSupplierDescription
            // 
            this.lblSupplierDescription.AutoSize = true;
            this.lblSupplierDescription.Location = new System.Drawing.Point(34, 152);
            this.lblSupplierDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierDescription.Name = "lblSupplierDescription";
            this.lblSupplierDescription.Size = new System.Drawing.Size(151, 20);
            this.lblSupplierDescription.TabIndex = 4;
            this.lblSupplierDescription.Text = "Supplier Description";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(214, 23);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(230, 26);
            this.txtSupplierName.TabIndex = 1;
            this.txtSupplierName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(214, 149);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(230, 133);
            this.txtDetails.TabIndex = 4;
            this.txtDetails.TextAlignChanged += new System.EventHandler(this.txtDetails_TextAlignChanged);
            this.txtDetails.TextChanged += new System.EventHandler(this.txtDetails_TextChanged);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Enabled = false;
            this.btnAddSupplier.Location = new System.Drawing.Point(80, 28);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(168, 37);
            this.btnAddSupplier.TabIndex = 7;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(278, 28);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 37);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(958, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(396, 26);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(828, 17);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(126, 20);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search Supplier:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(80, 75);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 37);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblValidate
            // 
            this.lblValidate.AutoSize = true;
            this.lblValidate.ForeColor = System.Drawing.Color.Red;
            this.lblValidate.Location = new System.Drawing.Point(166, 72);
            this.lblValidate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(0, 20);
            this.lblValidate.TabIndex = 16;
            // 
            // msktxtContactNumber
            // 
            this.msktxtContactNumber.Location = new System.Drawing.Point(214, 108);
            this.msktxtContactNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.msktxtContactNumber.Name = "msktxtContactNumber";
            this.msktxtContactNumber.PromptChar = ' ';
            this.msktxtContactNumber.Size = new System.Drawing.Size(230, 26);
            this.msktxtContactNumber.TabIndex = 3;
            this.msktxtContactNumber.TextChanged += new System.EventHandler(this.msktxtContactNumber_TextChanged);
            this.msktxtContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msktxtContactNumber_KeyPress);
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Enabled = false;
            this.lblSupplierID.Location = new System.Drawing.Point(166, 23);
            this.lblSupplierID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(0, 20);
            this.lblSupplierID.TabIndex = 18;
            this.lblSupplierID.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(118, 66);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 19;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(214, 63);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(230, 26);
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 1049);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // tlTaskBar
            // 
            this.tlTaskBar.ColumnCount = 1;
            this.tlTaskBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlTaskBar.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tlTaskBar.Controls.Add(this.groupBox10, 0, 0);
            this.tlTaskBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlTaskBar.Location = new System.Drawing.Point(71, 3);
            this.tlTaskBar.Name = "tlTaskBar";
            this.tlTaskBar.RowCount = 3;
            this.tlTaskBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlTaskBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlTaskBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlTaskBar.Size = new System.Drawing.Size(1227, 1043);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1221, 932);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.gpListOfSuppliers, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.gpSoldBySelectedSupplier, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(504, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.97619F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.02381F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(714, 926);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // gpListOfSuppliers
            // 
            this.gpListOfSuppliers.Controls.Add(this.dgvSuppliers);
            this.gpListOfSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpListOfSuppliers.Location = new System.Drawing.Point(3, 3);
            this.gpListOfSuppliers.Name = "gpListOfSuppliers";
            this.gpListOfSuppliers.Size = new System.Drawing.Size(708, 299);
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
            this.dgvSuppliers.Location = new System.Drawing.Point(3, 22);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersVisible = false;
            this.dgvSuppliers.RowTemplate.Height = 28;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(702, 274);
            this.dgvSuppliers.TabIndex = 1;
            this.dgvSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellClick);
            this.dgvSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellContentClick);
            // 
            // gpSoldBySelectedSupplier
            // 
            this.gpSoldBySelectedSupplier.Controls.Add(this.tableLayoutPanel5);
            this.gpSoldBySelectedSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpSoldBySelectedSupplier.Location = new System.Drawing.Point(3, 308);
            this.gpSoldBySelectedSupplier.Name = "gpSoldBySelectedSupplier";
            this.gpSoldBySelectedSupplier.Size = new System.Drawing.Size(708, 615);
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
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(702, 590);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // gpCategories
            // 
            this.gpCategories.Controls.Add(this.dgvCategories);
            this.gpCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpCategories.Location = new System.Drawing.Point(3, 3);
            this.gpCategories.Name = "gpCategories";
            this.gpCategories.Size = new System.Drawing.Size(206, 584);
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
            this.dgvCategories.Location = new System.Drawing.Point(3, 22);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.RowTemplate.Height = 28;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.Size = new System.Drawing.Size(200, 559);
            this.dgvCategories.TabIndex = 1;
            this.dgvCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellClick);
            // 
            // gpItems
            // 
            this.gpItems.Controls.Add(this.dgvsupply_Items);
            this.gpItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpItems.Location = new System.Drawing.Point(215, 3);
            this.gpItems.Name = "gpItems";
            this.gpItems.Size = new System.Drawing.Size(484, 584);
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
            this.dgvsupply_Items.Location = new System.Drawing.Point(3, 22);
            this.dgvsupply_Items.Name = "dgvsupply_Items";
            this.dgvsupply_Items.ReadOnly = true;
            this.dgvsupply_Items.RowHeadersVisible = false;
            this.dgvsupply_Items.RowTemplate.Height = 28;
            this.dgvsupply_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsupply_Items.Size = new System.Drawing.Size(478, 559);
            this.dgvsupply_Items.TabIndex = 1;
            // 
            // gpCreateSupplier
            // 
            this.gpCreateSupplier.Controls.Add(this.tableLayoutPanel6);
            this.gpCreateSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpCreateSupplier.Location = new System.Drawing.Point(3, 3);
            this.gpCreateSupplier.Name = "gpCreateSupplier";
            this.gpCreateSupplier.Size = new System.Drawing.Size(495, 926);
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
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.27778F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.06565F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78283F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(489, 901);
            this.tableLayoutPanel6.TabIndex = 20;
            // 
            // gpSupplierDetails
            // 
            this.gpSupplierDetails.Controls.Add(this.lblsupply_categoryID);
            this.gpSupplierDetails.Controls.Add(this.lblAddress);
            this.gpSupplierDetails.Controls.Add(this.txtDetails);
            this.gpSupplierDetails.Controls.Add(this.txtAddress);
            this.gpSupplierDetails.Controls.Add(this.lblSupplierName);
            this.gpSupplierDetails.Controls.Add(this.msktxtContactNumber);
            this.gpSupplierDetails.Controls.Add(this.txtSupplierName);
            this.gpSupplierDetails.Controls.Add(this.lblSupplierDescription);
            this.gpSupplierDetails.Controls.Add(this.lblContactNumber);
            this.gpSupplierDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpSupplierDetails.Location = new System.Drawing.Point(3, 3);
            this.gpSupplierDetails.Name = "gpSupplierDetails";
            this.gpSupplierDetails.Size = new System.Drawing.Size(483, 356);
            this.gpSupplierDetails.TabIndex = 0;
            this.gpSupplierDetails.TabStop = false;
            this.gpSupplierDetails.Text = "SupplierDetails";
            // 
            // lblsupply_categoryID
            // 
            this.lblsupply_categoryID.AutoSize = true;
            this.lblsupply_categoryID.Location = new System.Drawing.Point(94, 297);
            this.lblsupply_categoryID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsupply_categoryID.Name = "lblsupply_categoryID";
            this.lblsupply_categoryID.Size = new System.Drawing.Size(0, 20);
            this.lblsupply_categoryID.TabIndex = 20;
            this.lblsupply_categoryID.Visible = false;
            // 
            // gpItemSoldBySupplier
            // 
            this.gpItemSoldBySupplier.Controls.Add(this.tableLayoutPanel7);
            this.gpItemSoldBySupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpItemSoldBySupplier.Location = new System.Drawing.Point(3, 365);
            this.gpItemSoldBySupplier.Name = "gpItemSoldBySupplier";
            this.gpItemSoldBySupplier.Size = new System.Drawing.Size(483, 390);
            this.gpItemSoldBySupplier.TabIndex = 1;
            this.gpItemSoldBySupplier.TabStop = false;
            this.gpItemSoldBySupplier.Text = "Items Sold by Supplier";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.gpButtonNewForm, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lvwItemSold, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.02524F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.97476F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(477, 365);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // gpButtonNewForm
            // 
            this.gpButtonNewForm.Controls.Add(this.btnRemove);
            this.gpButtonNewForm.Controls.Add(this.btnAdd);
            this.gpButtonNewForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpButtonNewForm.Location = new System.Drawing.Point(3, 280);
            this.gpButtonNewForm.Name = "gpButtonNewForm";
            this.gpButtonNewForm.Size = new System.Drawing.Size(471, 82);
            this.gpButtonNewForm.TabIndex = 0;
            this.gpButtonNewForm.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 25);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 37);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvwItemSold
            // 
            this.lvwItemSold.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwSupply_Items_ID,
            this.lvwSupply_Category_ID,
            this.lvwCategoryName,
            this.lvwSupplyName});
            this.lvwItemSold.FullRowSelect = true;
            this.lvwItemSold.Location = new System.Drawing.Point(4, 5);
            this.lvwItemSold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvwItemSold.Name = "lvwItemSold";
            this.lvwItemSold.Size = new System.Drawing.Size(464, 253);
            this.lvwItemSold.TabIndex = 1;
            this.lvwItemSold.UseCompatibleStateImageBehavior = false;
            this.lvwItemSold.View = System.Windows.Forms.View.Details;
            this.lvwItemSold.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.lvwItemSold_RetrieveVirtualItem);
            this.lvwItemSold.SelectedIndexChanged += new System.EventHandler(this.lvwItemSold_SelectedIndexChanged);
            // 
            // lvwSupply_Items_ID
            // 
            this.lvwSupply_Items_ID.Text = "supply_items_ID";
            this.lvwSupply_Items_ID.Width = 0;
            // 
            // lvwSupply_Category_ID
            // 
            this.lvwSupply_Category_ID.Text = "supply_category_ID";
            this.lvwSupply_Category_ID.Width = 0;
            // 
            // lvwCategoryName
            // 
            this.lvwCategoryName.Text = "Category Name";
            this.lvwCategoryName.Width = 150;
            // 
            // lvwSupplyName
            // 
            this.lvwSupplyName.Text = "Supply Name";
            this.lvwSupplyName.Width = 150;
            // 
            // gpButtons
            // 
            this.gpButtons.Controls.Add(this.btnAddSupplier);
            this.gpButtons.Controls.Add(this.btnCancel);
            this.gpButtons.Controls.Add(this.btnUpdate);
            this.gpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpButtons.Location = new System.Drawing.Point(3, 761);
            this.gpButtons.Name = "gpButtons";
            this.gpButtons.Size = new System.Drawing.Size(483, 137);
            this.gpButtons.TabIndex = 2;
            this.gpButtons.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblSearch);
            this.groupBox10.Controls.Add(this.txtSearch);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(3, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(1221, 46);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(255, 25);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(130, 37);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 1049);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.lblValidate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.GroupBox gpButtonNewForm;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gpButtons;
        private System.Windows.Forms.GroupBox groupBox10;
        public System.Windows.Forms.ListView lvwItemSold;
        private System.Windows.Forms.ColumnHeader lvwSupply_Items_ID;
        private System.Windows.Forms.ColumnHeader lvwSupply_Category_ID;
        private System.Windows.Forms.ColumnHeader lvwCategoryName;
        private System.Windows.Forms.ColumnHeader lvwSupplyName;
        private System.Windows.Forms.Label lblsupply_categoryID;
        private System.Windows.Forms.Button btnRemove;
    }
}