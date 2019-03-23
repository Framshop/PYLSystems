namespace PYLsystems
{
    partial class frmArchiveSupplytItem
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
            this.dgSupplyItem = new System.Windows.Forms.DataGridView();
            this.supplierID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplyItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgSupplyItem
            // 
            this.dgSupplyItem.AllowUserToAddRows = false;
            this.dgSupplyItem.AllowUserToDeleteRows = false;
            this.dgSupplyItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSupplyItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgSupplyItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSupplyItem.Location = new System.Drawing.Point(9, 29);
            this.dgSupplyItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgSupplyItem.Name = "dgSupplyItem";
            this.dgSupplyItem.ReadOnly = true;
            this.dgSupplyItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSupplyItem.Size = new System.Drawing.Size(956, 451);
            this.dgSupplyItem.TabIndex = 0;
            this.dgSupplyItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSupplyItem_CellClick);
            // 
            // supplierID
            // 
            this.supplierID.AutoSize = true;
            this.supplierID.Location = new System.Drawing.Point(1365, 363);
            this.supplierID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supplierID.Name = "supplierID";
            this.supplierID.Size = new System.Drawing.Size(51, 20);
            this.supplierID.TabIndex = 11;
            this.supplierID.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(682, 32);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(284, 26);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.PaleGreen;
            this.btnClose.Location = new System.Drawing.Point(258, 555);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.PaleGreen;
            this.btnReturn.Enabled = false;
            this.btnReturn.Location = new System.Drawing.Point(16, 555);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(232, 37);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return to Supply Item List";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgSupplyItem);
            this.groupBox1.Location = new System.Drawing.Point(8, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(974, 488);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Archived Item Supply List";
            // 
            // frmArchiveSupplytItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(988, 603);
            this.Controls.Add(this.supplierID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArchiveSupplytItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmArchiveSupplytItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplyItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSupplyItem;
        private System.Windows.Forms.Label supplierID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}