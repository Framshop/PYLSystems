﻿using System;
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
    public partial class frmJobOrderTransaction : Form
    {

        public static string jOrd_Num = "";
        public static string totalAmount = "";
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmJobOrderTransaction()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //frmJobOrderDetails jobOrderDetails = new frmJobOrderDetails();
           // jobOrderDetails.ShowDialog();
            RefreshJobOrder();
        }
        public void RefreshJobOrder()
        {
            myConn.Open();
            string query = "SELECT j.jOrd_Num,c_a.customerFullName,CONCAT(e.lastName,' ',e.firstname) as 'name',j.jobOrderDate,j.voidReason,IF(j.paymenttype=0,'Cash','Credit Card') as 'PaymentType',j.totalAmount,c_p.customer_Payment,IFNULL(j.discount,'No Discount') as 'Discount' FROM customer_payment c_p LEFT JOIN customer_account c_a ON c_a.customerID = c_p.customerID LEFT JOIN joborder j ON j.jOrd_Num = c_p.jOrd_Num LEFT JOIN employee e ON e.employeeID = j.employeeID ORDER BY jOrd_Num DESC";

            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvJobOrders.DataSource = dt;
            dgvJobOrders.Columns["jOrd_Num"].HeaderText = "Job Order Number";
            dgvJobOrders.Columns["customerFullName"].HeaderText = "Customer Name";
            dgvJobOrders.Columns["name"].HeaderText = "Employee Name";
            dgvJobOrders.Columns["totalamount"].HeaderText = "Total Amount";
            dgvJobOrders.Columns["paymenttype"].HeaderText = "Payment Type";
            dgvJobOrders.Columns["joborderdate"].HeaderText = "Job Order Date";
            dgvJobOrders.Columns["voidreason"].HeaderText = "Transaction Type";
            dgvJobOrders.Columns["customer_Payment"].HeaderText = "Customer Payment";
            dgvJobOrders.Columns["jOrd_Num"].DefaultCellStyle.Format = "0000000";
            myConn.Close();
        }



        private void frmJobOrderTransaction_Load(object sender, EventArgs e)
        {
            RefreshJobOrder();
        }

        private void dgvJobOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                jOrd_Num = dgvJobOrders.CurrentRow.Cells[0].Value.ToString();
                totalAmount = dgvJobOrders.CurrentRow.Cells[0].Value.ToString();
       
                myConn.Open();
                string query = "SELECT s.supplierName,s_i.supplyName,j_d.quantity,j_d.price FROM jorder_details j_d LEFT JOIN supply_details s_d  ON s_d.supplyID = j_d.supply_itemsID LEFT JOIN supplier s ON s.supplierID = s_d.supplierID LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID WHERE jOrd_Num = " + jOrd_Num;
                MySqlCommand comm = new MySqlCommand(query, myConn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvJobOrderDetails.DataSource = dt;
                dgvJobOrderDetails.Columns["supplierName"].HeaderText = "Supplier Name";
                dgvJobOrderDetails.Columns["supplyName"].HeaderText = "Supply Name";
                dgvJobOrderDetails.Columns["quantity"].HeaderText = "Quantity";
                dgvJobOrderDetails.Columns["price"].HeaderText = "Price";
                myConn.Close();
            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
   
        private void btnCancelJobOrder_Click_1(object sender, EventArgs e)
        {
        }

        private void chkDone_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void chkOnGoing_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnFinishJobOrder_Click(object sender, EventArgs e)
        {
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            myConn.Open();
            string query = "SELECT j.jOrd_Num,c_a.customerFullName,CONCAT(e.lastName,' ',e.firstname) as 'name',j.jobOrderDate,j.voidReason,IF(j.paymenttype=0,'Cash','Credit Card') as 'PaymentType',j.totalAmount,c_p.customer_Payment,IFNULL(j.discount,'No Discount') as 'Discount' FROM customer_payment c_p LEFT JOIN customer_account c_a ON c_a.customerID = c_p.customerID LEFT JOIN joborder j ON j.jOrd_Num = c_p.jOrd_Num LEFT JOIN employee e ON e.employeeID = j.employeeID WHERE c_a.customerFullName LIKE '%" + txtSearch.Text +  "%' OR j.joborderdate LIKE '%" + txtSearch.Text + "%' OR j.totalAmount LIKE '%" + txtSearch.Text + "%' ORDER BY jOrd_Num DESC";

            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvJobOrders.DataSource = dt;
            dgvJobOrders.Columns["jOrd_Num"].HeaderText = "Job Order Number";
            dgvJobOrders.Columns["customerFullName"].HeaderText = "Customer Name";
            dgvJobOrders.Columns["name"].HeaderText = "Employee Name";
            dgvJobOrders.Columns["totalamount"].HeaderText = "Total Amount";
            dgvJobOrders.Columns["paymenttype"].HeaderText = "Payment Type";
            dgvJobOrders.Columns["joborderdate"].HeaderText = "Job Order Date";
            dgvJobOrders.Columns["voidreason"].HeaderText = "Transaction Type";
            dgvJobOrders.Columns["customer_Payment"].HeaderText = "Customer Payment";
            dgvJobOrders.Columns["jOrd_Num"].DefaultCellStyle.Format = "0000000";
            myConn.Close();
        }
    }
}
