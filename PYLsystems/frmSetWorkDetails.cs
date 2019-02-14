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
    public partial class frmSetWorkDetails : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=");
        public frmSetWorkDetails()
        {
            InitializeComponent();
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void frmSetWorkDetails_Load(object sender, EventArgs e)
        {
            reload();
        }

        public void reload()
        {
            string query = "SELECT  employeeid, lastname, firstname FROM employee";
            MySqlCommand myComm = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            dgvSelectEmployee.DataSource = myDt;
            conn.Close();


            dgvSelectEmployee.Columns["employeeid"].Visible = false;
            dgvSelectEmployee.Columns["lastname"].HeaderText = "Last Name";
            dgvSelectEmployee.Columns["firstname"].HeaderText = "First Name";

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dgvSelectEmployee.Rows.Count - 1; i++)
            {
                // rowAlreadyExist => if the row already exist on dataGridView2
                bool rowAlreadyExist = false;
                bool checkedCell = (bool)dgvSelectEmployee.Rows[i].Cells[3].Value;
                if (checkedCell == true)
                {
                    DataGridViewRow row = dgvSelectEmployee.Rows[i];

                    // the dataGridView2 have one row or more
                    if (dgvEmployeeSelected.Rows.Count != 0)
                    {
                        // loop to see if the row already exist on dataGridView2
                        for (int j = 0; j <= dgvEmployeeSelected.Rows.Count - 1; j++)
                        {
                            if (row.Cells[0].Value.ToString() == dgvEmployeeSelected.Rows[j].Cells[0].Value.ToString())
                            {
                                rowAlreadyExist = true;
                                break;
                            }
                        }

                        // add if the row ont exist on dataGridView2
                        if (rowAlreadyExist == false)
                        {
                            dgvEmployeeSelected.Rows.Add(row.Cells[0].Value.ToString(),
                                                   row.Cells[1].Value.ToString(),
                                                   row.Cells[2].Value.ToString()
                                                   );
                        }
                    }

                    // add if the dataGridView2 have no row 
                    else
                    {
                        dgvEmployeeSelected.Rows.Add(row.Cells[0].Value.ToString(),
                                                   row.Cells[1].Value.ToString(),
                                                   row.Cells[2].Value.ToString()
                                                   );
                    }
                }
            }
        }

        private void dgvSelectEmployee_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void dgvSelectEmployee_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
