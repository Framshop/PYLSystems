namespace PYLsystems
{
    partial class sales_materials
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
            this.cboSupply_Items = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dgvDamage_Materials = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSupplyItems = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSales_Price = new System.Windows.Forms.Label();
            this.txtSales_Price = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamage_Materials)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSupply_Items
            // 
            this.cboSupply_Items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupply_Items.FormattingEnabled = true;
            this.cboSupply_Items.Location = new System.Drawing.Point(128, 29);
            this.cboSupply_Items.Name = "cboSupply_Items";
            this.cboSupply_Items.Size = new System.Drawing.Size(193, 21);
            this.cboSupply_Items.TabIndex = 0;
            this.cboSupply_Items.SelectedIndexChanged += new System.EventHandler(this.cboSupply_Items_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(128, 82);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(193, 20);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // dgvDamage_Materials
            // 
            this.dgvDamage_Materials.AllowUserToAddRows = false;
            this.dgvDamage_Materials.AllowUserToDeleteRows = false;
            this.dgvDamage_Materials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDamage_Materials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDamage_Materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamage_Materials.Location = new System.Drawing.Point(337, 29);
            this.dgvDamage_Materials.Name = "dgvDamage_Materials";
            this.dgvDamage_Materials.ReadOnly = true;
            this.dgvDamage_Materials.Size = new System.Drawing.Size(411, 304);
            this.dgvDamage_Materials.TabIndex = 11;
            this.dgvDamage_Materials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDamage_Materials_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(18, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(99, 262);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(18, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSupplyItems
            // 
            this.lblSupplyItems.AutoSize = true;
            this.lblSupplyItems.Location = new System.Drawing.Point(15, 37);
            this.lblSupplyItems.Name = "lblSupplyItems";
            this.lblSupplyItems.Size = new System.Drawing.Size(67, 13);
            this.lblSupplyItems.TabIndex = 1;
            this.lblSupplyItems.Text = "Supply Items";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(15, 89);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblSales_Price
            // 
            this.lblSales_Price.AutoSize = true;
            this.lblSales_Price.Location = new System.Drawing.Point(15, 63);
            this.lblSales_Price.Name = "lblSales_Price";
            this.lblSales_Price.Size = new System.Drawing.Size(60, 13);
            this.lblSales_Price.TabIndex = 5;
            this.lblSales_Price.Text = "Sales Price";
            this.lblSales_Price.Click += new System.EventHandler(this.lblSales_Price_Click);
            // 
            // txtSales_Price
            // 
            this.txtSales_Price.Enabled = false;
            this.txtSales_Price.Location = new System.Drawing.Point(128, 56);
            this.txtSales_Price.Name = "txtSales_Price";
            this.txtSales_Price.Size = new System.Drawing.Size(193, 20);
            this.txtSales_Price.TabIndex = 4;
            // 
            // sales_materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(760, 345);
            this.Controls.Add(this.txtSales_Price);
            this.Controls.Add(this.lblSales_Price);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblSupplyItems);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDamage_Materials);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cboSupply_Items);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "sales_materials";
            this.Text = "Sales Materials";
            this.Load += new System.EventHandler(this.sales_materials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamage_Materials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSupply_Items;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridView dgvDamage_Materials;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSupplyItems;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblSales_Price;
        private System.Windows.Forms.TextBox txtSales_Price;
    }
}