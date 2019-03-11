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
    public partial class frmArchive : Form
    {
        public static string empid = "";

        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmArchive()
        {
            InitializeComponent();
        }

        private void frmArchive_Load(object sender, EventArgs e)
        {
            reload();
            
        }

        public void reload()
        {
            string query = "SELECT emp.employeeid, emp.lastname, emp.firstname, ac.employeePosition FROM employee emp left join accessworkdesc ac on ac.employeeStatus = emp.employeeStatus  where active = 1";
            //string query = "SELECT  employeeid, lastname, firstname FROM employee";
            MySqlCommand myComm = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            dgEmpList.DataSource = myDt;
            conn.Close();


            dgEmpList.Columns["employeeid"].Visible = false;
            dgEmpList.Columns["lastname"].HeaderText = "Last Name";
            dgEmpList.Columns["firstname"].HeaderText = "First Name";
            dgEmpList.Columns["employeePosition"].HeaderText = "Position";


        }

        private void btnAtive_Click(object sender, EventArgs e)
        {
            string myQuery = "update employee set active = 0 where employeeid = " + emp_id.Text ;
            MySqlCommand myComm = new MySqlCommand(myQuery, conn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            conn.Close();
            MessageBox.Show("Success");
            this.Close();
        }

        public void validate ()
        {
            if (emp_id.Text != "")
            { btnSet.Enabled = true;  }
            else
            {
                btnSet.Enabled = false;
            }

        }

        private void dgEmpList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            emp_id.Text = dgEmpList.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void emp_id_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT emp.employeeid, emp.lastname, emp.firstname, ac.employeePosition FROM employee emp left join accessworkdesc ac on ac.employeeStatus = emp.employeeStatus  where emp.lastname LIKE '%" + txtSearch.Text + "%' OR emp.firstname LIKE '%" + txtSearch.Text + "%' OR ac.employeePosition LIKE '%" + txtSearch.Text + "%' And active = 1";

            //string query = "SELECT   lastname, firstname FROM employee where lastname LIKE '%" + txtSearch.Text + "%' OR firstname LIKE '%" + txtSearch.Text + "%'";
            MySqlCommand myComm = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            dgEmpList.DataSource = myDt;
            conn.Close();

         
        }
    }
}
