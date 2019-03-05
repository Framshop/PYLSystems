using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PYLsystems
{
    public partial class frmCustomerAccount : Form
    {
        public static string customerID = "";
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmCustomerAccount()
        {
            InitializeComponent();
        }

        private void frmCustomerAccount_Load(object sender, EventArgs e)
        {
            RefreshDatabase();
        }
        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT customerID,customerFullName,contactPerson,if(gender=1,'Female','Male') as 'gender',emailAddress,homeAddress FROM customer_account";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            dgvCustomerAccount.DataSource = Dt;
            myConn.Close();
            dgvCustomerAccount.Columns["customerID"].Visible = false;
            dgvCustomerAccount.Columns["customerID"].HeaderText = "ID";
            dgvCustomerAccount.Columns["customerFullName"].HeaderText = "Full Name";
            dgvCustomerAccount.Columns["contactPerson"].HeaderText = "Contact Person";
            dgvCustomerAccount.Columns["emailAddress"].HeaderText = "Email Address";
            dgvCustomerAccount.Columns["homeAddress"].HeaderText = "Home Address";
            dgvCustomerAccount.Columns["gender"].HeaderText = "Gender";
            //dgvCustomerAccount.Columns["balance"].HeaderText = "Balance";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            functionEmailValidation();
            myConn.Open();
            MySqlDataAdapter myAd;
            DataTable myD = new DataTable();
            MySqlCommand myCom = new MySqlCommand("SELECT * FROM customer_account WHERE customerFullName = '" + txtFullName.Text + "'", myConn);
            myAd = new MySqlDataAdapter(myCom);
            //ADD ----------
            MySqlDataReader myReader;
            myAd.Fill(myD);
            //ADD
            myReader = myCom.ExecuteReader();
            myConn.Close();
            if (myD.Rows.Count == 0)
            {
                myConn.Open();
                string myQuery = "INSERT INTO customer_account (customerFullName, contactPerson, emailAddress, homeAddress, gender) values('" + txtFullName.Text + "','" + msktxtContactPerson.Text + "','" + txtEmailAddress.Text + "','" + txtHomeAddress.Text + "','" + cboGender.SelectedIndex + "')";
                MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataTable myDt = new DataTable();
                myAdp.Fill(myDt);
                myConn.Close();
                MessageBox.Show("Insert Successful!");
                RefreshDatabase();
                txtEmailAddress.Text = "";
                txtHomeAddress.Text = "";
                msktxtContactPerson.Text = "";
                txtFullName.Text = "";
                cboGender.SelectedIndex = -1;
                msktxtContactPerson.Text = "";
                lblValidate.Text = "";

            }
            else
            {
                lblValidate.Text = "Customer name already exist!";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            functionEmailValidation();
            myConn.Open();
            string myQuery = "UPDATE customer_account SET customerFullName = '" + txtFullName.Text + "', contactPerson =  " +
                "'" + msktxtContactPerson.Text + "', emailAddress = '" + txtEmailAddress.Text + "', homeAddress = '" + txtHomeAddress.Text + "', gender = '" + cboGender.SelectedIndex + "' WHERE customerID = " + customerID;
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            myConn.Close();
            MessageBox.Show("Update Successful!");
            RefreshDatabase();

            txtEmailAddress.Text = "";
            txtHomeAddress.Text = "";
            txtFullName.Text = "";
            cboGender.SelectedIndex = -1;
            msktxtContactPerson.Text = "";
            btnUpdate.Enabled = false;
            lblValidate.Text = "";
        }

        private void dgvCustomerAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnPay.Enabled = true;
            lblCustomerAccountID.Text = dgvCustomerAccount.CurrentRow.Cells[0].Value.ToString();
            customerID = dgvCustomerAccount.CurrentRow.Cells[0].Value.ToString();
            txtFullName.Text = dgvCustomerAccount.CurrentRow.Cells[1].Value.ToString();
            msktxtContactPerson.Text = dgvCustomerAccount.CurrentRow.Cells[2].Value.ToString();
            txtEmailAddress.Text = dgvCustomerAccount.CurrentRow.Cells[4].Value.ToString();
            txtHomeAddress.Text = dgvCustomerAccount.CurrentRow.Cells[5].Value.ToString();
            cboGender.Text = dgvCustomerAccount.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void functionAdd()
        {
            int fullname = txtFullName.TextLength;
            int contactperson = msktxtContactPerson.TextLength;
            int emailaddress = txtEmailAddress.TextLength;
            int homeaddress = txtHomeAddress.TextLength;
            int gender = cboGender.SelectedIndex;
            if (fullname > 0 && contactperson > 10 && homeaddress > 0 && gender > -1)
            {
                btnAdd.Enabled = true;
            }
            else
            {  
                btnAdd.Enabled = false;
                
            }
        }

        public void functionUpdate()
        {
            if (lblCustomerAccountID.Text != "")
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }
        public void functionEmailValidation()
        {
            if (!this.txtEmailAddress.Text.Contains('@') || !this.txtEmailAddress.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            functionAdd();
            functionUpdate();
        }

        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtHomeAddress_TextChanged(object sender, EventArgs e)
        {
            functionAdd();
            functionUpdate();
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {
            functionAdd();
            functionUpdate();
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            functionAdd();
            functionUpdate();
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            myConn.Open();
            string query = "SELECT customerID,customerFullName,contactPerson,if(gender=1,'Female','Male') as 'gender',emailAddress,homeAddress FROM customer_account WHERE customerFullName LIKE '%" + txtSearch.Text + "%' OR contactPerson LIKE '%" + txtSearch.Text + "%' OR gender LIKE '%" + txtSearch.Text + "%' OR homeAddress LIKE '%" + txtSearch.Text + "%'";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            dgvCustomerAccount.DataSource = Dt;
            myConn.Close();
            dgvCustomerAccount.Columns["customerID"].Visible = false;
            dgvCustomerAccount.Columns["customerID"].HeaderText = "ID";
            dgvCustomerAccount.Columns["customerFullName"].HeaderText = "Full Name";
            dgvCustomerAccount.Columns["contactPerson"].HeaderText = "Contact Person";
            dgvCustomerAccount.Columns["emailAddress"].HeaderText = "Email Address";
            dgvCustomerAccount.Columns["homeAddress"].HeaderText = "Home Address";
            dgvCustomerAccount.Columns["gender"].HeaderText = "Gender";
        }

        private void txtEmailAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '@') && ((sender as TextBox).Text.IndexOf('@') > -1))
            {
                e.Handled = true;
            }
        }
        private void dgvCustomerAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            frmCustomerPayment customerPayment = new frmCustomerPayment();
            customerPayment.lblCustomerID.Text = dgvCustomerAccount.CurrentRow.Cells[0].Value.ToString();
            customerPayment.txtCustomerName.Text = dgvCustomerAccount.CurrentRow.Cells[1].Value.ToString();
            customerPayment.ShowDialog();
        }
    }
}
