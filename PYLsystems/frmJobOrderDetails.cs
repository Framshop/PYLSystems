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
    public partial class frmJobOrderDetails : Form
    {
        public static string jOrdID = "";
        public static string lastname = "";
        public static string firstname = "";
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmJobOrderDetails()
        {
            InitializeComponent();
            fillCustomerName();
            FillEmployeeList();
            FillSupplyDetails();
        }
        private void fillCustomerName()
        {
            string myQuery = "SELECT * FROM customer_account";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string customerList = myReader.GetString(1);
                    cboCustomerName.Items.Add(customerList);

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
                    employee = employee + ", " + myReader.GetString(0);
                    cboEmployeeLastName.Items.Add(employee);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillSupplyDetails()
        {
            string myQuery = "SELECT s_i.supplyName FROM supply_details s_d LEFT JOIN supplier s ON s.supplierID = s_d.supplyID LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {

                    string supplyName = myReader.GetString(0);
                    cboSupplyItems.Items.Add(supplyName);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddJobOrder();
            string myQuery = "SELECT customerID,balance FROM customer_account WHERE customerfullname = '" + cboCustomerName.Text + "'";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;

            myConn.Open();
            myReader = myComm.ExecuteReader();
            while (myReader.Read())
            {

                string myId = myReader.GetString(0);
                lblCustomerID.Text = myId;
                txtBalance.Text = myReader.GetString(1);
            }
            myConn.Close();

        }

        private void cboEmployeeLastName_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddJobOrder();

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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwJobDetails.SelectedItems)
            {
                lvwJobDetails.Items.Remove(item);
            }
        }

        private void cboSupplyItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            functionAddSupply();
            string myQuery = "SELECT s_d.supplyID,s.supplierName,s_d.supply_price,s_i.unitmeasure FROM supply_details s_d LEFT JOIN supplier s ON s.supplierID = s_d.supplierID LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID WHERE supplyName = '" + cboSupplyItems.Text + "'";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {

                    string supplierName = myReader.GetString(1);
                    txtSupplier.Text = supplierName;
                    string supplyID = myReader.GetString(0);
                    lblSupplyID.Text = supplyID;
                    txtSupplyPrice.Text = myReader.GetString(2);
                    txtUnitMeasure.Text = myReader.GetString(3);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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
        public void functionAddSupply()
        {
            int quantity = txtQuantity.TextLength;
            int price = txtPrice.TextLength;
            int size = txtSize.TextLength;
            int supply_items = cboSupplyItems.SelectedIndex;
            int unit_measure = txtUnitMeasure.TextLength;
            if (quantity > 0 && price > 0 && size > 0 && supply_items > -1 && unit_measure > 0)
            {
                btnAddSupply.Enabled = true;
            }
            else
            {
                btnAddSupply.Enabled = false;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            functionAddSupply();
            try
            {
                if (txtQuantity.TextLength > 0)
                {
                    txtSubtotal.Text = (float.Parse(txtPrice.Text) * float.Parse(txtQuantity.Text)).ToString();
                }
                else
                {
                    txtSubtotal.Text = "";
                }
            }
            catch
            {

            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            functionAddSupply();
            try
            {
                if (txtQuantity.TextLength > 0)
                {
                    txtSubtotal.Text = (float.Parse(txtPrice.Text) * float.Parse(txtQuantity.Text)).ToString();
                }
                else
                {
                    txtSubtotal.Text = "";
                }
            }
            catch
            {

            }
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            functionAddSupply();
        }

        private void txtUnitMeasure_SelectedIndexChanged(object sender, EventArgs e)
        {
            functionAddSupply();
        }

        private void msktxtJobOrderDate_TextChanged(object sender, EventArgs e)
        {
            AddJobOrder();
            txtJobOrderDate.Text = msktxtJobOrderDate.Text;
        }

        private void txtJobOrderDate_TextChanged(object sender, EventArgs e)
        {
            AddJobOrder();

        }

        private void cboPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddJobOrder();

        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            AddJobOrder();

        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            float sumSubTotal = 0;
            int max;
            max = lvwJobDetails.Items.Count;
            item = lvwJobDetails.Items.Add(lblSupplyID.Text);
            item.SubItems.Add(cboSupplyItems.Text);
            item.SubItems.Add(txtSupplier.Text);
            item.SubItems.Add(txtSize.Text);
            item.SubItems.Add(txtUnitMeasure.Text);
            item.SubItems.Add(txtQuantity.Text);
            item.SubItems.Add(txtPrice.Text);
            item.SubItems.Add(txtSubtotal.Text);
            foreach (ListViewItem lsItem in lvwJobDetails.Items)
            {
                sumSubTotal += float.Parse(lsItem.SubItems[7].Text);
            }
            txtTotalAmount.Text = sumSubTotal.ToString();
            cboSupplyItems.SelectedIndex = -1;
            txtSupplier.Text = "";
            txtSize.Text = "";
            txtUnitMeasure.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtSupplyPrice.Text = "";
        }


        public void AddJobOrder()
        {
            int joborderdate = txtJobOrderDate.TextLength;
            int customername = cboCustomerName.SelectedIndex;
            int employeename = cboEmployeeLastName.SelectedIndex;
            int paymenttype = cboPaymentType.SelectedIndex;
            int totalamount = txtTotalAmount.TextLength;
            if (joborderdate > 15 && customername > -1 && employeename > -1 && paymenttype > -1 && totalamount > 0)
            {
                btnAddJobOrderDetails.Enabled = true;
            }
            else
            {
                btnAddJobOrderDetails.Enabled = false;
            }
        }

        private void btnAddJobOrderDetails_Click(object sender, EventArgs e)
        {

            myConn.Open();
            string balance = float.Parse(txtBalance.Text).ToString();
            float balanceTransaction = float.Parse(balance);
            if (balanceTransaction > -10000)
            {
                if (txtDiscount.Text == "")
                {
                    //UPDATE customer_account SET balance = balance - 20 WHERE customerID = 2
                    string myQuery = "INSERT INTO jobOrder (jobOrderDate,customerID,employeeID,paymentType,totalAmount) values('" + msktxtJobOrderDate.Text + "'," + lblCustomerID.Text + "," + lblEmployeeID.Text + ",'" + cboPaymentType.SelectedIndex + "'," + txtTotalAmount.Text + ")";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);

                }
                else
                {

                    string myQuery = "INSERT INTO jobOrder (jobOrderDate,customerID,employeeID,paymentType,totalAmount,discount) values('" + msktxtJobOrderDate.Text + "', " + lblCustomerID.Text + "," + lblEmployeeID.Text + "," + cboPaymentType.SelectedIndex + "," + txtDiscountedTotalAmount.Text + "," + txtDiscount.Text + ")";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);

                }
                myConn.Close();
                foreach (ListViewItem lsItem in lvwJobDetails.Items)
                {
                    try
                    {
                        myConn.Open();
                        string myQuer = "SELECT max(jOrd_Num) as 'jOrd_Num' FROM jobOrder";
                        MySqlCommand myCom = new MySqlCommand(myQuer, myConn);
                        MySqlDataAdapter myAd = new MySqlDataAdapter(myCom);
                        myConn.Close();
                        myConn.Open();
                        MySqlDataReader myReader;
                        try
                        {
                            myReader = myCom.ExecuteReader();
                            while (myReader.Read())
                            {
                                jOrdID = myReader.GetString(0);
                            }
                            myConn.Close();

                            string query = "INSERT INTO jOrder_Details(jOrd_Num,supply_itemsID,size,unit_measure,quantity,price) VALUES (" + jOrdID + "," + lsItem.SubItems[0].Text + "," + lsItem.SubItems[3].Text + ",'" + lsItem.SubItems[4].Text + "'," + lsItem.SubItems[5].Text + "," + lsItem.SubItems[6].Text + ");";
                            MySqlCommand comm = new MySqlCommand(query, myConn);
                            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                            DataTable dt = new DataTable();
                            adp.Fill(dt);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        myConn.Close();
                        myConn.Open();
                    }
                    catch
                    {

                    }
                }
                if (txtDiscount.Text == "")
                {
                    string myQuery = "UPDATE customer_account SET balance = balance - " + txtTotalAmount.Text + " WHERE customerID = " + lblCustomerID.Text;
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                }

                else
                {
                    string myQuery = "UPDATE customer_account SET balance = balance - " + txtDiscountedTotalAmount.Text + " WHERE customerID = " + lblCustomerID.Text;
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                }
                myConn.Close();
                MessageBox.Show("Insert Successful!");
                this.Close();
            }
            else
            {
                lblValidate.Text = "The credit limit of " + cboCustomerName.Text + "has already reach its limit";
            }
        }

        private void frmJobOrderDetails_Load(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged_1(object sender, EventArgs e)
        {
            float discounted_total_amount = 0;
            try
            {
                if (txtTotalAmount.Text != "" && txtDiscount.Text != "")
                {
                    discounted_total_amount = float.Parse(txtTotalAmount.Text) * (float.Parse(txtDiscount.Text) / 100);
                    txtDiscountedTotalAmount.Text = (float.Parse(txtTotalAmount.Text) - discounted_total_amount).ToString();
                }

                else
                {
                    txtDiscountedTotalAmount.Text = "";
                }

            }
            catch
            {

            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDiscount.TextLength >= 3)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
