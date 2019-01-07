namespace PYLsystems
{
    partial class addSales
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnsGB = new System.Windows.Forms.GroupBox();
            this.AddSalesGB = new System.Windows.Forms.GroupBox();
            this.addSalesGrid = new System.Windows.Forms.DataGridView();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.btnsGB.SuspendLayout();
            this.AddSalesGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addSalesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddSalesGB, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.59731F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.40269F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1055, 745);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.34319F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.65681F));
            this.tableLayoutPanel2.Controls.Add(this.btnsGB, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 595);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1049, 147);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnsGB
            // 
            this.btnsGB.Controls.Add(this.cancelBtn);
            this.btnsGB.Controls.Add(this.confirmBtn);
            this.btnsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsGB.Location = new System.Drawing.Point(636, 3);
            this.btnsGB.Name = "btnsGB";
            this.btnsGB.Size = new System.Drawing.Size(410, 141);
            this.btnsGB.TabIndex = 0;
            this.btnsGB.TabStop = false;
            // 
            // AddSalesGB
            // 
            this.AddSalesGB.Controls.Add(this.addSalesGrid);
            this.AddSalesGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddSalesGB.Location = new System.Drawing.Point(3, 3);
            this.AddSalesGB.Name = "AddSalesGB";
            this.AddSalesGB.Size = new System.Drawing.Size(1049, 586);
            this.AddSalesGB.TabIndex = 1;
            this.AddSalesGB.TabStop = false;
            this.AddSalesGB.Text = "New Sales Order";
            // 
            // addSalesGrid
            // 
            this.addSalesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addSalesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addSalesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSalesGrid.Location = new System.Drawing.Point(3, 22);
            this.addSalesGrid.Name = "addSalesGrid";
            this.addSalesGrid.RowHeadersVisible = false;
            this.addSalesGrid.RowTemplate.Height = 28;
            this.addSalesGrid.Size = new System.Drawing.Size(1043, 561);
            this.addSalesGrid.TabIndex = 0;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(233, 36);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(130, 37);
            this.confirmBtn.TabIndex = 1;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(75, 36);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 37);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 745);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "addSales";
            this.Text = "AddSales";
            this.Load += new System.EventHandler(this.addSales_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.btnsGB.ResumeLayout(false);
            this.AddSalesGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addSalesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox btnsGB;
        private System.Windows.Forms.GroupBox AddSalesGB;
        private System.Windows.Forms.DataGridView addSalesGrid;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
    }
}

