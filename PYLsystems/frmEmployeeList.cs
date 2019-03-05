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
        int employeeId;
        int employeeStatus;
        public frmEmployeeList()
        {
            InitializeComponent();
            /*------temporary. to be erased when combine employee management------*/
            this.employeeId = 1;
            this.employeeStatus = 1;
        }
        public frmEmployeeList(int employeeId, int employeeStatus) {
            InitializeComponent();
            this.employeeId = employeeId;
            this.employeeStatus = employeeStatus;
        }
        public void reload()
        {
            string query = "SELECT emp.employeeid, emp.lastname, emp.firstname, ac.employeePosition FROM employee emp left join accessworkdesc ac on ac.employeeStatus = emp.employeeStatus ";
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
        private employeeDetailsObj getSelectedEmpDetails() {
            int selectedEmpID;
            int rowIndex = dgEmpList.SelectedRows[0].Index;
            selectedEmpID = Int32.Parse(dgEmpList.Rows[rowIndex].Cells[0].Value.ToString());
            employeeDetailsObj selectedEmpDet = new employeeDetailsObj(this.employeeId,this.employeeStatus,selectedEmpID);
            return selectedEmpDet;
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

        private void viewAttendance_Click(object sender, EventArgs e)
        {
            int employeeID=getSelectedEmpDetails().employeeID;
            int employeeStatus = getSelectedEmpDetails().employeeStatus;
            int selectedEmpID =getSelectedEmpDetails().selectedEmpID;
            e_attendance attendanceForm = new e_attendance(employeeID,employeeStatus,selectedEmpID);
            attendanceForm.ShowDialog();
        }
        class employeeDetailsObj
        {
            internal int employeeID { get; set; }
            internal int employeeStatus { get; set; }
            internal int selectedEmpID { get; set; }        
            public employeeDetailsObj(int employeeID, int employeeStatus, int selectedEmpID)
            {
                this.employeeID = employeeID;
                this.employeeStatus = employeeStatus;
                this.selectedEmpID = selectedEmpID;
            }

        }

        private void BtnNewWorkDesc_Click(object sender, EventArgs e)
        {
            frmWorkDesc workDesc = new frmWorkDesc();
            workDesc.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT emp.employeeid, emp.lastname, emp.firstname, ac.employeePosition FROM employee emp left join accessworkdesc ac on ac.employeeStatus = emp.employeeStatus  where emp.lastname LIKE '%" + txtSearch.Text + "%' OR emp.firstname LIKE '%" + txtSearch.Text + "%' OR ac.employeePosition LIKE '%" + txtSearch.Text + "%'";

            //string query = "SELECT   lastname, firstname FROM employee where lastname LIKE '%" + txtSearch.Text + "%' OR firstname LIKE '%" + txtSearch.Text + "%'";
            MySqlCommand myComm = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            dgEmpList.DataSource = myDt;
            conn.Close();
        }

        private void dgEmpList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnArchiveRec_Click(object sender, EventArgs e)
        {
            frmArchiveList archlist = new frmArchiveList();
            archlist.ShowDialog();
        }
    }
}










