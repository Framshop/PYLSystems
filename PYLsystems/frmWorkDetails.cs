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
    public partial class frmWorkDetails : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=");
        public frmWorkDetails()
        {
            InitializeComponent();
        }

        private void frmWorkDetails_Load(object sender, EventArgs e)
        {
            reload();
        }


        public void reload()
        {
     




        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            frmSetWorkDetails set = new frmSetWorkDetails();
            set.ShowDialog();
        }
    }
}
