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
    public partial class frmFrameList : Form
    {
        public static string frameItemID = "";
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmFrameList()
        {
            InitializeComponent();
        }

        private void frmFrameDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCreateFrame_Click(object sender, EventArgs e)
        {
            frmFrameCreate formCreateAFrame = new frmFrameCreate();
            formCreateAFrame.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmFrameEdit formEditFrame = new frmFrameEdit();
            formEditFrame.ShowDialog();
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            frmFrameStockInAdd formFrameStockIn = new frmFrameStockInAdd();
            formFrameStockIn.ShowDialog();
        }

        private void btnArchiveList_Click(object sender, EventArgs e)
        {
            frmFrameArchivedList formFrameArchiveL = new frmFrameArchivedList();
            formFrameArchiveL.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            frmFrameDamagedItems frmFrameDmg = new frmFrameDamagedItems();
            frmFrameDmg.ShowDialog();
        }
    }
}
