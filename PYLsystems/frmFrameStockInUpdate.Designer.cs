namespace PYLsystems
{
    partial class frmFrameStockInUpdate
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFrameName = new System.Windows.Forms.Label();
            this.lblStockIn = new System.Windows.Forms.Label();
            this.txtFrameName = new System.Windows.Forms.TextBox();
            this.txtStockIn = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblFrameItemID = new System.Windows.Forms.Label();
            this.cboFrame_materials = new System.Windows.Forms.ComboBox();
            this.cboFixedQuantity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(16, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFrameName
            // 
            this.lblFrameName.AutoSize = true;
            this.lblFrameName.Location = new System.Drawing.Point(13, 42);
            this.lblFrameName.Name = "lblFrameName";
            this.lblFrameName.Size = new System.Drawing.Size(67, 13);
            this.lblFrameName.TabIndex = 1;
            this.lblFrameName.Text = "Frame Name";
            // 
            // lblStockIn
            // 
            this.lblStockIn.AutoSize = true;
            this.lblStockIn.Location = new System.Drawing.Point(13, 68);
            this.lblStockIn.Name = "lblStockIn";
            this.lblStockIn.Size = new System.Drawing.Size(47, 13);
            this.lblStockIn.TabIndex = 2;
            this.lblStockIn.Text = "Stock In";
            // 
            // txtFrameName
            // 
            this.txtFrameName.Enabled = false;
            this.txtFrameName.Location = new System.Drawing.Point(97, 35);
            this.txtFrameName.Name = "txtFrameName";
            this.txtFrameName.Size = new System.Drawing.Size(164, 20);
            this.txtFrameName.TabIndex = 3;
            // 
            // txtStockIn
            // 
            this.txtStockIn.Location = new System.Drawing.Point(97, 61);
            this.txtStockIn.Name = "txtStockIn";
            this.txtStockIn.Size = new System.Drawing.Size(164, 20);
            this.txtStockIn.TabIndex = 4;
            this.txtStockIn.TextChanged += new System.EventHandler(this.txtStockIn_TextChanged);
            this.txtStockIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockIn_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(97, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblFrameItemID
            // 
            this.lblFrameItemID.AutoSize = true;
            this.lblFrameItemID.Enabled = false;
            this.lblFrameItemID.Location = new System.Drawing.Point(299, 25);
            this.lblFrameItemID.Name = "lblFrameItemID";
            this.lblFrameItemID.Size = new System.Drawing.Size(0, 13);
            this.lblFrameItemID.TabIndex = 6;
            this.lblFrameItemID.Visible = false;
            // 
            // cboFrame_materials
            // 
            this.cboFrame_materials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrame_materials.Enabled = false;
            this.cboFrame_materials.FormattingEnabled = true;
            this.cboFrame_materials.Location = new System.Drawing.Point(321, 42);
            this.cboFrame_materials.Name = "cboFrame_materials";
            this.cboFrame_materials.Size = new System.Drawing.Size(121, 21);
            this.cboFrame_materials.TabIndex = 7;
            this.cboFrame_materials.Visible = false;
            // 
            // cboFixedQuantity
            // 
            this.cboFixedQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFixedQuantity.Enabled = false;
            this.cboFixedQuantity.FormattingEnabled = true;
            this.cboFixedQuantity.Location = new System.Drawing.Point(321, 69);
            this.cboFixedQuantity.Name = "cboFixedQuantity";
            this.cboFixedQuantity.Size = new System.Drawing.Size(121, 21);
            this.cboFixedQuantity.TabIndex = 8;
            this.cboFixedQuantity.Visible = false;
            // 
            // frmFrameStockInUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 140);
            this.ControlBox = false;
            this.Controls.Add(this.cboFixedQuantity);
            this.Controls.Add(this.cboFrame_materials);
            this.Controls.Add(this.lblFrameItemID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtStockIn);
            this.Controls.Add(this.txtFrameName);
            this.Controls.Add(this.lblStockIn);
            this.Controls.Add(this.lblFrameName);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmFrameStockInUpdate";
            this.Text = "Frame Stock In Update";
            this.Load += new System.EventHandler(this.frmFrameStockInUpdate_Load);
            this.MouseHover += new System.EventHandler(this.frmFrameStockInUpdate_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFrameName;
        private System.Windows.Forms.Label lblStockIn;
        private System.Windows.Forms.TextBox txtStockIn;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Label lblFrameItemID;
        public System.Windows.Forms.TextBox txtFrameName;
        public System.Windows.Forms.ComboBox cboFrame_materials;
        public System.Windows.Forms.ComboBox cboFixedQuantity;
    }
}