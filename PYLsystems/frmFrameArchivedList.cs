using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYLsystems
{
    public partial class frmFrameArchivedList : Form
    {
        String connString = "Server=localhost;Database=frameshopdb;Uid=root;Pwd=root";
        DataTable dtFrameList;
        public frmFrameArchivedList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFrameArchivedList_Load(object sender, EventArgs e)
        {
            frmFrameArchivedList_Loader();
        }
        private void frmFrameArchivedList_Loader()
        {
            try
            {
                this.datagridArchivedFrames.DataSource = null;
                this.datagridArchivedFrames.Rows.Clear();
                String frameAvailString = "SELECT FL.frameName AS Frame, FL.Dimension, FL.frameDescription, fl.UnitSalesPrice AS 'Unit Price', " +
                    "FL.frameItemID FROM frame_list AS FL " +
                    "WHERE FL.active = '1' ORDER BY FL.frameName; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand frameAvail_command = new MySqlCommand(frameAvailString, my_conn);
                MySqlDataAdapter frameAvail_adapter = new MySqlDataAdapter(frameAvail_command);

                dtFrameList = new DataTable();
                frameAvail_adapter.Fill(dtFrameList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            datagridArchivedFrames.DataSource = dtFrameList;
            if (datagridArchivedFrames.Rows.Count > 0)
            {
                btnRestore.Enabled = true;
            }
            else{
                btnRestore.Enabled = false;
            }
        }
        private void restoreArchivedFrame(int selectedFrameItemId)
        {
            try
            {
                String updateFrameListStat = "UPDATE frame_list " +
                    "SET active = '0' " +
                    "WHERE frameItemID = @frameItemID; ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdUpdateFrameListStat = new MySqlCommand(updateFrameListStat, my_conn);
                cmdUpdateFrameListStat.Parameters.AddWithValue("@frameItemID", selectedFrameItemId);

                MySqlDataReader dataReader;
                my_conn.Open();
                dataReader = cmdUpdateFrameListStat.ExecuteReader();
                while (dataReader.Read())
                {
                }
                my_conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to restore frame back to active Frame List?", "Confirm", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                int currRowIndex = datagridArchivedFrames.SelectedRows[0].Index;
                int selectedFrameItemId = Int32.Parse(datagridArchivedFrames.Rows[currRowIndex].Cells["frameItemID"].Value.ToString());
                restoreArchivedFrame(selectedFrameItemId);
                frmFrameArchivedList_Loader();
            }
            else
            {
                return;
            }
        }
    }
}
