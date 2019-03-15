namespace PYLsystems
{
    partial class frmCustomerAccount
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblCustomerFullName = new System.Windows.Forms.Label();
            this.lblContactPerson = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblHomeAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvCustomerAccount = new System.Windows.Forms.DataGridView();
            this.msktxtContactPerson = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerAccountID = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblValidate = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerAccount)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(149, 72);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(148, 20);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Location = new System.Drawing.Point(149, 171);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(148, 20);
            this.txtHomeAddress.TabIndex = 6;
            this.txtHomeAddress.TextChanged += new System.EventHandler(this.txtHomeAddress_TextChanged);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(149, 145);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(148, 20);
            this.txtEmailAddress.TabIndex = 4;
            this.txtEmailAddress.TextChanged += new System.EventHandler(this.txtEmailAddress_TextChanged);
            this.txtEmailAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmailAddress_KeyPress);
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(149, 197);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(148, 21);
            this.cboGender.TabIndex = 10;
            this.cboGender.SelectedIndexChanged += new System.EventHandler(this.cboGender_SelectedIndexChanged);
            // 
            // lblCustomerFullName
            // 
            this.lblCustomerFullName.AutoSize = true;
            this.lblCustomerFullName.Location = new System.Drawing.Point(22, 78);
            this.lblCustomerFullName.Name = "lblCustomerFullName";
            this.lblCustomerFullName.Size = new System.Drawing.Size(54, 13);
            this.lblCustomerFullName.TabIndex = 1;
            this.lblCustomerFullName.Text = "Full Name";
            // 
            // lblContactPerson
            // 
            this.lblContactPerson.AutoSize = true;
            this.lblContactPerson.Location = new System.Drawing.Point(22, 105);
            this.lblContactPerson.Name = "lblContactPerson";
            this.lblContactPerson.Size = new System.Drawing.Size(84, 13);
            this.lblContactPerson.TabIndex = 3;
            this.lblContactPerson.Text = "Contact Number";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(22, 152);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(73, 13);
            this.lblEmailAddress.TabIndex = 5;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // lblHomeAddress
            // 
            this.lblHomeAddress.AutoSize = true;
            this.lblHomeAddress.Location = new System.Drawing.Point(22, 178);
            this.lblHomeAddress.Name = "lblHomeAddress";
            this.lblHomeAddress.Size = new System.Drawing.Size(76, 13);
            this.lblHomeAddress.TabIndex = 7;
            this.lblHomeAddress.Text = "Home Address";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(22, 205);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(25, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(106, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvCustomerAccount
            // 
            this.dgvCustomerAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerAccount.Location = new System.Drawing.Point(344, 3);
            this.dgvCustomerAccount.Name = "dgvCustomerAccount";
            this.dgvCustomerAccount.Size = new System.Drawing.Size(681, 419);
            this.dgvCustomerAccount.TabIndex = 17;
            this.dgvCustomerAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerAccount_CellClick);
            this.dgvCustomerAccount.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerAccount_CellDoubleClick);
            // 
            // msktxtContactPerson
            // 
            this.msktxtContactPerson.Location = new System.Drawing.Point(149, 98);
            this.msktxtContactPerson.Mask = "00000000000";
            this.msktxtContactPerson.Name = "msktxtContactPerson";
            this.msktxtContactPerson.PromptChar = ' ';
            this.msktxtContactPerson.Size = new System.Drawing.Size(148, 20);
            this.msktxtContactPerson.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.22751F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.77248F));
            this.tableLayoutPanel1.Controls.Add(this.dgvCustomerAccount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpInfo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 425);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnPay);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.lblCustomerAccountID);
            this.grpInfo.Controls.Add(this.txtSearch);
            this.grpInfo.Controls.Add(this.lblSearch);
            this.grpInfo.Controls.Add(this.lblValidate);
            this.grpInfo.Controls.Add(this.btnCancel);
            this.grpInfo.Controls.Add(this.msktxtContactPerson);
            this.grpInfo.Controls.Add(this.lblContactPerson);
            this.grpInfo.Controls.Add(this.btnUpdate);
            this.grpInfo.Controls.Add(this.txtFullName);
            this.grpInfo.Controls.Add(this.btnAdd);
            this.grpInfo.Controls.Add(this.lblGender);
            this.grpInfo.Controls.Add(this.txtHomeAddress);
            this.grpInfo.Controls.Add(this.txtEmailAddress);
            this.grpInfo.Controls.Add(this.lblHomeAddress);
            this.grpInfo.Controls.Add(this.cboGender);
            this.grpInfo.Controls.Add(this.lblEmailAddress);
            this.grpInfo.Controls.Add(this.lblCustomerFullName);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInfo.Location = new System.Drawing.Point(3, 3);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(335, 419);
            this.grpInfo.TabIndex = 15;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(149, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Optional";
            // 
            // lblCustomerAccountID
            // 
            this.lblCustomerAccountID.AutoSize = true;
            this.lblCustomerAccountID.Location = new System.Drawing.Point(32, 47);
            this.lblCustomerAccountID.Name = "lblCustomerAccountID";
            this.lblCustomerAccountID.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerAccountID.TabIndex = 17;
            this.lblCustomerAccountID.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(149, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(148, 20);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(102, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search";
            // 
            // lblValidate
            // 
            this.lblValidate.AutoSize = true;
            this.lblValidate.ForeColor = System.Drawing.Color.Red;
            this.lblValidate.Location = new System.Drawing.Point(29, 274);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(0, 13);
            this.lblValidate.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(25, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.Enabled = false;
            this.btnPay.Location = new System.Drawing.Point(107, 294);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 19;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // frmCustomerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 425);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmCustomerAccount";
            this.Text = "Customer Account";
            this.Load += new System.EventHandler(this.frmCustomerAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerAccount)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblCustomerFullName;
        private System.Windows.Forms.Label lblContactPerson;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblHomeAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvCustomerAccount;
        private System.Windows.Forms.MaskedTextBox msktxtContactPerson;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblValidate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCustomerAccountID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPay;
    }
}