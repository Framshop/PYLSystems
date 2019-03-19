using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PYLsystems
{
    public partial class frmFrameCreate : Form
    {
        public static string lastname = "";
        public static string firstname = "";
        public static float remainingItem = 0;
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmFrameCreate()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            frmFrameAddSuppliesUsed frmAddSupplies = new frmFrameAddSuppliesUsed(this);
            frmAddSupplies.ShowDialog();
        }

        private void btnEditSupply_Click(object sender, EventArgs e)
        {
            frmFrameEditSuppliesUsed frmEditSupplies = new frmFrameEditSuppliesUsed();
            frmEditSupplies.ShowDialog();
        }
    }
}
