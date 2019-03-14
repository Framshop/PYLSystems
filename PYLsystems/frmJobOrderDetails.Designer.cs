namespace PYLsystems
{
    partial class frmJobOrderDetails
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
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblSupplyItems = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnitMeasure = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblJobOrderDate = new System.Windows.Forms.Label();
            this.msktxtJobOrderDate = new System.Windows.Forms.MaskedTextBox();
            this.cboPaymentType = new System.Windows.Forms.ComboBox();
            this.cboCustomerName = new System.Windows.Forms.ComboBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.cboSupplyItems = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.lvwJobDetails = new System.Windows.Forms.ListView();
            this.chSupplyItemsID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSupplyItemsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSupplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUnitMeasure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddSupply = new System.Windows.Forms.Button();
            this.btnAddJobOrderDetails = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblSupplyID = new System.Windows.Forms.Label();
            this.txtJobOrderDate = new System.Windows.Forms.TextBox();
            this.txtSupplyPrice = new System.Windows.Forms.TextBox();
            this.lblSupplyPrice = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblDiscountedTotalAmount = new System.Windows.Forms.Label();
            this.txtDiscountedTotalAmount = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblValidate = new System.Windows.Forms.Label();
            this.lblCustomerPayment = new System.Windows.Forms.Label();
            this.txtCustomerPayment = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSign = new System.Windows.Forms.Label();
            this.txtUnitMeasure = new System.Windows.Forms.TextBox();
            this.cboUnitMeasure = new System.Windows.Forms.ComboBox();
            this.lblConverter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(35, 205);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(75, 13);
            this.lblPaymentType.TabIndex = 1;
            this.lblPaymentType.Text = "Payment Type";
            // 
            // lblSupplyItems
            // 
            this.lblSupplyItems.AutoSize = true;
            this.lblSupplyItems.Location = new System.Drawing.Point(37, 379);
            this.lblSupplyItems.Name = "lblSupplyItems";
            this.lblSupplyItems.Size = new System.Drawing.Size(67, 13);
            this.lblSupplyItems.TabIndex = 2;
            this.lblSupplyItems.Text = "Supply Items";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(37, 562);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblUnitMeasure
            // 
            this.lblUnitMeasure.AutoSize = true;
            this.lblUnitMeasure.Location = new System.Drawing.Point(37, 456);
            this.lblUnitMeasure.Name = "lblUnitMeasure";
            this.lblUnitMeasure.Size = new System.Drawing.Size(70, 13);
            this.lblUnitMeasure.TabIndex = 4;
            this.lblUnitMeasure.Text = "Unit Measure";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(35, 257);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(70, 13);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(37, 587);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(74, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Demand Price";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(37, 121);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 9;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(35, 231);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 10;
            this.lblDiscount.Text = "Discount";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(37, 535);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 11;
            this.lblSize.Text = "Size";
            // 
            // lblJobOrderDate
            // 
            this.lblJobOrderDate.AutoSize = true;
            this.lblJobOrderDate.Location = new System.Drawing.Point(37, 94);
            this.lblJobOrderDate.Name = "lblJobOrderDate";
            this.lblJobOrderDate.Size = new System.Drawing.Size(79, 13);
            this.lblJobOrderDate.TabIndex = 12;
            this.lblJobOrderDate.Text = "Job Order Date";
            // 
            // msktxtJobOrderDate
            // 
            this.msktxtJobOrderDate.Location = new System.Drawing.Point(170, 87);
            this.msktxtJobOrderDate.Mask = "0000-00-00 90:00";
            this.msktxtJobOrderDate.Name = "msktxtJobOrderDate";
            this.msktxtJobOrderDate.PromptChar = ' ';
            this.msktxtJobOrderDate.Size = new System.Drawing.Size(186, 20);
            this.msktxtJobOrderDate.TabIndex = 13;
            this.msktxtJobOrderDate.TextChanged += new System.EventHandler(this.msktxtJobOrderDate_TextChanged);
            // 
            // cboPaymentType
            // 
            this.cboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentType.FormattingEnabled = true;
            this.cboPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.cboPaymentType.Location = new System.Drawing.Point(170, 197);
            this.cboPaymentType.Name = "cboPaymentType";
            this.cboPaymentType.Size = new System.Drawing.Size(186, 21);
            this.cboPaymentType.TabIndex = 15;
            this.cboPaymentType.SelectedIndexChanged += new System.EventHandler(this.cboPaymentType_SelectedIndexChanged);
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomerName.FormattingEnabled = true;
            this.cboCustomerName.Location = new System.Drawing.Point(170, 113);
            this.cboCustomerName.Name = "cboCustomerName";
            this.cboCustomerName.Size = new System.Drawing.Size(186, 21);
            this.cboCustomerName.TabIndex = 16;
            this.cboCustomerName.SelectedIndexChanged += new System.EventHandler(this.cboCustomerName_SelectedIndexChanged);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(170, 250);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(186, 20);
            this.txtTotalAmount.TabIndex = 18;
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            // 
            // cboSupplyItems
            // 
            this.cboSupplyItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplyItems.FormattingEnabled = true;
            this.cboSupplyItems.Location = new System.Drawing.Point(170, 370);
            this.cboSupplyItems.Name = "cboSupplyItems";
            this.cboSupplyItems.Size = new System.Drawing.Size(186, 21);
            this.cboSupplyItems.TabIndex = 19;
            this.cboSupplyItems.SelectedIndexChanged += new System.EventHandler(this.cboSupplyItems_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(170, 554);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(186, 20);
            this.txtQuantity.TabIndex = 22;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(170, 580);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(186, 20);
            this.txtPrice.TabIndex = 23;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(37, 404);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(45, 13);
            this.lblSupplier.TabIndex = 26;
            this.lblSupplier.Text = "Supplier";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Enabled = false;
            this.txtSupplier.Location = new System.Drawing.Point(170, 397);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(186, 20);
            this.txtSupplier.TabIndex = 28;
            // 
            // lvwJobDetails
            // 
            this.lvwJobDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwJobDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSupplyItemsID,
            this.chSupplyItemsName,
            this.chSupplier,
            this.chSize,
            this.chUnitMeasure,
            this.chQuantity,
            this.chPrice,
            this.chSubtotal});
            this.lvwJobDetails.Location = new System.Drawing.Point(364, 87);
            this.lvwJobDetails.Name = "lvwJobDetails";
            this.lvwJobDetails.Size = new System.Drawing.Size(800, 435);
            this.lvwJobDetails.TabIndex = 29;
            this.lvwJobDetails.UseCompatibleStateImageBehavior = false;
            this.lvwJobDetails.View = System.Windows.Forms.View.Details;
            // 
            // chSupplyItemsID
            // 
            this.chSupplyItemsID.Text = "Supply Items ID";
            this.chSupplyItemsID.Width = 0;
            // 
            // chSupplyItemsName
            // 
            this.chSupplyItemsName.Text = "Supply Items Name";
            this.chSupplyItemsName.Width = 125;
            // 
            // chSupplier
            // 
            this.chSupplier.Text = "Supplier";
            this.chSupplier.Width = 125;
            // 
            // chSize
            // 
            this.chSize.Text = "Size";
            this.chSize.Width = 100;
            // 
            // chUnitMeasure
            // 
            this.chUnitMeasure.Text = "Unit Measure";
            this.chUnitMeasure.Width = 100;
            // 
            // chQuantity
            // 
            this.chQuantity.Text = "Quantity";
            this.chQuantity.Width = 100;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Price";
            this.chPrice.Width = 150;
            // 
            // chSubtotal
            // 
            this.chSubtotal.Text = "Subtotal";
            this.chSubtotal.Width = 150;
            // 
            // btnAddSupply
            // 
            this.btnAddSupply.Enabled = false;
            this.btnAddSupply.Location = new System.Drawing.Point(362, 556);
            this.btnAddSupply.Name = "btnAddSupply";
            this.btnAddSupply.Size = new System.Drawing.Size(75, 23);
            this.btnAddSupply.TabIndex = 30;
            this.btnAddSupply.Text = "Add Supply";
            this.btnAddSupply.UseVisualStyleBackColor = true;
            this.btnAddSupply.Click += new System.EventHandler(this.btnAddSupply_Click);
            // 
            // btnAddJobOrderDetails
            // 
            this.btnAddJobOrderDetails.Enabled = false;
            this.btnAddJobOrderDetails.Location = new System.Drawing.Point(443, 528);
            this.btnAddJobOrderDetails.Name = "btnAddJobOrderDetails";
            this.btnAddJobOrderDetails.Size = new System.Drawing.Size(124, 23);
            this.btnAddJobOrderDetails.TabIndex = 31;
            this.btnAddJobOrderDetails.Text = "Add Job Order Details";
            this.btnAddJobOrderDetails.UseVisualStyleBackColor = true;
            this.btnAddJobOrderDetails.Click += new System.EventHandler(this.btnAddJobOrderDetails_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(362, 528);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(170, 528);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(186, 20);
            this.txtSize.TabIndex = 33;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            this.txtSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSize_KeyPress);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(481, 166);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerID.TabIndex = 34;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(419, 166);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(0, 13);
            this.lblEmployeeID.TabIndex = 35;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Red;
            this.lblDate.Location = new System.Drawing.Point(169, 71);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(102, 13);
            this.lblDate.TabIndex = 36;
            this.lblDate.Text = "yyyy/mm/dd time";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(364, 58);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 37;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblSupplyID
            // 
            this.lblSupplyID.AutoSize = true;
            this.lblSupplyID.Location = new System.Drawing.Point(149, 430);
            this.lblSupplyID.Name = "lblSupplyID";
            this.lblSupplyID.Size = new System.Drawing.Size(0, 13);
            this.lblSupplyID.TabIndex = 38;
            this.lblSupplyID.Visible = false;
            // 
            // txtJobOrderDate
            // 
            this.txtJobOrderDate.Enabled = false;
            this.txtJobOrderDate.Location = new System.Drawing.Point(584, 174);
            this.txtJobOrderDate.Name = "txtJobOrderDate";
            this.txtJobOrderDate.Size = new System.Drawing.Size(211, 20);
            this.txtJobOrderDate.TabIndex = 39;
            this.txtJobOrderDate.TextChanged += new System.EventHandler(this.txtJobOrderDate_TextChanged);
            // 
            // txtSupplyPrice
            // 
            this.txtSupplyPrice.Enabled = false;
            this.txtSupplyPrice.Location = new System.Drawing.Point(170, 423);
            this.txtSupplyPrice.Name = "txtSupplyPrice";
            this.txtSupplyPrice.Size = new System.Drawing.Size(186, 20);
            this.txtSupplyPrice.TabIndex = 40;
            // 
            // lblSupplyPrice
            // 
            this.lblSupplyPrice.AutoSize = true;
            this.lblSupplyPrice.Location = new System.Drawing.Point(37, 430);
            this.lblSupplyPrice.Name = "lblSupplyPrice";
            this.lblSupplyPrice.Size = new System.Drawing.Size(103, 13);
            this.lblSupplyPrice.TabIndex = 41;
            this.lblSupplyPrice.Text = "Current Supply Price";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(37, 613);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 42;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(170, 606);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(186, 20);
            this.txtSubtotal.TabIndex = 43;
            this.txtSubtotal.Text = "0";
            // 
            // lblDiscountedTotalAmount
            // 
            this.lblDiscountedTotalAmount.AutoSize = true;
            this.lblDiscountedTotalAmount.Location = new System.Drawing.Point(35, 283);
            this.lblDiscountedTotalAmount.Name = "lblDiscountedTotalAmount";
            this.lblDiscountedTotalAmount.Size = new System.Drawing.Size(127, 13);
            this.lblDiscountedTotalAmount.TabIndex = 44;
            this.lblDiscountedTotalAmount.Text = "Discounted Total Amount";
            // 
            // txtDiscountedTotalAmount
            // 
            this.txtDiscountedTotalAmount.Enabled = false;
            this.txtDiscountedTotalAmount.Location = new System.Drawing.Point(170, 276);
            this.txtDiscountedTotalAmount.Name = "txtDiscountedTotalAmount";
            this.txtDiscountedTotalAmount.Size = new System.Drawing.Size(186, 20);
            this.txtDiscountedTotalAmount.TabIndex = 45;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(170, 225);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(184, 20);
            this.txtDiscount.TabIndex = 47;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged_1);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // lblValidate
            // 
            this.lblValidate.AutoSize = true;
            this.lblValidate.Location = new System.Drawing.Point(169, 164);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(0, 13);
            this.lblValidate.TabIndex = 48;
            // 
            // lblCustomerPayment
            // 
            this.lblCustomerPayment.AutoSize = true;
            this.lblCustomerPayment.Location = new System.Drawing.Point(35, 310);
            this.lblCustomerPayment.Name = "lblCustomerPayment";
            this.lblCustomerPayment.Size = new System.Drawing.Size(95, 13);
            this.lblCustomerPayment.TabIndex = 49;
            this.lblCustomerPayment.Text = "Customer Payment";
            // 
            // txtCustomerPayment
            // 
            this.txtCustomerPayment.Location = new System.Drawing.Point(170, 303);
            this.txtCustomerPayment.Name = "txtCustomerPayment";
            this.txtCustomerPayment.Size = new System.Drawing.Size(186, 20);
            this.txtCustomerPayment.TabIndex = 50;
            this.txtCustomerPayment.TextChanged += new System.EventHandler(this.txtCustomerPayment_TextChanged);
            this.txtCustomerPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerPayment_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "Add Customer Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSign
            // 
            this.lblSign.AutoSize = true;
            this.lblSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSign.Location = new System.Drawing.Point(459, 58);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(196, 20);
            this.lblSign.TabIndex = 52;
            this.lblSign.Text = "Avoid Duplicate Entries";
            // 
            // txtUnitMeasure
            // 
            this.txtUnitMeasure.Enabled = false;
            this.txtUnitMeasure.Location = new System.Drawing.Point(170, 449);
            this.txtUnitMeasure.Name = "txtUnitMeasure";
            this.txtUnitMeasure.Size = new System.Drawing.Size(186, 20);
            this.txtUnitMeasure.TabIndex = 46;
            // 
            // cboUnitMeasure
            // 
            this.cboUnitMeasure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnitMeasure.FormattingEnabled = true;
            this.cboUnitMeasure.Items.AddRange(new object[] {
            "ft",
            "inches"});
            this.cboUnitMeasure.Location = new System.Drawing.Point(170, 501);
            this.cboUnitMeasure.Name = "cboUnitMeasure";
            this.cboUnitMeasure.Size = new System.Drawing.Size(186, 21);
            this.cboUnitMeasure.TabIndex = 53;
            // 
            // lblConverter
            // 
            this.lblConverter.AutoSize = true;
            this.lblConverter.Location = new System.Drawing.Point(37, 509);
            this.lblConverter.Name = "lblConverter";
            this.lblConverter.Size = new System.Drawing.Size(87, 13);
            this.lblConverter.TabIndex = 54;
            this.lblConverter.Text = "Conversion Type";
            // 
            // frmJobOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 699);
            this.Controls.Add(this.lblConverter);
            this.Controls.Add(this.cboUnitMeasure);
            this.Controls.Add(this.lblSign);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCustomerPayment);
            this.Controls.Add(this.lblCustomerPayment);
            this.Controls.Add(this.lblValidate);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtUnitMeasure);
            this.Controls.Add(this.txtDiscountedTotalAmount);
            this.Controls.Add(this.lblDiscountedTotalAmount);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblSupplyPrice);
            this.Controls.Add(this.txtSupplyPrice);
            this.Controls.Add(this.lblSupplyID);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddJobOrderDetails);
            this.Controls.Add(this.btnAddSupply);
            this.Controls.Add(this.lvwJobDetails);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cboSupplyItems);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.cboCustomerName);
            this.Controls.Add(this.cboPaymentType);
            this.Controls.Add(this.msktxtJobOrderDate);
            this.Controls.Add(this.lblJobOrderDate);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblUnitMeasure);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblSupplyItems);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.txtJobOrderDate);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblCustomerID);
            this.Name = "frmJobOrderDetails";
            this.Text = "Add Job Orders";
            this.Load += new System.EventHandler(this.frmJobOrderDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblSupplyItems;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnitMeasure;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblJobOrderDate;
        private System.Windows.Forms.MaskedTextBox msktxtJobOrderDate;
        private System.Windows.Forms.ComboBox cboPaymentType;
        private System.Windows.Forms.ComboBox cboCustomerName;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.ComboBox cboSupplyItems;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.ListView lvwJobDetails;
        private System.Windows.Forms.ColumnHeader chSupplyItemsID;
        private System.Windows.Forms.ColumnHeader chSupplyItemsName;
        private System.Windows.Forms.ColumnHeader chSupplier;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ColumnHeader chUnitMeasure;
        private System.Windows.Forms.ColumnHeader chQuantity;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.Button btnAddSupply;
        private System.Windows.Forms.Button btnAddJobOrderDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSupplyID;
        private System.Windows.Forms.TextBox txtJobOrderDate;
        private System.Windows.Forms.ColumnHeader chSubtotal;
        private System.Windows.Forms.TextBox txtSupplyPrice;
        private System.Windows.Forms.Label lblSupplyPrice;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblDiscountedTotalAmount;
        private System.Windows.Forms.TextBox txtDiscountedTotalAmount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblValidate;
        private System.Windows.Forms.Label lblCustomerPayment;
        private System.Windows.Forms.TextBox txtCustomerPayment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSign;
        private System.Windows.Forms.TextBox txtUnitMeasure;
        private System.Windows.Forms.ComboBox cboUnitMeasure;
        private System.Windows.Forms.Label lblConverter;
    }
}