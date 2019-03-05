namespace PYLsystems
{
    partial class frmDamageItems
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
            this.txtDamageReason = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cboFrameName = new System.Windows.Forms.ComboBox();
            this.lblFrameName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDamageReason = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblFrameItemID = new System.Windows.Forms.Label();
            this.dgvDamageItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamageItems)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDamageReason
            // 
            this.txtDamageReason.Location = new System.Drawing.Point(179, 71);
            this.txtDamageReason.Multiline = true;
            this.txtDamageReason.Name = "txtDamageReason";
            this.txtDamageReason.Size = new System.Drawing.Size(249, 85);
            this.txtDamageReason.TabIndex = 7;
            this.txtDamageReason.TextChanged += new System.EventHandler(this.txtDamageReason_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(179, 45);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(249, 20);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // cboFrameName
            // 
            this.cboFrameName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrameName.FormattingEnabled = true;
            this.cboFrameName.Location = new System.Drawing.Point(179, 18);
            this.cboFrameName.Name = "cboFrameName";
            this.cboFrameName.Size = new System.Drawing.Size(249, 21);
            this.cboFrameName.TabIndex = 3;
            this.cboFrameName.SelectedIndexChanged += new System.EventHandler(this.cboFrameName_SelectedIndexChanged);
            // 
            // lblFrameName
            // 
            this.lblFrameName.AutoSize = true;
            this.lblFrameName.Location = new System.Drawing.Point(12, 26);
            this.lblFrameName.Name = "lblFrameName";
            this.lblFrameName.Size = new System.Drawing.Size(67, 13);
            this.lblFrameName.TabIndex = 4;
            this.lblFrameName.Text = "Frame Name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 52);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblDamageReason
            // 
            this.lblDamageReason.AutoSize = true;
            this.lblDamageReason.Location = new System.Drawing.Point(12, 108);
            this.lblDamageReason.Name = "lblDamageReason";
            this.lblDamageReason.Size = new System.Drawing.Size(87, 13);
            this.lblDamageReason.TabIndex = 8;
            this.lblDamageReason.Text = "Damage Reason";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Lime;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(15, 172);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(96, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(227, 237);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(0, 13);
            this.lblEmployeeID.TabIndex = 14;
            // 
            // lblFrameItemID
            // 
            this.lblFrameItemID.AutoSize = true;
            this.lblFrameItemID.Location = new System.Drawing.Point(323, 216);
            this.lblFrameItemID.Name = "lblFrameItemID";
            this.lblFrameItemID.Size = new System.Drawing.Size(0, 13);
            this.lblFrameItemID.TabIndex = 15;
            // 
            // dgvDamageItems
            // 
            this.dgvDamageItems.AllowUserToAddRows = false;
            this.dgvDamageItems.AllowUserToDeleteRows = false;
            this.dgvDamageItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDamageItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDamageItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamageItems.Location = new System.Drawing.Point(456, 26);
            this.dgvDamageItems.Name = "dgvDamageItems";
            this.dgvDamageItems.ReadOnly = true;
            this.dgvDamageItems.Size = new System.Drawing.Size(481, 204);
            this.dgvDamageItems.TabIndex = 16;
            // 
            // frmDamageItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(949, 242);
            this.ControlBox = false;
            this.Controls.Add(this.dgvDamageItems);
            this.Controls.Add(this.lblFrameItemID);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDamageReason);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblFrameName);
            this.Controls.Add(this.cboFrameName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDamageReason);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDamageItems";
            this.Text = "Damage Items";
            this.Load += new System.EventHandler(this.frmDamageItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamageItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDamageReason;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cboFrameName;
        private System.Windows.Forms.Label lblFrameName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDamageReason;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblFrameItemID;
        private System.Windows.Forms.DataGridView dgvDamageItems;
    }
}