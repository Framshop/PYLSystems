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
    public partial class frmEmployeeList : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmEmployeeList()
        {
            InitializeComponent();
        }

        public void reload()
        {
           string query = "SELECT  employeeid, lastname, firstname FROM employee";
            MySqlCommand myComm = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            dgEmpList.DataSource = myDt;
            conn.Close();


            dgEmpList.Columns["employeeid"].Visible = false;
            dgEmpList.Columns["lastname"].HeaderText = "Last Name";
            dgEmpList.Columns["firstname"].HeaderText = "First Name";
           


    

        }

        private void btnNewEmp_Click(object sender, EventArgs e)
        {
            frmNewEmployee newEmp = new frmNewEmployee();
            newEmp.ShowDialog();
            reload();
        }

        private void frmEmployeeList_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void btnViewEmp_Click(object sender, EventArgs e)
        {
            frmViewEmployee empview = new frmViewEmployee();
            empview.empid.Text = dgEmpList.CurrentRow.Cells[0].Value.ToString();
            

         
            empview.ShowDialog();
        }

        private void dgEmpList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            frmUpdateEmployee empupdate = new frmUpdateEmployee();
            empupdate.empid.Text = dgEmpList.CurrentRow.Cells[0].Value.ToString();

            empupdate.ShowDialog();
            reload();

        }

        private void btnEmpList_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
