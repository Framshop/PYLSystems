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
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=");
        public frmFrameList()
        {
            InitializeComponent();
            FillSupplyItems();
        }
        private void FillSupplyItems()
        {
            
            string myQuery = "SELECT * FROM supply_items";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string name = myReader.GetString(1);
                    cboSupplyName.Items.Add(name);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();
                string myQuery = "INSERT INTO frame_list (frameName, frameDescription, active,dimension,unitPrice) values('" + txtName.Text + "','" + txtDescription.Text + "','" + cboActive.Text + "','" + txtDimension.Text + "','" + txtUnitPrice.Text + "')";
                MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataTable myDt = new DataTable();
                myAdp.Fill(myDt);
                myConn.Close();

                string myQue = "SELECT MAX(frameItemID) FROM frame_list";
                MySqlCommand myCo = new MySqlCommand(myQue, myConn);
                MySqlDataReader myReader;

                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string frameItemID = myReader.GetString(1);
                    lblFrameItemID.Text = frameItemID;
                }
                myConn.Close();


                int index, MAX;
                ListViewItem item = new ListViewItem();
                MAX = lvwFrameList.Items.Count;
                for (index = 0; index < MAX; index++)
                {
                    myConn.Open();
                    string myQuer = "INSERT INTO frame_details (supply_itemsID,framesID) values('" + lvwFrameList.Items[index].Text + "','" + lblFrameItemID.Text + "')";
                    MySqlCommand myCom = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAd = new MySqlDataAdapter(myCom);
                    DataTable myD = new DataTable();
                    myAd.Fill(myD);
                    myConn.Close();
                }
                MessageBox.Show("Insert Successful!");
                RefreshDatabase();
                for (index = 0; index <= MAX; index++)
                {

                    lvwFrameList.Items.Remove(lvwFrameList.Items[index]);
                    lvwFrameList.Items[index].SubItems.Remove(item.SubItems[index]);
                    lvwFrameList.Items[index].SubItems.Remove(item.SubItems[index]);
                    lvwFrameList.Items[index].SubItems.Remove(item.SubItems[index]);





                }
                txtDescription.Text = "";
                txtName.Text = "";
                txtDimension.Text = "";
                txtUnitPrice.Text = "";
                cboActive.Text = "";
            }
            catch (Exception ex)
            {
            } 
        }

        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT frameItemID,frameName,frameDescription,active,dimension,unitPrice FROM frame_list";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            frameItemsGrid.DataSource = Dt;
            myConn.Close();
            frameItemsGrid.Columns["frameItemID"].Visible = false;
            frameItemsGrid.Columns["frameItemID"].HeaderText = "ID";
            frameItemsGrid.Columns["frameName"].HeaderText = "Name";
            frameItemsGrid.Columns["frameDescription"].HeaderText = "Description";
            frameItemsGrid.Columns["active"].HeaderText = "Active";
            frameItemsGrid.Columns["dimension"].HeaderText = "Dimension";
            frameItemsGrid.Columns["unitPrice"].HeaderText = "Unit Price";
            frameItemsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void frameItemsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIDUpdate.Text = frameItemsGrid.CurrentRow.Cells[0].Value.ToString();

            txtName.Text = frameItemsGrid.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = frameItemsGrid.CurrentRow.Cells[2].Value.ToString();
            cboActive.Text = frameItemsGrid.CurrentRow.Cells[3].Value.ToString();
            txtDimension.Text = frameItemsGrid.CurrentRow.Cells[4].Value.ToString();
            txtUnitPrice.Text = frameItemsGrid.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            myConn.Open();
            string myQuery = "UPDATE frame_list SET frameName = '" + txtName.Text + "',frameDescription =  " +
                "'" + txtDescription.Text + "', active = '" + cboActive.Text + "', dimension = '" + txtDimension.Text + "', unitPrice = " + txtUnitPrice.Text + " WHERE frameItemID = " + lblIDUpdate.Text;
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            myConn.Close();
            MessageBox.Show("Update Successful!");
            RefreshDatabase();
            txtDescription.Text = "";
            txtName.Text = "";
            txtDimension.Text = "";
            txtUnitPrice.Text = "";
            cboActive.Text = "";
        }

        private void frmFrameList_Load(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            myConn.Open();
            string query = "SELECT frameItemID,frameName,frameDescription,active,dimension,unitPrice FROM frame_list WHERE frameName LIKE '%" + txtSearch.Text + "%' OR frameDescription LIKE '%" + txtSearch.Text + "%' OR dimension LIKE '%" + txtSearch.Text + "%' OR active LIKE '%" + txtSearch.Text + "%' OR unitPrice LIKE '%" + txtSearch.Text + "%'";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            frameItemsGrid.DataSource = Dt;
            myConn.Close();
            frameItemsGrid.Columns["frameItemID"].Visible = false;
            frameItemsGrid.Columns["frameItemID"].HeaderText = "ID";
            frameItemsGrid.Columns["frameName"].HeaderText = "Name";
            frameItemsGrid.Columns["frameDescription"].HeaderText = "Description";
            frameItemsGrid.Columns["active"].HeaderText = "Active";
            frameItemsGrid.Columns["dimension"].HeaderText = "Dimension";
            frameItemsGrid.Columns["unitPrice"].HeaderText = "Unit Price";
            frameItemsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {

            try
            {
                ListViewItem item = new ListViewItem();
                ListViewItem id;
                int max, index;
                max = lvwFrameList.Items.Count;

                item = lvwFrameList.Items.Add(cboSupplyName.Text);
                item.SubItems.Add(txtSupplyDescription.Text);
                item.SubItems.Add(txtSupplyUnitMeasure.Text);
                item.SubItems.Add(lblSupplyID.Text);

                for (index = 0; index < max; index++)
                {
                    if (lvwFrameList.Items[index].Text == cboSupplyName.Text)
                    {
                        lvwFrameList.Items.Remove(lvwFrameList.Items[index]);
                        lvwFrameList.Items[index].SubItems.Remove(item.SubItems[index]);
                        lvwFrameList.Items[index].SubItems.Remove(item.SubItems[index]);
                        lvwFrameList.Items[index].SubItems.Remove(item.SubItems[index]);



                    }
                    item.SubItems.Add(cboSupplyName.Text);
                    item.SubItems.Add(txtSupplyDescription.Text);
                    item.SubItems.Add(txtSupplyUnitMeasure.Text);
                    item.SubItems.Add(lblSupplyID.Text);

                }

            }
            catch
            {

            }
        }

        private void cboSupplyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myQuery = "SELECT * FROM supply_items WHERE supplyName = '" + cboSupplyName.Text + "'";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {

           
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
          

                    string myUnitmeasure = myReader.GetString(3);
                    txtSupplyUnitMeasure.Text = myUnitmeasure;
                    
                    string myDescription = myReader.GetString(2);
                    txtSupplyDescription.Text = myDescription;

                    string mySupplyID = myReader.GetString(0);
                    lblSupplyID.Text = mySupplyID;

                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
