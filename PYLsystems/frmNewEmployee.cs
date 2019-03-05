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
    public partial class frmNewEmployee : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmNewEmployee()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            /*  conn.Open();
              string myQuery = "INSERT INTO product(code, name, description, unitprice, quantity, active, unitmeasure) values('" + txtCode.Text + "','" + txtName.Text + "','" + txtDescription.Text + "','" + txtUnitPrice.Text + "','" + txtQuantity.Text + "','" + cboActive.Text + "','" + txtUnitmeasure.Text + "')";
              MySqlCommand myComm = new MySqlCommand(myQuery, conn);
              MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
              DataTable myDt = new DataTable();
              myAdp.Fill(myDt);
              conn.Close();
              MessageBox.Show("Success!");

              this.Close();*/
            if (usernameTextBox.Text == "")
            {
                conn.Open();

                string myQuery = "Insert INTO employee(employeestatus, startofEmployment, firstName, lastName, gender, birthDate, homeAddress, salaryRate, contactNumber) values('" + status.Text + "','" + dtpStartofEmp.Value.Date.ToString("yyyy-MM-dd") + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + cbGender.Text + "','" + dtpBirthDate.Value.Date.ToString("yyyy-MM-dd ") + "','" + txtHomeAddress.Text + "','" + txtSalaryRate.Text + "','" + txtContactNumber.Text + "')";
                MySqlCommand myComm = new MySqlCommand(myQuery, conn);
                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataTable myDt = new DataTable();
                myAdp.Fill(myDt);
                conn.Close();
                MessageBox.Show("New Employee Created");


                this.Close();
            }
            else if(usernameTextBox.Text != "" && passwordTextBox.Text!=""){

                conn.Open();

                string myQuery = "Insert INTO employee(employeestatus, startofEmployment, firstName, lastName, gender, birthDate, homeAddress, salaryRate, contactNumber,username,password) values('" + status.Text + "','" + dtpStartofEmp.Value.Date.ToString("yyyy-MM-dd") + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + cbGender.Text + "','" + dtpBirthDate.Value.Date.ToString("yyyy-MM-dd ") + "','" + txtHomeAddress.Text + "','" + txtSalaryRate.Text + "','" 
                    + txtContactNumber.Text + "','" + usernameTextBox.Text + "','" + passwordTextBox.Text + "')";
                MySqlCommand myComm = new MySqlCommand(myQuery, conn);
                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataTable myDt = new DataTable();
                myAdp.Fill(myDt);
                conn.Close();
                MessageBox.Show("New Employee Created");


                this.Close();
            }
              
        }

        private void frmNewEmployee_Load(object sender, EventArgs e)
        {
            refresh();
            lblwarning.Hide();
            lblwaring1.Hide();
            
        }

        private void cbEmpStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            enable();

            conn.Close();
            conn.Open();
            string query = "SELECT  employeestatus FROM accessworkdesc WHERE employeeposition = '" + cbEmpStatus.Text+ "'";
            MySqlCommand myComm = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            MySqlDataReader reader;
            reader = myComm.ExecuteReader();

            while(reader.Read())
            {
                status.Text = reader.GetString(0);
                
            }

            conn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void enable()
        {
        
            int status = cbEmpStatus.SelectedIndex;
            int lastname = txtLastName.TextLength;
            int firstname = txtFirstName.TextLength;
            int gender = cbGender.SelectedIndex;
            int homeaddress = txtHomeAddress.TextLength;
            int salaryrate = txtSalaryRate.TextLength;
            int contact = txtContactNumber.TextLength;


            if (  gender > -1 && contact > 0 && lastname  > 0 && firstname > 0 && homeaddress > 0 && salaryrate > 0 && contact > 0 && status > -1 )
            {
                btnCreate.Enabled = true;
            }
            else
            
                btnCreate.Enabled = false;
            

        }


        public void refresh()
        {
            try
            {
                conn.Open();
                MySqlCommand sc = new MySqlCommand("select employeeposition from accessworkdesc", conn);
                MySqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("employeeposition ", typeof(string));
                dt.Load(reader);
                cbEmpStatus.ValueMember = "employeeposition";
                cbEmpStatus.DataSource = dt;
                conn.Close();

            }

            catch (Exception) { }
        }

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {
            lblwaring1.Hide();
            enable();
        }

        private void txtSalaryRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

                lblwarning.Show();
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSalaryRate_TextChanged(object sender, EventArgs e)
        {
            enable();
            lblwarning.Hide();
        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

                lblwaring1.Show();
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

          
          
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            enable();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            enable();
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            enable();
        }

        private void txtHomeAddress_TextChanged(object sender, EventArgs e)
        {
            enable();
        }
    }
}
