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
        public frmUpdateEmployee()
        {
            InitializeComponent();
        }

        private void frmUpdateEmployee_Load(object sender, EventArgs e)
        {

            reload();
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


        public void reload()
        {
            conn.Close();
            conn.Open();
            string query = "SELECT  * FROM employee emp left join accessworkdesc ac on ac.employeeStatus = emp.employeeStatus WHERE employeeid = '" + empid.Text + "'";
            MySqlCommand myComm = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            MySqlDataReader reader;
            reader = myComm.ExecuteReader();


            while (reader.Read())
            {
                string position = reader.GetString(13);
                string startofEmp = reader.GetString(2);
                string firstname = reader.GetString(3);
                string lastname = reader.GetString(4);
                string gender = reader.GetString(5);
                string birthdate = reader.GetString(6);
                string homeaddress = reader.GetString(7);
                string salaryrate = reader.GetString(8);
                string contactnumber = reader.GetString(9);
                string username="";
                string password="";
                if (reader.IsDBNull(10))
                {
                    username = "";

                }
                else if (reader.IsDBNull(11))
                {
                    password = "";
                }
                else if (reader.IsDBNull(10) && reader.IsDBNull(11)) {
                    username = "";
                    password = "";
                }
                else
                {
                    username = reader.GetString(10);
                    password = reader.GetString(11);
                }

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

                empid.Text = reader.GetString(0);

            }

            conn.Close();

        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == this.username && passwordTextBox.Text == this.password) { 
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
            else{
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

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbEmpStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
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


        }

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
    

