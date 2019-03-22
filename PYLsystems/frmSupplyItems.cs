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
    public partial class frmSupplyItems : Form
    {
        public static string supplyID = "";
        public static string typeOfMeasure_dbCellClick = "";
        public static string supply_categoryID = "";
        public static string typeOfMeasure_db = "";
        public static string quantity_left = "";
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmSupplyItems()
        {
            InitializeComponent();
            FillSupplyCategory();
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }
        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT si.supply_itemsID `Supply ID`, si.supplyName AS `Supply Name`, sc.categoryName AS `Category Name`, sc.typeOfMeasure AS `Type Of Measure`," +
                "si.supplyDescription AS `Supply Description`, sc.supply_categoryID AS `Supply Category ID`,  " +
                "si.measureA AS `Measurement A`,si.measureB AS `Measurement B`,sc.typeOfMeasure, " +
                "if (sc.typeOfMeasure = 'Area',concat(si.measureA, ' x ', si.measureB),si.measureA) AS `Measurement`,  " +
                "si.unitMeasure AS `Unit Measure`, " +
                "ifnull( if (sc.typeOfMeasure = 'Area',ROUND(((1 - (supsoA.stockOut / (si.measureA * si.measureB * supsiA.stockIn))) * supsiA.stockIn),3)," +
                "                							if (sc.typeOfMeasure = 'Whole',supsi.stockIn - supso.stockOut," +
                "                															ROUND(((1 - (supso.stockOut / (si.measureA * supsi.stockIn))) * supsi.stockIn),3))), 0) AS `Quantity Left`," +
                "ifnull( if (sc.typeOfMeasure = 'Area',ROUND(((si.measureA * si.measureB * supsiA.stockIn) - supsoA.stockOut),3)," +
                "                							if (sc.typeOfMeasure = 'Whole',supsi.stockIn - supso.stockOut," +
                "                															ROUND(((si.measureA * supsi.stockIn) - supso.stockOut),3))), 0) AS `Quantity Left in Measurement`," +
                "ifnull(supsi.unitPrice,0 ) AS `Purchase Price`, si.reorder_quantity as 'Re-Order Point'" +
                "FROM supply_items AS si " +
                "LEFT JOIN supply_Category AS sc ON si.supply_categoryID = sc.supply_categoryID " +
                "LEFT JOIN(SELECT supply_itemsID, SUM(stockin_quantity) `stockIn`,MAX(delivery_date) AS `Latest`,priceRawTotal AS `UnitPrice` FROM supply_details GROUP BY supply_itemsID) AS supsi ON si.supply_itemsID = supsi.supply_itemsID " +
                "LEFT JOIN(SELECT sui.supply_itemsID, SUM(IFNULL(dm.stockedOut,0)+IFNULL(fm.stockedOut, 0) + IFNULL(jo.stockedOut, 0)) AS `stockOut` " +
                "FROM supply_items AS sui " +
                "LEFT JOIN(SELECT supply_itemsID, SUM(totalQuantityStockedOut) AS `totalStockedOut`, SUM(measureAtoOGUnit)  AS `stockedOut` " +
                "          FROM damaged_materials GROUP BY supply_itemsID) AS dm ON sui.supply_itemsID = dm.supply_itemsID " +
                "          LEFT JOIN(SELECT sfm.supply_itemsID, SUM(sfm.measureAtoOG)*SUM(fs.stockinQuantity) as `stockedOut` " +
                "					FROM frame_materials as sfm" +
                "                    LEFT JOIN frame_list as fl ON sfm.frameItemID = fl.frameItemID" +
                "                    LEFT JOIN frameStock_In as fs ON fl.frameItemID = fs.frameItemID" +
                "                    GROUP BY supply_itemsID) AS fm ON sui.supply_ItemsID = fm.supply_ItemsID" +
                "          LEFT JOIN(SELECT sjo.supply_itemsID, SUM(sjo.measureAtoOG)* SUM(job.jobOrderQuantity) as `stockedOut` " +
                "					FROM jOrder_Details as sjo" +
                "                    LEFT JOIN jobOrder as job ON sjo.jOrd_Num = job.jOrd_Num" +
                "                    GROUP BY supply_itemsID) AS jo ON sui.supply_ItemsID = jo.supply_ItemsID" +
                "          GROUP BY sui.supply_itemsID" +
                "		) AS supso ON si.supply_itemsID = supso.supply_itemsID " +
                "LEFT JOIN(" +
                "            SELECT supply_itemsID, SUM(stockin_quantity) AS `stockIn` FROM supply_details GROUP BY supply_itemsID" +
                "            )AS supsiA ON si.supply_itemsID = supsiA.supply_itemsID " +
                "LEFT JOIN(" +
                "        SELECT sui.supply_itemsID, SUM(IFNULL(dm.stockedOutArea,0)+IFNULL(fm.stockedOutArea, 0) + IFNULL(jo.stockedOutArea, 0)) AS `stockOut` " +
                "		 FROM supply_items AS sui" +
                "        LEFT JOIN(SELECT supply_itemsID, SUM(totalQuantityStockedOut) AS `totalStockedOut`, SUM(measureAtoOGUnit*measureBtoOGUnit) AS `stockedOutArea`" +
                "                    FROM damaged_materials GROUP BY supply_itemsID) AS dm ON sui.supply_itemsID = dm.supply_itemsID" +
                "        LEFT JOIN(SELECT sfm.supply_itemsID, SUM(sfm.measureAtoOG* sfm.measureBtoOG)*SUM(fs.stockinQuantity) as `stockedOutArea`" +
                "					FROM frame_materials as sfm" +
                "                    LEFT JOIN frame_list as fl ON sfm.frameItemID = fl.frameItemID" +
                "                    LEFT JOIN frameStock_In as fs ON fl.frameItemID = fs.frameItemID" +
                "                    GROUP BY supply_itemsID) AS fm ON sui.supply_ItemsID = fm.supply_ItemsID" +
                "       LEFT JOIN(SELECT sjo.supply_itemsID, SUM(sjo.measureAtoOG* sjo.measureBtoOG)*SUM(job.jobOrderQuantity) as `stockedOutArea` " +
                "					FROM jOrder_Details as sjo" +
                "                    LEFT JOIN jobOrder as job ON sjo.jOrd_Num = job.jOrd_Num" +
                "                    GROUP BY supply_itemsID) AS jo ON sui.supply_ItemsID = jo.supply_ItemsID" +
                "        GROUP BY sui.supply_itemsID " +
                ")AS supsoA ON si.supply_itemsID = supsoA.supply_itemsID WHERE si.supplyName LIKE '%" + txtSearch.Text + "%' OR sc.categoryName LIKE '%" + txtSearch.Text + "%' " +
                "ORDER BY sc.categoryName, si.supplyName;";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgSupplyItems.DataSource = dt;
            for (int i = 0; i < dgSupplyItems.Rows.Count; i++)
            {
                if (float.Parse(dgSupplyItems.Rows[i].Cells["Quantity Left"].Value.ToString()) <= float.Parse(dgSupplyItems.Rows[i].Cells["Re-Order Point"].Value.ToString()))
                {
                    dgSupplyItems.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                }

                else
                {
                    dgSupplyItems.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
            myConn.Close();
            dgSupplyItems.Columns["Supply ID"].Visible = false;
            dgSupplyItems.Columns["Supply Category ID"].Visible = false;
            dgSupplyItems.Columns["Measurement A"].Visible = false;
            dgSupplyItems.Columns["Measurement B"].Visible = false;
            dgSupplyItems.Columns["typeOfMeasure"].Visible = false;
    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void supplyItemsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSupplyItems_Load(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            myConn.Open();
            string query = "SELECT si.supply_itemsID `Supply ID`, si.supplyName AS `Supply Name`, sc.categoryName AS `Category Name`, sc.typeOfMeasure AS `Type Of Measure`," +
                "si.supplyDescription AS `Supply Description`, sc.supply_categoryID AS `Supply Category ID`,  " +
                "si.measureA AS `Measurement A`,si.measureB AS `Measurement B`,sc.typeOfMeasure, " +
                "if (sc.typeOfMeasure = 'Area',concat(si.measureA, ' x ', si.measureB),si.measureA) AS `Measurement`,  " +
                "si.unitMeasure AS `Unit Measure`, " +
                "ifnull( if (sc.typeOfMeasure = 'Area',ROUND(((1 - (supsoA.stockOut / (si.measureA * si.measureB * supsiA.stockIn))) * supsiA.stockIn),3)," +
                "                							if (sc.typeOfMeasure = 'Whole',supsi.stockIn - supso.stockOut," +
                "                															ROUND(((1 - (supso.stockOut / (si.measureA * supsi.stockIn))) * supsi.stockIn),3))), 0) AS `Quantity Left`," +
                "ifnull( if (sc.typeOfMeasure = 'Area',ROUND(((si.measureA * si.measureB * supsiA.stockIn) - supsoA.stockOut),3)," +
                "                							if (sc.typeOfMeasure = 'Whole',supsi.stockIn - supso.stockOut," +
                "                															ROUND(((si.measureA * supsi.stockIn) - supso.stockOut),3))), 0) AS `Quantity Left in Measurement`," +
               "si.reorder_quantity as 'Re-Order Point'" + 
                "FROM supply_items AS si " +
                "LEFT JOIN supply_Category AS sc ON si.supply_categoryID = sc.supply_categoryID " +
                "LEFT JOIN(SELECT supply_itemsID, SUM(stockin_quantity) AS `stockIn` FROM supply_details GROUP BY supply_itemsID) AS supsi ON si.supply_itemsID = supsi.supply_itemsID " +
                "LEFT JOIN(SELECT sui.supply_itemsID, SUM(IFNULL(dm.stockedOut,0)+IFNULL(fm.stockedOut, 0) + IFNULL(jo.stockedOut, 0)) AS `stockOut` " +
                "FROM supply_items AS sui " +
                "LEFT JOIN(SELECT supply_itemsID, SUM(totalQuantityStockedOut) AS `totalStockedOut`, SUM(measureAtoOGUnit)  AS `stockedOut` " +
                "          FROM damaged_materials GROUP BY supply_itemsID) AS dm ON sui.supply_itemsID = dm.supply_itemsID " +
                "          LEFT JOIN(SELECT sfm.supply_itemsID, SUM(sfm.measureAtoOG)*SUM(fs.stockinQuantity) as `stockedOut` " +
                "					FROM frame_materials as sfm" +
                "                    LEFT JOIN frame_list as fl ON sfm.frameItemID = fl.frameItemID" +
                "                    LEFT JOIN frameStock_In as fs ON fl.frameItemID = fs.frameItemID" +
                "                    GROUP BY supply_itemsID) AS fm ON sui.supply_ItemsID = fm.supply_ItemsID" +
                "          LEFT JOIN(SELECT sjo.supply_itemsID, SUM(sjo.measureAtoOG)* SUM(job.jobOrderQuantity) as `stockedOut` " +
                "					FROM jOrder_Details as sjo" +
                "                    LEFT JOIN jobOrder as job ON sjo.jOrd_Num = job.jOrd_Num" +
                "                    GROUP BY supply_itemsID) AS jo ON sui.supply_ItemsID = jo.supply_ItemsID" +
                "          GROUP BY sui.supply_itemsID" +
                "		) AS supso ON si.supply_itemsID = supso.supply_itemsID " +
                "LEFT JOIN(" +
                "            SELECT supply_itemsID, SUM(stockin_quantity) AS `stockIn` FROM supply_details GROUP BY supply_itemsID" +
                "            )AS supsiA ON si.supply_itemsID = supsiA.supply_itemsID " +
                "LEFT JOIN(" +
                "        SELECT sui.supply_itemsID, SUM(IFNULL(dm.stockedOutArea,0)+IFNULL(fm.stockedOutArea, 0) + IFNULL(jo.stockedOutArea, 0)) AS `stockOut` " +
                "		 FROM supply_items AS sui" +
                "             LEFT JOIN(SELECT supply_itemsID, SUM(totalQuantityStockedOut) AS `totalStockedOut`, SUM(measureAtoOGUnit*measureBtoOGUnit) AS `stockedOutArea`" +
                "                    FROM damaged_materials GROUP BY supply_itemsID) AS dm ON sui.supply_itemsID = dm.supply_itemsID" +
                "        LEFT JOIN(SELECT sfm.supply_itemsID, SUM(sfm.measureAtoOG* sfm.measureBtoOG)*SUM(fs.stockinQuantity) as `stockedOutArea`" +
                "					FROM frame_materials as sfm" +
                "                    LEFT JOIN frame_list as fl ON sfm.frameItemID = fl.frameItemID" +
                "                    LEFT JOIN frameStock_In as fs ON fl.frameItemID = fs.frameItemID" +
                "                    GROUP BY supply_itemsID) AS fm ON sui.supply_ItemsID = fm.supply_ItemsID" +
                "       LEFT JOIN(SELECT sjo.supply_itemsID, SUM(sjo.measureAtoOG* sjo.measureBtoOG)*SUM(job.jobOrderQuantity) as `stockedOutArea` " +
                "					FROM jOrder_Details as sjo" +
                "                    LEFT JOIN jobOrder as job ON sjo.jOrd_Num = job.jOrd_Num" +
                "                    GROUP BY supply_itemsID) AS jo ON sui.supply_ItemsID = jo.supply_ItemsID" +
                "        GROUP BY sui.supply_itemsID " +
                ")AS supsoA ON si.supply_itemsID = supsoA.supply_itemsID WHERE si.supplyName LIKE '%" + txtSearch.Text + "%' OR sc.categoryName LIKE '%" + txtSearch.Text + "%' " +
                "ORDER BY sc.categoryName, si.supplyName;";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgSupplyItems.DataSource = dt;
            myConn.Close();
            dgSupplyItems.Columns["Supply ID"].Visible = false;
            dgSupplyItems.Columns["Supply Category ID"].Visible = false;
            dgSupplyItems.Columns["Measurement A"].Visible = false;
            dgSupplyItems.Columns["Measurement B"].Visible = false;
            dgSupplyItems.Columns["typeOfMeasure"].Visible = false;
      
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {
            validationCreateItem();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            validationCreateItem();
        }

        private void txtSales_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSales_Price_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {

        }

        private void cboSupplyCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            validationCreateItem();
            string myQuery = "SELECT * FROM supply_category WHERE categoryName = '" + cboSupplyCategory.Text + "'";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;

            myConn.Open();
            myReader = myComm.ExecuteReader();
            while (myReader.Read())
            {

                string myId = myReader.GetString(0);
                string typeOfMeasure = myReader.GetString(3);

                supply_categoryID = myId;
                typeOfMeasure_db = typeOfMeasure;
            }
            if (typeOfMeasure_db == "Area")
            {
                //TRUE
                lblArea.Enabled = true;
                txtArea1.Enabled = true;
                txtArea2.Enabled = true;
                cboArea.Enabled = true;
                lblX.Enabled = true;

                //FALSE

                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                txtLength.Text = "";
                cboLength.SelectedIndex = -1;

                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboWhole.SelectedIndex = -1;

                cboVolume.Enabled = false;
                lblVolume.Enabled = false;
                txtVolume.Enabled = false;

                cboVolume.SelectedIndex = -1;
                txtVolume.Text = "";
            }
            else if (typeOfMeasure_db == "Length")
            {
                //TRUE
                txtLength.Enabled = true;
                cboLength.Enabled = true;
                lblLength.Enabled = true;

                //FALSE
                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboArea.SelectedIndex = -1;

                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboWhole.SelectedIndex = -1;

                cboVolume.Enabled = false;
                lblVolume.Enabled = false;
                txtVolume.Enabled = false;

                cboVolume.SelectedIndex = -1;
                txtVolume.Text = "";
            }
            else if (typeOfMeasure_db == "Weight")
            {
                //TRUE
                lblWeight.Enabled = true;
                txtWeight.Enabled = true;
                cboWeight.Enabled = true;

                //FALSE
                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboArea.SelectedIndex = -1;

                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                cboLength.SelectedIndex = -1;
                txtLength.Text = "";

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboVolume.Enabled = false;
                lblVolume.Enabled = false;
                txtVolume.Enabled = false;

                cboVolume.SelectedIndex = -1;
                txtVolume.Text = "";

                cboWhole.SelectedIndex = -1;
            }
            else if (typeOfMeasure_db == "Volume")
            {
                //TRUE
                cboVolume.Enabled = true;
                lblVolume.Enabled = true;
                txtVolume.Enabled = true;

                //FALSE
                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboArea.SelectedIndex = -1;

                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                cboLength.SelectedIndex = -1;
                txtLength.Text = "";

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboWhole.SelectedIndex = -1;
            }
            else
            {
                //TRUE
                cboWhole.Enabled = true;
                lblWhole.Enabled = true;

                //FALSE
                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboArea.SelectedIndex = -1;

                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                cboLength.SelectedIndex = -1;
                txtLength.Text = "";

                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                cboVolume.Enabled = false;
                lblVolume.Enabled = false;
                txtVolume.Enabled = false;

                cboVolume.SelectedIndex = -1;
                txtVolume.Text = "";
            }
            myConn.Close();
            
        }
        public void FillSupplyCategory()
        {
            string myQuery = "SELECT * FROM supply_category";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string categoryName = myReader.GetString(1);
                    cboSupplyCategory.Items.Add(categoryName);

                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } 

        private void btnStockInSelectedItem_Click(object sender, EventArgs e)
        {
            frmSupplyStockIn supplyStockIn = new frmSupplyStockIn();
            supplyStockIn.lblsupply_itemsID.Text = dgSupplyItems.CurrentRow.Cells["Supply ID"].Value.ToString();
            frmSupplyStockIn.Global.supplyID = dgSupplyItems.CurrentRow.Cells["Supply ID"].Value.ToString();
            supplyStockIn.txtItemName.Text = dgSupplyItems.CurrentRow.Cells["Supply Name"].Value.ToString();     
            supplyStockIn.ShowDialog();
            RefreshDatabase();
            cboSupplyCategory.SelectedIndex = -1;
            txtItemName.Text = "";
            txtItemDescription.Text = "";


            txtReOrderPoint.Text = "";
            supply_categoryID = "";
            typeOfMeasure_db = "";
            supplyID = "";

            lblArea.Enabled = false;
            txtArea1.Enabled = false;
            txtArea2.Enabled = false;
            cboArea.Enabled = false;
            lblX.Enabled = false;

            txtLength.Enabled = false;
            cboLength.Enabled = false;
            lblLength.Enabled = false;

            lblWeight.Enabled = false;
            txtWeight.Enabled = false;
            cboWeight.Enabled = false;

            cboVolume.Enabled = false;
            lblVolume.Enabled = false;
            txtVolume.Enabled = false;
            cboWhole.Enabled = false;
            lblWhole.Enabled = false;
            btnStockInSelectedItem.Enabled = false;
            btnUpdateDetails.Enabled = false;
            btnDamageItem.Enabled = false;
            txtVolume.Text = "";
            cboVolume.SelectedIndex = -1;

            txtArea1.Text = "";
            txtArea2.Text = "";
            cboArea.SelectedIndex = -1;

            cboLength.SelectedIndex = -1;
            txtLength.Text = "";

            txtWeight.Text = "";
            cboWeight.SelectedIndex = -1;

            cboWhole.SelectedIndex = -1;

            cboVolume.SelectedIndex = -1;
            txtVolume.Text = "";
        }

        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            myConn.Open();
            MySqlDataAdapter myAd;
            DataTable myD = new DataTable();
            MySqlCommand myCom = new MySqlCommand("SELECT * FROM supply_items WHERE supplyName = '" + txtItemName.Text + "'", myConn);
            myAd = new MySqlDataAdapter(myCom);
            //ADD ----------
            MySqlDataReader myReader;
            myAd.Fill(myD);
            //ADD
            myReader = myCom.ExecuteReader();
            myConn.Close();
            if (myD.Rows.Count == 0)
            {
                if (typeOfMeasure_db == "Length")
                {
                    string myQuery = "INSERT INTO supply_items (supply_categoryID,supplyName,supplyDescription,measureA,unitMeasure,reOrder_quantity) values(" + supply_categoryID + ",'" + txtItemName.Text + "','" + txtItemDescription.Text + "'," + txtLength.Text + ",'" + cboLength.Text + "'," + txtReOrderPoint.Text + ")";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Insert Successful");
                }
                else if (typeOfMeasure_db == "Area")
                {
                    string myQuery = "INSERT INTO supply_items (supply_categoryID,supplyName,supplyDescription,measureA,measureB,unitMeasure,reOrder_quantity) values(" + supply_categoryID + ",'" + txtItemName.Text + "','" + txtItemDescription.Text + "'," + txtArea1.Text + "," + txtArea2.Text + ",'" + cboArea.Text + "'," + txtReOrderPoint.Text + ")";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Insert Successful");
                }
                else if (typeOfMeasure_db == "Weight")
                {
                    string myQuery = "INSERT INTO supply_items (supply_categoryID,supplyName,supplyDescription,measureA,unitMeasure,reOrder_quantity) values(" + supply_categoryID + ",'" + txtItemName.Text + "','" + txtItemDescription.Text + "'," + txtWeight.Text + ",'" + cboWeight.Text + "'," + txtReOrderPoint.Text + ")";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Insert Successful");
                }
                else if (typeOfMeasure_db == "Volume")
                {
                    string myQuery = "INSERT INTO supply_items (supply_categoryID,supplyName,supplyDescription,measureA,unitMeasure,reOrder_quantity) values(" + supply_categoryID + ",'" + txtItemName.Text + "','" + txtItemDescription.Text + "'," + txtVolume.Text + ",'" + cboVolume.Text + "'," + txtReOrderPoint.Text + ")";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Insert Successful");
                }
                else
                {
                    string myQuery = "INSERT INTO supply_items (supply_categoryID,supplyName,supplyDescription,measureA,unitMeasure,reOrder_quantity) values(" + supply_categoryID + ",'" + txtItemName.Text + "','" + txtItemDescription.Text + "'," + 1 + ",'" + cboWhole.Text + "'," + txtReOrderPoint.Text + ")";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Insert Successful");
                }
                RefreshDatabase();
                cboSupplyCategory.SelectedIndex = -1;
                txtItemName.Text = "";
                txtItemDescription.Text = "";


                txtReOrderPoint.Text = "";
                supply_categoryID = "";
                typeOfMeasure_db = "";
                supplyID = "";

                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;


                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboVolume.Enabled = false;
                lblVolume.Enabled = false;
                txtVolume.Enabled = false;

                cboVolume.Enabled = false;
                lblVolume.Enabled = false;
                txtVolume.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboArea.SelectedIndex = -1;
               
                cboLength.SelectedIndex = -1;
                txtLength.Text = "";


                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                cboWhole.SelectedIndex = -1;

                cboVolume.SelectedIndex = -1;
                txtVolume.Text = "";
            }
            else
            {
                MessageBox.Show(txtItemName.Text + " already exist in your inventory");
            }
    }
        public void validationUpdateItem()
        {
            if (supplyID != "")
            {
                btnDamageItem.Enabled = true;
                btnUpdateDetails.Enabled = true;
                btnStockInSelectedItem.Enabled = true;
            }
            else
            {

                btnDamageItem.Enabled = false;
                btnUpdateDetails.Enabled = false;
                btnStockInSelectedItem.Enabled = false;
            }
        }
        public void validationCreateItem()
        {
            int supply_category = cboSupplyCategory.SelectedIndex;
            int supply_name = txtItemName.TextLength;
            int supply_description = txtItemDescription.TextLength;
     
            int reoOrderPoint = txtReOrderPoint.TextLength;
            //Others are for measurements without assigning into another variable
            if (lblLength.Enabled == true)
            {
                if (supply_category > -1 && supply_name > 0 && supply_description > 0 && reoOrderPoint > 0 && cboLength.SelectedIndex > -1 && txtLength.TextLength > 0)
                {
                    btnCreateItem.Enabled = true;
                }
                else
                {
                    btnCreateItem.Enabled = false;
                }
            }
            else if (lblWeight.Enabled == true)
            {
                if (supply_category > -1 && supply_name > 0 && supply_description > 0 && reoOrderPoint > 0 && cboWeight.SelectedIndex > -1 && txtWeight.TextLength > 0)
                {
                    btnCreateItem.Enabled = true;
                }
                else
                {
                    btnCreateItem.Enabled = false;
                }
            }
            else if (lblWhole.Enabled == true)
            {
                if (supply_category > -1 && supply_name > 0 && supply_description > 0 && reoOrderPoint > 0 && cboWhole.SelectedIndex > -1)
                {
                    btnCreateItem.Enabled = true;
                }
                else
                {
                    btnCreateItem.Enabled = false;
                }
            }
            else if (lblVolume.Enabled == true)
            {
                if (supply_category > -1 && supply_name > 0 && supply_description > 0 && reoOrderPoint > 0 && cboVolume.SelectedIndex > -1 && txtVolume.TextLength > 0)
                {
                    btnCreateItem.Enabled = true;
                }
                else
                {
                    btnCreateItem.Enabled = false;
                }
            }
            else if (lblArea.Enabled == true)
            {
                if (supply_category > -1 && supply_name > 0 && supply_description > 0 && reoOrderPoint > 0 && cboArea.SelectedIndex > -1 && txtArea1.TextLength > 0 && txtArea2.TextLength > 0)
                {
                    btnCreateItem.Enabled = true;
                }
                else
                {
                    btnCreateItem.Enabled = false;
                }
            }
            else
            {

            }
        }

        private void dgSupplyItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSupplyItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            quantity_left = dgSupplyItems.CurrentRow.Cells["Quantity Left"].Value.ToString();
           supplyID = dgSupplyItems.CurrentRow.Cells["Supply ID"].Value.ToString();
            txtReOrderPoint.Text = dgSupplyItems.CurrentRow.Cells["Re-Order Point"].Value.ToString();
            validationUpdateItem();
            typeOfMeasure_dbCellClick = dgSupplyItems.CurrentRow.Cells["Type of Measure"].Value.ToString();
            if (typeOfMeasure_dbCellClick == "Area")
            {
                supply_categoryID = dgSupplyItems.CurrentRow.Cells["Supply Category ID"].Value.ToString();
                cboSupplyCategory.Text = dgSupplyItems.CurrentRow.Cells["Category Name"].Value.ToString();
                txtItemName.Text = dgSupplyItems.CurrentRow.Cells["Supply Name"].Value.ToString();
                txtItemDescription.Text = dgSupplyItems.CurrentRow.Cells["Supply Description"].Value.ToString();
          
              


                //TRUE
                lblArea.Enabled = true;
                txtArea1.Enabled = true;
                txtArea2.Enabled = true;
                cboArea.Enabled = true;
                lblX.Enabled = true;

                //supplyItemsGrid.DataSource = Dt;
                //myConn.Close();
                //supplyItemsGrid.Columns["supply_itemsID"].Enabled = false;
                //supplyItemsGrid.Columns["supplyName"].HeaderText = "Supply Name";
                //supplyItemsGrid.Columns["supplyDescription"].HeaderText = "Details";
                //supplyItemsGrid.Columns["unitMeasure"].HeaderText = "Unit Measure";




                txtArea1.Text = dgSupplyItems.CurrentRow.Cells["Measurement A"].Value.ToString();
                txtArea2.Text = dgSupplyItems.CurrentRow.Cells["Measurement B"].Value.ToString();
                cboArea.Text = dgSupplyItems.CurrentRow.Cells["Unit Measure"].Value.ToString();

                //FALSE

                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                cboLength.SelectedIndex = -1;
                txtLength.Text = "";

                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboWhole.SelectedIndex = -1;

                lblVolume.Enabled = false;
                txtVolume.Enabled = false;
                cboVolume.Enabled = false;

                txtVolume.Text = "";
                cboVolume.SelectedIndex = -1;
            }
            else if (typeOfMeasure_dbCellClick == "Length")
            {
                supply_categoryID = dgSupplyItems.CurrentRow.Cells["Supply Category ID"].Value.ToString();
                cboSupplyCategory.Text = dgSupplyItems.CurrentRow.Cells["Category Name"].Value.ToString();
                txtItemName.Text = dgSupplyItems.CurrentRow.Cells["Supply Name"].Value.ToString();
                txtItemDescription.Text = dgSupplyItems.CurrentRow.Cells["Supply Description"].Value.ToString();
            
         

                //TRUE
                txtLength.Enabled = true;
                cboLength.Enabled = true;
                lblLength.Enabled = true;

                cboLength.Text = dgSupplyItems.CurrentRow.Cells["Unit Measure"].Value.ToString();
                txtLength.Text = dgSupplyItems.CurrentRow.Cells["Measurement A"].Value.ToString();

                //FALSE
                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboArea.SelectedIndex = -1;

                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboWhole.SelectedIndex = -1;

                lblVolume.Enabled = false;
                txtVolume.Enabled = false;
                cboVolume.Enabled = false;

                txtVolume.Text = "";
                cboVolume.SelectedIndex = -1;
            }
            else if (typeOfMeasure_dbCellClick == "Weight")
            {
                supply_categoryID = dgSupplyItems.CurrentRow.Cells["Supply Category ID"].Value.ToString();
                cboSupplyCategory.Text = dgSupplyItems.CurrentRow.Cells["Category Name"].Value.ToString();
                txtItemName.Text = dgSupplyItems.CurrentRow.Cells["Supply Name"].Value.ToString();
                txtItemDescription.Text = dgSupplyItems.CurrentRow.Cells["Supply Description"].Value.ToString();
             


                //TRUE
                lblWeight.Enabled = true;
                txtWeight.Enabled = true;
                cboWeight.Enabled = true;

                txtWeight.Text = dgSupplyItems.CurrentRow.Cells["Unit Measure"].Value.ToString();
                cboWeight.Text = dgSupplyItems.CurrentRow.Cells["Measurement A"].Value.ToString();
                //FALSE
                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboArea.SelectedIndex = -1;


                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                cboLength.SelectedIndex = -1;
                txtLength.Text = "";

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboWhole.SelectedIndex = -1;

                lblVolume.Enabled = false;
                txtVolume.Enabled = false;
                cboVolume.Enabled = false;

                txtVolume.Text = "";
                cboVolume.SelectedIndex = -1;
            }
            else if (typeOfMeasure_dbCellClick == "Volume")
            {
                supply_categoryID = dgSupplyItems.CurrentRow.Cells["Supply Category ID"].Value.ToString();
                cboSupplyCategory.Text = dgSupplyItems.CurrentRow.Cells["Category Name"].Value.ToString();
                txtItemName.Text = dgSupplyItems.CurrentRow.Cells["Supply Name"].Value.ToString();
                txtItemDescription.Text = dgSupplyItems.CurrentRow.Cells["Supply Description"].Value.ToString();
                
               
                //TRUE
                lblVolume.Enabled = true;
                txtVolume.Enabled = true;
                cboVolume.Enabled = true;

                txtVolume.Text = dgSupplyItems.CurrentRow.Cells["Measurement A"].Value.ToString();
                cboVolume.Text = dgSupplyItems.CurrentRow.Cells["Unit Measure"].Value.ToString();

                //FALSE
                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboArea.SelectedIndex = -1;

                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                cboLength.SelectedIndex = -1;
                txtLength.Text = "";

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboWhole.SelectedIndex = -1;
            }
            else
            {
                supply_categoryID = dgSupplyItems.CurrentRow.Cells["Supply Category ID"].Value.ToString();
                cboSupplyCategory.Text = dgSupplyItems.CurrentRow.Cells["Category Name"].Value.ToString();
                txtItemName.Text = dgSupplyItems.CurrentRow.Cells["Supply Name"].Value.ToString();
                txtItemDescription.Text = dgSupplyItems.CurrentRow.Cells["Supply Description"].Value.ToString();
     
  

                //TRUE
                cboWhole.Enabled = true;
                lblWhole.Enabled = true;

                cboWhole.Text = dgSupplyItems.CurrentRow.Cells["Unit Measure"].Value.ToString();
                //FALSE
                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboArea.SelectedIndex = -1;

                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                cboLength.SelectedIndex = -1;
                txtLength.Text = "";

                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                lblVolume.Enabled = false;
                txtVolume.Enabled = false;
                cboVolume.Enabled = false;

                txtVolume.Text = "";
                cboVolume.SelectedIndex = -1;
            }
        }

        private void txtPurchaseUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cboActive_SelectedIndexChanged(object sender, EventArgs e)
        {
      
            validationCreateItem();
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            validationCreateItem();
        }

        private void cboLength_SelectedIndexChanged(object sender, EventArgs e)
        {
  
            validationCreateItem();
        }

        private void txtArea1_TextChanged(object sender, EventArgs e)
        {
  
            validationCreateItem();
        }

        private void txtArea2_TextChanged(object sender, EventArgs e)
        {

            validationCreateItem();
        }

        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            validationCreateItem();
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
       
            validationCreateItem();
        }

        private void cboWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            validationCreateItem();
        }

        private void cboWhole_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            validationCreateItem();
        }

        private void txtPurchaseUnitPrice_TextChanged(object sender, EventArgs e)
        {
     
            validationCreateItem();
        }


        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            btnUpdateDetails.Enabled = false;
            btnStockInSelectedItem.Enabled = false;
            btnDamageItem.Enabled = false;
          
                if (typeOfMeasure_db == "Length")
                {
                    string myQuery = "UPDATE supply_items SET supply_categoryID = " + supply_categoryID + ", supplyName = '" + txtItemName.Text + "', supplyDescription = '" + txtItemDescription.Text + "', measureA = " + txtLength.Text + ", unitMeasure = '" + cboLength.Text + "', reorder_quantity = " + txtReOrderPoint.Text + " WHERE supply_itemsID = " + supplyID;
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Update Successful");
                }
                else if (typeOfMeasure_db == "Area")
                {
                    string myQuery = "UPDATE supply_items SET supply_categoryID = " + supply_categoryID + ", supplyName = '" + txtItemName.Text + "', supplyDescription = '" + txtItemDescription.Text + "', measureA = " + txtArea1.Text + ", measureB = " + txtArea2.Text + ", unitMeasure = '" + cboArea.Text + "', reorder_quantity = " + txtReOrderPoint.Text + " WHERE supply_itemsID = " + supplyID;
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Update Successful");
                }
                else if (typeOfMeasure_db == "Weight")
                {
                    string myQuery = "UPDATE supply_items SET supply_categoryID = " + supply_categoryID + ", supplyName = '" + txtItemName.Text + "', supplyDescription = '" + txtItemDescription.Text + "', measureA = " + txtWeight.Text + ", unitMeasure = '" + cboWeight.Text + "', reorder_quantity = " + txtReOrderPoint.Text + " WHERE supply_itemsID = " + supplyID;
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Update Successful");
                }
            else if (typeOfMeasure_db == "Volume")
            {
                string myQuery = "UPDATE supply_items SET supply_categoryID = " + supply_categoryID + ", supplyName = '" + txtItemName.Text + "', supplyDescription = '" + txtItemDescription.Text + "', measureA = " + txtVolume.Text + ", unitMeasure = '" + cboVolume.Text + "', reorder_quantity =" + txtReOrderPoint.Text + " WHERE supply_itemsID = " + supplyID;
                MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataTable myDt = new DataTable();
                myAdp.Fill(myDt);
                RefreshDatabase();
                MessageBox.Show("Update Successful");
            }
            else
                {
                    string myQuery = "UPDATE supply_items SET supply_categoryID = " + supply_categoryID + ", supplyName = '" + txtItemName.Text + "', supplyDescription = '" + txtItemDescription.Text + "', measureA = " + 1 + ", unitMeasure = '" + cboWhole.Text + "', reorder_quantity = " + txtReOrderPoint.Text + " WHERE supply_itemsID = " + supplyID;
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Update Successful");
                }
                RefreshDatabase();
                cboSupplyCategory.SelectedIndex = -1;
                txtItemName.Text = "";
                txtItemDescription.Text = "";
             

            txtReOrderPoint.Text = "";
                supply_categoryID = "";
                typeOfMeasure_db = "";
                supplyID = "";

                txtVolume.Text = "";
                cboVolume.SelectedIndex = -1;

                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

            txtArea1.Text = "";
            txtArea2.Text = "";
            cboArea.SelectedIndex = -1;

                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

            cboLength.SelectedIndex = -1;
            txtLength.Text = "";

                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;
            txtWeight.Text = "";
            cboWeight.SelectedIndex = -1;

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

            cboWhole.SelectedIndex = -1;

                lblVolume.Enabled = false;
                txtVolume.Enabled = false;
                cboVolume.Enabled = false;

            cboVolume.SelectedIndex = -1;
            txtVolume.Text = "";
        }

        private void frmSupplyItems_Load_1(object sender, EventArgs e)
        {
            
            RefreshDatabase();
            
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtArea1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtArea2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnDamageItem_Click(object sender, EventArgs e)
        {
            int currRowIndex = dgSupplyItems.SelectedRows[0].Index;
            double quantityLeft = double.Parse(dgSupplyItems.Rows[currRowIndex].Cells["Quantity Left"].Value.ToString());
            double quantityLeftinMeasure = double.Parse(dgSupplyItems.Rows[currRowIndex].Cells["Quantity Left in Measurement"].Value.ToString());
            int supply_itemsId = Int32.Parse(dgSupplyItems.Rows[currRowIndex].Cells["Supply ID"].Value.ToString());
            if (quantityLeft > 0)
            {
                frmSupplyDamage supplyDamageWin = new frmSupplyDamage(supply_itemsId,quantityLeft, quantityLeftinMeasure);
                supplyDamageWin.ShowDialog();
                RefreshDatabase();
            }
            else
            {
                MessageBox.Show(txtItemName.Text + " needs to be stocked in first!");
            }
        }

        private void txtReOrderPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void frmSupplyItems_Shown(object sender, EventArgs e)
        {
            String showStockInNeed = "";
            for (int i = 0; i < dgSupplyItems.Rows.Count; i++)
            {
                if (float.Parse(dgSupplyItems.Rows[i].Cells["Quantity Left"].Value.ToString()) <= float.Parse(dgSupplyItems.Rows[i].Cells["Re-Order Point"].Value.ToString()))
                {
                    showStockInNeed += "\n *" + dgSupplyItems.Rows[i].Cells["Supply Name"].Value.ToString();
                }

                else
                {
                    dgSupplyItems.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
            MessageBox.Show("The following supplies have reached on or below the Re-Order Point. Please Stock-in the folowing items: " + showStockInNeed);
        }
    }
    }

