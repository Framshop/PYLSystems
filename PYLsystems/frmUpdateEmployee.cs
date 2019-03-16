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
    public partial class frmUpdateEmployee : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        private String username;
        private String password;
        int genderindex;
        int statusindex;
        public frmUpdateEmployee()
        {
            InitializeComponent();
            empstatusList();
        }

        public void empstatusList()
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
        private void frmUpdateEmployee_Load(object sender, EventArgs e)
        {
           // enable();
            reload();
            try
            {
              

            }

            catch (Exception) { }

            // enable();
            statusindex = cbEmpStatus.SelectedIndex;
            genderindex = cbGender.SelectedIndex;
            cbEmpStatus.Enabled = true;
            cbGender.Enabled = true;
            txtContactNumber.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtSalaryRate.Enabled = true;
            txtHomeAddress.Enabled = true;
            usernameTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
            dtpBirthDate.Enabled = true;
            dtpStartofEmp.Enabled = true;


        }


        public void reload()
        {
       
            conn.Open();
            try
            {
                string query = "SELECT  * FROM employee emp left join accessworkdesc ac on ac.employeeStatus = emp.employeeStatus WHERE employeeid = '" + empid.Text + "'";
                MySqlCommand myComm = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = myComm.ExecuteReader();
                while (reader.Read())
                {
                    string position = reader.GetString(14);
                    string startofEmp = reader.GetString(2);
                    string firstname = reader.GetString(3);
                    string lastname = reader.GetString(4);
                    string gender = reader.GetString(5);
                    string birthdate = reader.GetString(6);
                    string homeaddress = reader.GetString(7);
                    string salaryrate = reader.GetString(8);
                    string contactnumber = reader.GetString(9);
                    string username = "";
                    string password = "";
                    if (reader.IsDBNull(10))
                    {
                        username = "";

                    }
                    else if (reader.IsDBNull(11))
                    {
                        password = "";
                    }
                    else if (reader.IsDBNull(10) && reader.IsDBNull(11))
                    {
                        username = "";
                        password = "";
                    }
                    else
                    {
                        username = reader.GetString(10);
                        password = reader.GetString(11);
                    }
                    //if( position == "Owner" || position == "Owner/Programmer" )
                    //{
                    //    cbEmpStatus.SelectedIndex = 0;
                    //}
                    //else if (position == "Management" || position == "Management Staff")
                    //{
                    //    cbEmpStatus.SelectedIndex = 1;
                    //}
                    //  else  if (position == "Cashier" || position == "Cashier")
                    //{
                    //    cbEmpStatus.SelectedIndex = 2;
                    //}
                    ////else 
                    ////{
                    ////    cbEmpStatus.SelectedIndex = 3;
                    ////}

                    cbEmpStatus.Text = position;
                    dtpStartofEmp.Text = startofEmp;
                    txtFirstName.Text = firstname;
                    txtLastName.Text = lastname;
                    cbGender.Text = gender;
                    dtpBirthDate.Text = birthdate;
                    txtHomeAddress.Text = homeaddress;
                    txtSalaryRate.Text = salaryrate;
                    txtContactNumber.Text = contactnumber;
                    usernameTextBox.Text = username;
                    passwordTextBox.Text = password;
                    this.username = username;
                    this.password = password;

                    // empid.Text = reader.GetString(0);

                }
            }
            catch { }
            conn.Close();

        }

        //private void btnUpdateEmp_Click(object sender, EventArgs e)
        //{
        //    if (usernameTextBox.Text == this.username && passwordTextBox.Text == this.password) { 
        //        conn.Open();

        //        // string myQuery = "UPDATE product SET code = '" + txtEditCode.Text + "',name =  '" + txtEditName.Text + "', description = '" + txtEditDescription.Text + "', unitprice = '" + txtEditUnitPrice.Text + "',quantity =  '" + txtEditQuantity.Text + "',active = '" + cboEditActive.Text + "',unitmeasure = '" + txtEditUnitmeasure.Text + "' WHERE code = '" + code.Text + "'AND name = '" + name.Text + "'AND description = '" + description.Text + "'AND unitprice = '" + unitprice.Text + "'";

        //        string myQuery = "UPDATE employee set employeeStatus ='" + status.Text + "', startofEmployment = '" + dtpStartofEmp.Value.Date.ToString("yyyy-MM-dd") + "', firstName ='" + txtFirstName.Text + "',lastName ='" + txtLastName.Text + "', gender= '" + cbGender.Text + "', birthDate= '" + dtpBirthDate.Value.Date.ToString("yyyy-MM-dd ") + "', homeAddress= '" + txtHomeAddress.Text + "', salaryRate= " + txtSalaryRate.Text + ", contactNumber= '" + txtContactNumber.Text + "' WHERE employeeid ='" + empid.Text + "'";
        //        MySqlCommand myComm = new MySqlCommand(myQuery, conn);
        //        MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
        //        DataTable myDt = new DataTable();
        //        myAdp.Fill(myDt);
        //        conn.Close();
        //        MessageBox.Show("Update Success");
        //        this.Close();
        //    }
        //    else{
        //        conn.Open();

        //        // string myQuery = "UPDATE product SET code = '" + txtEditCode.Text + "',name =  '" + txtEditName.Text + "', description = '" + txtEditDescription.Text + "', unitprice = '" + txtEditUnitPrice.Text + "',quantity =  '" + txtEditQuantity.Text + "',active = '" + cboEditActive.Text + "',unitmeasure = '" + txtEditUnitmeasure.Text + "' WHERE code = '" + code.Text + "'AND name = '" + name.Text + "'AND description = '" + description.Text + "'AND unitprice = '" + unitprice.Text + "'";

        //        String myQuery = "UPDATE employee set employeeStatus ='" + status.Text + "', startofEmployment = '" + dtpStartofEmp.Value.Date.ToString("yyyy-MM-dd") + "', firstName ='" + txtFirstName.Text + "',lastName ='" + txtLastName.Text 
        //            + "', gender= '" + cbGender.Text + "', birthDate= '" + dtpBirthDate.Value.Date.ToString("yyyy-MM-dd ") 
        //            + "', homeAddress= '" + txtHomeAddress.Text + "', salaryRate= " + txtSalaryRate.Text 
        //            + ", contactNumber= '" + txtContactNumber.Text
        //            + "', username= '" + usernameTextBox.Text
        //            + "', password= '" + passwordTextBox.Text
        //            + "' WHERE employeeid ='" + empid.Text + "'";
        //        MySqlCommand myComm = new MySqlCommand(myQuery, conn);
        //        MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
        //        DataTable myDt = new DataTable();
        //        myAdp.Fill(myDt);
        //        conn.Close();
        //        MessageBox.Show("Update Success -- username and password updated");
        //        this.Close();
        //    }

        //}

        //private void btCancel_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void cbEmpStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Close();
            
            conn.Open();
            try
            {
                string query = "SELECT  employeestatus FROM accessworkdesc WHERE employeeposition = '" + cbEmpStatus.Text + "'";
                MySqlCommand myComm = new MySqlCommand(query, conn);
                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                MySqlDataReader reader;
                reader = myComm.ExecuteReader();

                while (reader.Read())
                {
                    status.Text = reader.GetString(0);

                }
                conn.Close();
                if (dtpStartofEmp.Enabled)
                    enable();
                if (!dtpStartofEmp.Enabled)
                {
                    dtpStartofEmp.Enabled = true;
                }
            }
            catch { }
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
            int txtCounter=0;
            int cbCounter = 0;

            //if (gender > -1 && contact > 0 && lastname > 0 && firstname > 0 && homeaddress > 0 && salaryrate > 0 && contact > 0 && status > -1)
            //{
            //    btnEmpUpdate.Enabled = true;
            //}
            
            if (gender != genderindex)
               txtCounter++;
            if (contact > 0)
                txtCounter++;
            if (lastname > 0)
                txtCounter++;
            if (firstname > 0)
                txtCounter++;
            if (homeaddress > 0)
                txtCounter++;
            if (salaryrate > 0)
                txtCounter++;
            if (contact > 0)
                txtCounter++;
            if (status != statusindex)
                txtCounter++;

            //if(gee)
            if (lastname == 0)
                txtCounter = 0;

            if (firstname == 0)
                txtCounter = 0;

            if (homeaddress == 0)
                txtCounter = 0;

            if (salaryrate == 0)
                txtCounter = 0;

            if (contact == 0)
                txtCounter = 0;
            //if (status == statusindex)
            //    counter = 0;
            //if (gender == genderindex)
            //    counter = 0;

            if (txtCounter>0)
                btnEmpUpdate.Enabled = true;
            else
                btnEmpUpdate.Enabled = false;
        //    MessageBox.Show(txtCounter + "");


        }

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {
            lblwaring1.Hide();
            if(txtContactNumber.Enabled)
                enable();
        }

        private void txtSalaryRate_TextChanged(object sender, EventArgs e)
        {
            lblwarning.Hide();
            if(txtSalaryRate.Enabled)
            enable();
        }

        private void txtSalaryRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            //enable();
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

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //enable();
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

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if(txtFirstName.Enabled)
                enable();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Enabled)
                enable();
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.Enabled) { 
                enable();
            }
        }

        private void txtHomeAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtHomeAddress.Enabled)
            {
                enable();
            }
        }

        private void cbGender_SelectedValueChanged(object sender, EventArgs e)
        {
           if(cbGender.Enabled)
                enable();
        }

        private void btnEmpUpdate_Click(object sender, EventArgs e)
        {
        
                if (usernameTextBox.Text == this.username && passwordTextBox.Text == this.password)
                {
                    conn.Open();

                    // string myQuery = "UPDATE product SET code = '" + txtEditCode.Text + "',name =  '" + txtEditName.Text + "', description = '" + txtEditDescription.Text + "', unitprice = '" + txtEditUnitPrice.Text + "',quantity =  '" + txtEditQuantity.Text + "',active = '" + cboEditActive.Text + "',unitmeasure = '" + txtEditUnitmeasure.Text + "' WHERE code = '" + code.Text + "'AND name = '" + name.Text + "'AND description = '" + description.Text + "'AND unitprice = '" + unitprice.Text + "'";

                    string myQuery = "UPDATE employee set employeeStatus ='" + status.Text + "', startofEmployment = '" + dtpStartofEmp.Value.Date.ToString("yyyy-MM-dd") + "', firstName ='" + txtFirstName.Text + "',lastName ='" + txtLastName.Text + "', gender= '" + cbGender.Text + "', birthDate= '" + dtpBirthDate.Value.Date.ToString("yyyy-MM-dd ") + "', homeAddress= '" + txtHomeAddress.Text + "', salaryRate= " + txtSalaryRate.Text + ", contactNumber= '" + txtContactNumber.Text + "' WHERE employeeid ='" + empid.Text + "'";
                    MySqlCommand myComm = new MySqlCommand(myQuery, conn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    conn.Close();
                    MessageBox.Show("Update Success");
                    this.Close();
                }
                else
                {
                    conn.Open();

                    // string myQuery = "UPDATE product SET code = '" + txtEditCode.Text + "',name =  '" + txtEditName.Text + "', description = '" + txtEditDescription.Text + "', unitprice = '" + txtEditUnitPrice.Text + "',quantity =  '" + txtEditQuantity.Text + "',active = '" + cboEditActive.Text + "',unitmeasure = '" + txtEditUnitmeasure.Text + "' WHERE code = '" + code.Text + "'AND name = '" + name.Text + "'AND description = '" + description.Text + "'AND unitprice = '" + unitprice.Text + "'";

                    String myQuery = "UPDATE employee set employeeStatus ='" + status.Text + "', startofEmployment = '" + dtpStartofEmp.Value.Date.ToString("yyyy-MM-dd") + "', firstName ='" + txtFirstName.Text + "',lastName ='" + txtLastName.Text
                        + "', gender= '" + cbGender.Text + "', birthDate= '" + dtpBirthDate.Value.Date.ToString("yyyy-MM-dd ")
                        + "', homeAddress= '" + txtHomeAddress.Text + "', salaryRate= " + txtSalaryRate.Text
                        + ", contactNumber= '" + txtContactNumber.Text
                        + "', username= '" + usernameTextBox.Text
                        + "', password= '" + passwordTextBox.Text
                        + "' WHERE employeeid ='" + empid.Text + "'";
                    MySqlCommand myComm = new MySqlCommand(myQuery, conn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    conn.Close();
                    MessageBox.Show("Update Success -- username and password updated");
                    this.Close();
                }
            }
         
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //enable();
        }

        private void dtpBirthDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            //enable();
        }

        private void dtpStartofEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //enable();
        }

        private void txtHomeAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            //enable();
        }
    }
}
    

