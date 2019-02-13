﻿namespace PYLsystems
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
            this.lblJobOrderID = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblSupplyItems = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnitMeasure = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblJobOrderDate = new System.Windows.Forms.Label();
            this.msktxtJobOrderDate = new System.Windows.Forms.MaskedTextBox();
            this.cboEmployeeLastName = new System.Windows.Forms.ComboBox();
            this.cboPaymentType = new System.Windows.Forms.ComboBox();
            this.cboCustomerName = new System.Windows.Forms.ComboBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.cboSupplyItems = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
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
            this.txtUnitMeasure = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblValidate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJobOrderID
            // 
            this.lblJobOrderID.AutoSize = true;
            this.lblJobOrderID.Location = new System.Drawing.Point(56, 69);
            this.lblJobOrderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobOrderID.Name = "lblJobOrderID";
            this.lblJobOrderID.Size = new System.Drawing.Size(139, 20);
            this.lblJobOrderID.TabIndex = 0;
            this.lblJobOrderID.Text = "Job Order Number";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(56, 349);
            this.lblPaymentType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(109, 20);
            this.lblPaymentType.TabIndex = 1;
            this.lblPaymentType.Text = "Payment Type";
            // 
            // lblSupplyItems
            // 
            this.lblSupplyItems.AutoSize = true;
            this.lblSupplyItems.Location = new System.Drawing.Point(56, 583);
            this.lblSupplyItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplyItems.Name = "lblSupplyItems";
            this.lblSupplyItems.Size = new System.Drawing.Size(101, 20);
            this.lblSupplyItems.TabIndex = 2;
            this.lblSupplyItems.Text = "Supply Items";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(56, 825);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblUnitMeasure
            // 
            this.lblUnitMeasure.AutoSize = true;
            this.lblUnitMeasure.Location = new System.Drawing.Point(56, 702);
            this.lblUnitMeasure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitMeasure.Name = "lblUnitMeasure";
            this.lblUnitMeasure.Size = new System.Drawing.Size(104, 20);
            this.lblUnitMeasure.TabIndex = 4;
            this.lblUnitMeasure.Text = "Unit Measure";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(56, 268);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(125, 20);
            this.lblEmployeeName.TabIndex = 5;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(56, 429);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(104, 20);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(56, 863);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(109, 20);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Demand Price";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(56, 186);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(124, 20);
            this.lblCustomerName.TabIndex = 9;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(56, 389);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(72, 20);
            this.lblDiscount.TabIndex = 10;
            this.lblDiscount.Text = "Discount";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(56, 783);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(40, 20);
            this.lblSize.TabIndex = 11;
            this.lblSize.Text = "Size";
            // 
            // lblJobOrderDate
            // 
            this.lblJobOrderDate.AutoSize = true;
            this.lblJobOrderDate.Location = new System.Drawing.Point(56, 145);
            this.lblJobOrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobOrderDate.Name = "lblJobOrderDate";
            this.lblJobOrderDate.Size = new System.Drawing.Size(118, 20);
            this.lblJobOrderDate.TabIndex = 12;
            this.lblJobOrderDate.Text = "Job Order Date";
            // 
            // msktxtJobOrderDate
            // 
            this.msktxtJobOrderDate.Location = new System.Drawing.Point(255, 134);
            this.msktxtJobOrderDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.msktxtJobOrderDate.Mask = "0000-00-00 90:00";
            this.msktxtJobOrderDate.Name = "msktxtJobOrderDate";
            this.msktxtJobOrderDate.PromptChar = ' ';
            this.msktxtJobOrderDate.Size = new System.Drawing.Size(277, 26);
            this.msktxtJobOrderDate.TabIndex = 13;
            this.msktxtJobOrderDate.TextChanged += new System.EventHandler(this.msktxtJobOrderDate_TextChanged);
            // 
            // cboEmployeeLastName
            // 
            this.cboEmployeeLastName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployeeLastName.FormattingEnabled = true;
            this.cboEmployeeLastName.Location = new System.Drawing.Point(258, 255);
            this.cboEmployeeLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboEmployeeLastName.Name = "cboEmployeeLastName";
            this.cboEmployeeLastName.Size = new System.Drawing.Size(277, 28);
            this.cboEmployeeLastName.TabIndex = 14;
            this.cboEmployeeLastName.SelectedIndexChanged += new System.EventHandler(this.cboEmployeeLastName_SelectedIndexChanged);
            // 
            // cboPaymentType
            // 
            this.cboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentType.FormattingEnabled = true;
            this.cboPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.cboPaymentType.Location = new System.Drawing.Point(258, 337);
            this.cboPaymentType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPaymentType.Name = "cboPaymentType";
            this.cboPaymentType.Size = new System.Drawing.Size(277, 28);
            this.cboPaymentType.TabIndex = 15;
            this.cboPaymentType.SelectedIndexChanged += new System.EventHandler(this.cboPaymentType_SelectedIndexChanged);
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomerName.FormattingEnabled = true;
            this.cboCustomerName.Location = new System.Drawing.Point(255, 174);
            this.cboCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCustomerName.Name = "cboCustomerName";
            this.cboCustomerName.Size = new System.Drawing.Size(277, 28);
            this.cboCustomerName.TabIndex = 16;
            this.cboCustomerName.SelectedIndexChanged += new System.EventHandler(this.cboCustomerName_SelectedIndexChanged);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(258, 418);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(277, 26);
            this.txtTotalAmount.TabIndex = 18;
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            // 
            // cboSupplyItems
            // 
            this.cboSupplyItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplyItems.FormattingEnabled = true;
            this.cboSupplyItems.Location = new System.Drawing.Point(255, 569);
            this.cboSupplyItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSupplyItems.Name = "cboSupplyItems";
            this.cboSupplyItems.Size = new System.Drawing.Size(277, 28);
            this.cboSupplyItems.TabIndex = 19;
            this.cboSupplyItems.SelectedIndexChanged += new System.EventHandler(this.cboSupplyItems_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(255, 812);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(277, 26);
            this.txtQuantity.TabIndex = 22;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(255, 852);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(277, 26);
            this.txtPrice.TabIndex = 23;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Location = new System.Drawing.Point(258, 215);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(277, 26);
            this.txtBalance.TabIndex = 24;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(56, 622);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(67, 20);
            this.lblSupplier.TabIndex = 26;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(56, 226);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(67, 20);
            this.lblBalance.TabIndex = 27;
            this.lblBalance.Text = "Balance";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Enabled = false;
            this.txtSupplier.Location = new System.Drawing.Point(255, 611);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(277, 26);
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
            this.lvwJobDetails.Location = new System.Drawing.Point(546, 134);
            this.lvwJobDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvwJobDetails.Name = "lvwJobDetails";
            this.lvwJobDetails.Size = new System.Drawing.Size(1198, 667);
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
            this.btnAddSupply.Location = new System.Drawing.Point(543, 857);
            this.btnAddSupply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddSupply.Name = "btnAddSupply";
            this.btnAddSupply.Size = new System.Drawing.Size(112, 35);
            this.btnAddSupply.TabIndex = 30;
            this.btnAddSupply.Text = "Add Supply";
            this.btnAddSupply.UseVisualStyleBackColor = true;
            this.btnAddSupply.Click += new System.EventHandler(this.btnAddSupply_Click);
            // 
            // btnAddJobOrderDetails
            // 
            this.btnAddJobOrderDetails.Enabled = false;
            this.btnAddJobOrderDetails.Location = new System.Drawing.Point(664, 812);
            this.btnAddJobOrderDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddJobOrderDetails.Name = "btnAddJobOrderDetails";
            this.btnAddJobOrderDetails.Size = new System.Drawing.Size(186, 35);
            this.btnAddJobOrderDetails.TabIndex = 31;
            this.btnAddJobOrderDetails.Text = "Add Job Order Details";
            this.btnAddJobOrderDetails.UseVisualStyleBackColor = true;
            this.btnAddJobOrderDetails.Click += new System.EventHandler(this.btnAddJobOrderDetails_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(543, 812);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(255, 772);
            this.txtSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(277, 26);
            this.txtSize.TabIndex = 33;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            this.txtSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSize_KeyPress);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(722, 255);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(0, 20);
            this.lblCustomerID.TabIndex = 34;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(628, 255);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(0, 20);
            this.lblEmployeeID.TabIndex = 35;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Red;
            this.lblDate.Location = new System.Drawing.Point(254, 109);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(149, 20);
            this.lblDate.TabIndex = 36;
            this.lblDate.Text = "yyyy/mm/dd time";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(546, 89);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 35);
            this.btnRemove.TabIndex = 37;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblSupplyID
            // 
            this.lblSupplyID.AutoSize = true;
            this.lblSupplyID.Location = new System.Drawing.Point(224, 662);
            this.lblSupplyID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplyID.Name = "lblSupplyID";
            this.lblSupplyID.Size = new System.Drawing.Size(0, 20);
            this.lblSupplyID.TabIndex = 38;
            this.lblSupplyID.Visible = false;
            // 
            // txtJobOrderDate
            // 
            this.txtJobOrderDate.Enabled = false;
            this.txtJobOrderDate.Location = new System.Drawing.Point(876, 268);
            this.txtJobOrderDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJobOrderDate.Name = "txtJobOrderDate";
            this.txtJobOrderDate.Size = new System.Drawing.Size(314, 26);
            this.txtJobOrderDate.TabIndex = 39;
            this.txtJobOrderDate.TextChanged += new System.EventHandler(this.txtJobOrderDate_TextChanged);
            // 
            // txtSupplyPrice
            // 
            this.txtSupplyPrice.Enabled = false;
            this.txtSupplyPrice.Location = new System.Drawing.Point(255, 651);
            this.txtSupplyPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSupplyPrice.Name = "txtSupplyPrice";
            this.txtSupplyPrice.Size = new System.Drawing.Size(277, 26);
            this.txtSupplyPrice.TabIndex = 40;
            // 
            // lblSupplyPrice
            // 
            this.lblSupplyPrice.AutoSize = true;
            this.lblSupplyPrice.Location = new System.Drawing.Point(56, 662);
            this.lblSupplyPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplyPrice.Name = "lblSupplyPrice";
            this.lblSupplyPrice.Size = new System.Drawing.Size(153, 20);
            this.lblSupplyPrice.TabIndex = 41;
            this.lblSupplyPrice.Text = "Current Supply Price";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(56, 903);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(69, 20);
            this.lblSubtotal.TabIndex = 42;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(255, 892);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(277, 26);
            this.txtSubtotal.TabIndex = 43;
            this.txtSubtotal.Text = "0";
            // 
            // lblDiscountedTotalAmount
            // 
            this.lblDiscountedTotalAmount.AutoSize = true;
            this.lblDiscountedTotalAmount.Location = new System.Drawing.Point(56, 469);
            this.lblDiscountedTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscountedTotalAmount.Name = "lblDiscountedTotalAmount";
            this.lblDiscountedTotalAmount.Size = new System.Drawing.Size(189, 20);
            this.lblDiscountedTotalAmount.TabIndex = 44;
            this.lblDiscountedTotalAmount.Text = "Discounted Total Amount";
            // 
            // txtDiscountedTotalAmount
            // 
            this.txtDiscountedTotalAmount.Enabled = false;
            this.txtDiscountedTotalAmount.Location = new System.Drawing.Point(258, 458);
            this.txtDiscountedTotalAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiscountedTotalAmount.Name = "txtDiscountedTotalAmount";
            this.txtDiscountedTotalAmount.Size = new System.Drawing.Size(277, 26);
            this.txtDiscountedTotalAmount.TabIndex = 45;
            // 
            // txtUnitMeasure
            // 
            this.txtUnitMeasure.Enabled = false;
            this.txtUnitMeasure.Location = new System.Drawing.Point(255, 691);
            this.txtUnitMeasure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUnitMeasure.Name = "txtUnitMeasure";
            this.txtUnitMeasure.Size = new System.Drawing.Size(277, 26);
            this.txtUnitMeasure.TabIndex = 46;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(258, 380);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(274, 26);
            this.txtDiscount.TabIndex = 47;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged_1);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // lblValidate
            // 
            this.lblValidate.AutoSize = true;
            this.lblValidate.Location = new System.Drawing.Point(254, 292);
            this.lblValidate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(0, 20);
            this.lblValidate.TabIndex = 48;
            // 
            // frmJobOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1815, 1075);
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
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cboSupplyItems);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.cboCustomerName);
            this.Controls.Add(this.cboPaymentType);
            this.Controls.Add(this.cboEmployeeLastName);
            this.Controls.Add(this.msktxtJobOrderDate);
            this.Controls.Add(this.lblJobOrderDate);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblUnitMeasure);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblSupplyItems);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.lblJobOrderID);
            this.Controls.Add(this.txtJobOrderDate);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblCustomerID);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmJobOrderDetails";
            this.Text = "Add Job Orders";
            this.Load += new System.EventHandler(this.frmJobOrderDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJobOrderID;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblSupplyItems;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnitMeasure;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblJobOrderDate;
        private System.Windows.Forms.MaskedTextBox msktxtJobOrderDate;
        private System.Windows.Forms.ComboBox cboEmployeeLastName;
        private System.Windows.Forms.ComboBox cboPaymentType;
        private System.Windows.Forms.ComboBox cboCustomerName;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.ComboBox cboSupplyItems;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblBalance;
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
        private System.Windows.Forms.TextBox txtUnitMeasure;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblValidate;
    }
}