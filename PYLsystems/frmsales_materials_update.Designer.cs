namespace PYLsystems
{
    partial class frmsales_materials_update
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtMaterials = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblSupplyItems = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblsupply_itemsID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(20, 124);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(114, 124);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtMaterials
            // 
            this.txtMaterials.Enabled = false;
            this.txtMaterials.Location = new System.Drawing.Point(114, 28);
            this.txtMaterials.Name = "txtMaterials";
            this.txtMaterials.Size = new System.Drawing.Size(135, 20);
            this.txtMaterials.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(114, 54);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(135, 20);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblSupplyItems
            // 
            this.lblSupplyItems.AutoSize = true;
            this.lblSupplyItems.Location = new System.Drawing.Point(13, 34);
            this.lblSupplyItems.Name = "lblSupplyItems";
            this.lblSupplyItems.Size = new System.Drawing.Size(44, 13);
            this.lblSupplyItems.TabIndex = 4;
            this.lblSupplyItems.Text = "Material";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(13, 61);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblsupply_itemsID
            // 
            this.lblsupply_itemsID.AutoSize = true;
            this.lblsupply_itemsID.Location = new System.Drawing.Point(148, 61);
            this.lblsupply_itemsID.Name = "lblsupply_itemsID";
            this.lblsupply_itemsID.Size = new System.Drawing.Size(0, 13);
            this.lblsupply_itemsID.TabIndex = 6;
            this.lblsupply_itemsID.Visible = false;
            // 
            // frmsales_materials_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 160);
            this.Controls.Add(this.lblsupply_itemsID);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblSupplyItems);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtMaterials);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmsales_materials_update";
            this.Text = "Sales Materials Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblSupplyItems;
        private System.Windows.Forms.Label lblQuantity;
        public System.Windows.Forms.TextBox txtMaterials;
        public System.Windows.Forms.TextBox txtQuantity;
        public System.Windows.Forms.Label lblsupply_itemsID;
    }
}