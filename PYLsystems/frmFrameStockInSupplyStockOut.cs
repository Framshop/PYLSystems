using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PYLsystems
{
    public partial class frmFrameStockInSupplyStockOut : Form
    {
        public static string lastname = "";
        public static string firstname = "";
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmFrameStockInSupplyStockOut()
        {
            InitializeComponent();
            DisplayFrameItem();
            FillFrameList();
            FillEmployeeList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            functionAdd();
            string myQuery = "SELECT frameItemID FROM frame_list WHERE frameName = '" + cboFrameList.Text + "' AND active = 'active'";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {

                    string myId = myReader.GetString(0);
                    lblFrameItemID.Text = myId;

                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillEmployeeList()
        {
            string myQuery = "SELECT lastname,firstname,employeeID FROM employee";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    lastname = myReader.GetString(0);
                    firstname = myReader.GetString(1);
                    string employee = myReader.GetString(1);
                    employee = employee + ", " +  myReader.GetString(0);
                    cboEmployeeName.Items.Add(employee);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillFrameList()
        {
            string myQuery = "SELECT * FROM frame_list";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string frameList = myReader.GetString(1);
                    cboFrameList.Items.Add(frameList);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int MAX;
            MAX = lvwSupplyStockOut.Items.Count;
            myConn.Open();
            MySqlDataAdapter myAd;
            DataTable myD = new DataTable();
            MySqlCommand myCom = new MySqlCommand("SELECT * FROM framestock_in WHERE frameItemID= '" + cboFrameList.Text + "'", myConn);
            myAd = new MySqlDataAdapter(myCom);
            //ADD ----------
            MySqlDataReader myReader;
            myAd.Fill(myD);
            //ADD
            myReader = myCom.ExecuteReader();
        
            if (myD.Rows.Count == 0)
            {
                myConn.Close();
                myConn.Open();
                string myQuery = "INSERT INTO frameStock_In (employeeID,frameItemID,stockinQuantity,dateStockIn) values(" + lblEmployeeID.Text + ", " + lblFrameItemID.Text + "," + txtQuantityIn.Text + ",NOW())";
                MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataTable myDt = new DataTable();
                myAdp.Fill(myDt);


                foreach (ListViewItem lsItem in lvwSupplyStockOut.Items)
                {
                    try
                    {
                        string stock_in_frame = txtQuantityIn.Text;
                        string supply_stock_out = lsItem.SubItems[3].Text;
                        lblCompute.Text = (float.Parse(stock_in_frame) * float.Parse(supply_stock_out)).ToString();
                        string query = "INSERT INTO frame_materials(stockout_quantity,supply_detailsID,unitType,frameItemID,fixedQuantity) VALUES (" + lblCompute.Text + "," + lsItem.SubItems[0].Text + ",'" + lsItem.SubItems[4].Text + "'," + lblFrameItemID.Text + "," + lsItem.SubItems[3].Text + ");";
                        MySqlCommand comm = new MySqlCommand(query, myConn);
                        MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                myConn.Close();
                MessageBox.Show("Insert Successful!");
            }
            else
            {
                lblValidate.Text = "There is already an existing stock for" + cboFrameList.Text;
            }
            this.Close();
        }

        public void DisplayFrameItem()
        {
            myConn.Open();
            string query = "SELECT si.unitmeasure,supplyID,si.supplyName,s.supplierName,sd.supply_price,sd.stockin_quantity,if(sd.active=1,'Active','Inactive') as active,sd.delivery_date FROM supply_details sd LEFT JOIN supply_items si ON sd.supply_itemsID = si.supply_itemsID LEFT JOIN supplier s ON s.supplierID=sd.supplierID WHERE sd.active = 1";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            dataGridSupplyStockIn.DataSource = Dt;
            myConn.Close();

            dataGridSupplyStockIn.Columns["supplyID"].HeaderText = "Supply ID";
            dataGridSupplyStockIn.Columns["supplyID"].Visible = false;
            dataGridSupplyStockIn.Columns["unitmeasure"].HeaderText = "Unit Measure";
            dataGridSupplyStockIn.Columns["unitmeasure"].Visible = false;
            dataGridSupplyStockIn.Columns["active"].HeaderText = "Active";
            dataGridSupplyStockIn.Columns["delivery_date"].HeaderText = "Delivery Date";
            dataGridSupplyStockIn.Columns["stockin_quantity"].HeaderText = "Stock In Quantity";
            dataGridSupplyStockIn.Columns["supply_price"].HeaderText = "Price";
            dataGridSupplyStockIn.Columns["supplyName"].HeaderText = "Supply Name";
            dataGridSupplyStockIn.Columns["supplierName"].HeaderText = "Supplier Name";

        }

        private void dataGridSupplyStockIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSupplyID.Text = dataGridSupplyStockIn.CurrentRow.Cells[1].Value.ToString();
            lblSupplyName.Text = dataGridSupplyStockIn.CurrentRow.Cells[2].Value.ToString();
            lblSupplierName.Text = dataGridSupplyStockIn.CurrentRow.Cells[3].Value.ToString();


            txtSupplyName.Text = dataGridSupplyStockIn.CurrentRow.Cells[2].Value.ToString(); 
            txtSupplierName.Text = dataGridSupplyStockIn.CurrentRow.Cells[3].Value.ToString();
            txtUnitType.Text = dataGridSupplyStockIn.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
          

            int max;
            max = lvwSupplyStockOut.Items.Count;
            item = lvwSupplyStockOut.Items.Add(lblSupplyID.Text);
            item.SubItems.Add(lblSupplyName.Text);
            item.SubItems.Add(lblSupplierName.Text);
            item.SubItems.Add(txtQuantity.Text);
            item.SubItems.Add(txtUnitType.Text);
            txtQuantity.Text = "";
            txtUnitType.Text = "";
            txtSupplierName.Text = "";
            txtSupplyName.Text = "";
        }
        public void functionEnableSupply()
        {
            int unittype = txtUnitType.TextLength;
            int quantity = txtQuantity.TextLength;
            if (lblSupplyID.Text != "" && quantity > 0 && unittype > 1)
            {
                btnStockOut.Enabled = true;
            }
            else
            {
                btnStockOut.Enabled = false;
            }
        }
        public void functionAdd()
        {
            int framelist = cboFrameList.SelectedIndex;
            int employeelist = cboEmployeeName.SelectedIndex;
            int stockin_quantity = txtQuantityIn.TextLength;
            if (lvwSupplyStockOut.Items.Count > 0 && framelist > -1 && employeelist > -1 && stockin_quantity > 0)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
        
        private void frmFrameStockInSupplyStockOut_Load(object sender, EventArgs e)
        {
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lsitem in lvwSupplyStockOut.Items)
            {
                if (txtSupplyName.Text == lsitem.SubItems[1].Text)
                {
                    btnStockOut.Enabled = false;
                }
                else
                {
                    btnStockOut.Enabled = true;
                }
            }
            functionEnableSupply();
        }

        private void txtUnitType_TextChanged(object sender, EventArgs e)
        {
            functionEnableSupply();

        }

        private void txtQuantityIn_TextChanged(object sender, EventArgs e)
        {
            functionAdd();
       
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtQuantityIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwSupplyStockOut.SelectedItems)
            {
                lvwSupplyStockOut.Items.Remove(item);
            }
        }

        private void txtUnitType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            myConn.Open();
            string query = "SELECT s.supplierName as 'supplierName',s_d.supply_price as 'supply_price',s_i.supplyName as 'supplyName',s_d.supplyID as 'supplyID',s_d.stockin_quantity as 'StockInSupply',SUM(f_m.stockout_quantity) as 'StockOutSupply',SUM(s_d.stockin_quantity - f_m.stockout_quantity) as 'AvailableSupply' FROM frame_materials f_m LEFT JOIN supply_details s_d ON s_d.supplyID = f_m.supply_detailsID LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID LEFT JOIN supplier s ON s.supplierID = s_d.supplierID WHERE suppliername LIKE '%" + txtSearch.Text +  "%' OR supply_price LIKE '%" + txtSearch.Text + "%' OR supplyname LIKE '%" + txtSearch.Text + "%'" + "GROUP BY s_d.supplyID";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            dataGridSupplyStockIn.DataSource = Dt;
            myConn.Close();
            dataGridSupplyStockIn.Columns["supplyID"].HeaderText = "Supply ID";
            dataGridSupplyStockIn.Columns["supplyID"].Visible = false;
            dataGridSupplyStockIn.Columns["supplierName"].HeaderText = "Supplier Name";
            dataGridSupplyStockIn.Columns["StockInSupply"].HeaderText = "Stock In Supply";
            dataGridSupplyStockIn.Columns["StockOutSupply"].HeaderText = "Stock Out Supply";
            dataGridSupplyStockIn.Columns["AvailableSupply"].HeaderText = "Available Supply";
            dataGridSupplyStockIn.Columns["supply_price"].HeaderText = "Price";
            dataGridSupplyStockIn.Columns["supplyName"].HeaderText = "Supply Name";

        }

        private void cboEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            functionAdd();
            string myQuery = "SELECT employeeID FROM employee WHERE lastname = '" + lastname + "' OR firstname = '" + firstname + "'";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {

                    string myId = myReader.GetString(0);
                    lblEmployeeID.Text = myId;

                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSupplyName_TextChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lsitem in lvwSupplyStockOut.Items)
            {
                if (txtSupplyName.Text == lsitem.SubItems[1].Text)
                {
                    btnStockOut.Enabled = false;
                }
                else
                {
                    btnStockOut.Enabled = true;
                }
            }
        }
    }
    }
