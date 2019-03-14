namespace PYLsystems
{
    partial class frmDamageMaterials
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
            this.lblMaterials = new System.Windows.Forms.Label();
            this.lblDamageReason = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnClsoe = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboMaterials = new System.Windows.Forms.ComboBox();
            this.txtDamageReason = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dgvDamageMaterials = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamageMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaterials
            // 
            this.lblMaterials.AutoSize = true;
            this.lblMaterials.Location = new System.Drawing.Point(20, 25);
            this.lblMaterials.Name = "lblMaterials";
            this.lblMaterials.Size = new System.Drawing.Size(49, 13);
            this.lblMaterials.TabIndex = 0;
            this.lblMaterials.Text = "Materials";
            // 
            // lblDamageReason
            // 
            this.lblDamageReason.AutoSize = true;
            this.lblDamageReason.Location = new System.Drawing.Point(20, 70);
            this.lblDamageReason.Name = "lblDamageReason";
            this.lblDamageReason.Size = new System.Drawing.Size(87, 13);
            this.lblDamageReason.TabIndex = 1;
            this.lblDamageReason.Text = "Damage Reason";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(20, 122);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnClsoe
            // 
            this.btnClsoe.Location = new System.Drawing.Point(23, 274);
            this.btnClsoe.Name = "btnClsoe";
            this.btnClsoe.Size = new System.Drawing.Size(75, 23);
            this.btnClsoe.TabIndex = 3;
            this.btnClsoe.Text = "Cancel";
            this.btnClsoe.UseVisualStyleBackColor = true;
            this.btnClsoe.Click += new System.EventHandler(this.btnClsoe_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(23, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboMaterials
            // 
            this.cboMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterials.FormattingEnabled = true;
            this.cboMaterials.Location = new System.Drawing.Point(133, 17);
            this.cboMaterials.Name = "cboMaterials";
            this.cboMaterials.Size = new System.Drawing.Size(171, 21);
            this.cboMaterials.TabIndex = 5;
            this.cboMaterials.SelectedIndexChanged += new System.EventHandler(this.cboMaterials_SelectedIndexChanged);
            // 
            // txtDamageReason
            // 
            this.txtDamageReason.Location = new System.Drawing.Point(133, 44);
            this.txtDamageReason.Multiline = true;
            this.txtDamageReason.Name = "txtDamageReason";
            this.txtDamageReason.Size = new System.Drawing.Size(171, 65);
            this.txtDamageReason.TabIndex = 6;
            this.txtDamageReason.TextChanged += new System.EventHandler(this.txtDamageReason_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(133, 115);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(171, 20);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // dgvDamageMaterials
            // 
            this.dgvDamageMaterials.AllowUserToAddRows = false;
            this.dgvDamageMaterials.AllowUserToDeleteRows = false;
            this.dgvDamageMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDamageMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDamageMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamageMaterials.Location = new System.Drawing.Point(493, 12);
            this.dgvDamageMaterials.Name = "dgvDamageMaterials";
            this.dgvDamageMaterials.ReadOnly = true;
            this.dgvDamageMaterials.Size = new System.Drawing.Size(358, 294);
            this.dgvDamageMaterials.TabIndex = 8;
            this.dgvDamageMaterials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDamageMaterials_CellClick);
            this.dgvDamageMaterials.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.a);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(104, 245);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmDamageMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 315);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvDamageMaterials);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDamageReason);
            this.Controls.Add(this.cboMaterials);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClsoe);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblDamageReason);
            this.Controls.Add(this.lblMaterials);
            this.Name = "frmDamageMaterials";
            this.Load += new System.EventHandler(this.frmDamageMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamageMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaterials;
        private System.Windows.Forms.Label lblDamageReason;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnClsoe;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboMaterials;
        private System.Windows.Forms.TextBox txtDamageReason;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridView dgvDamageMaterials;
        private System.Windows.Forms.Button btnUpdate;
    }
}