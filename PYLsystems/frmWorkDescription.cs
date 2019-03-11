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
    public partial class frmWorkDescription : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmWorkDescription()
        {
            InitializeComponent();
        }

        private void frmWorkDetails_Load(object sender, EventArgs e)
        {
            reload();
            enable();
        }


        public void reload()
        {
     




        }


        private void enable()
        {

            int pos = txtPosition.TextLength;
            int details = txtDetails.TextLength;
    


            if ( pos > 0 && details > 0)
            {
                btnCreate.Enabled = true;
            }
            else

                btnCreate.Enabled = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string myQuery = "Insert INTO accessworkdesc(employeePosition , workDetailsDesc)  values('" +  txtPosition.Text + "','" + txtDetails.Text + "')"; 
            MySqlCommand myComm = new MySqlCommand(myQuery, conn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            conn.Close();
            MessageBox.Show("New Employee Created");


            this.Close();
        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
            enable();
        }

        private void txtDetails_TextChanged(object sender, EventArgs e)
        {
            enable();
        }
    }
}
