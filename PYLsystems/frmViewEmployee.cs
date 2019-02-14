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

namespace Employee_Management
{
    public partial class frmViewEmployee : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=");
        public frmViewEmployee()
        {
            InitializeComponent();
        }

        private void frmViewEmployee_Load(object sender, EventArgs e)
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


                lblEmpStatus.Text = position;
                lblStartofEmp.Text = startofEmp.Substring(0, 9);
                lblFirstName.Text = firstname;
                lblLastName.Text = lastname+",";
                lblGender.Text = gender;
                lblBirthDate.Text = birthdate.Substring(0, 9);
                lblHomeAddress.Text = homeaddress;
                lblSalaryRate.Text = salaryrate;
                lblContactNumber.Text = contactnumber;

                empid.Text = reader.GetString(0);

            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnUpload_Click(object sender, EventArgs e)
        //{
        //    string imageLocation = "";
        //    try
        //    {
        //        OpenFileDialog dialog = new OpenFileDialog();
        //        dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

        //        if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //        {
        //            imageLocation = dialog.FileName;
        //            pic1.ImageLocation = imageLocation;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}

