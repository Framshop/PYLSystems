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
    public partial class frmAddSupplyCategory : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public static string supply_categoryID = "";
        public frmAddSupplyCategory()
        {
            InitializeComponent();
        }

        private void frmCreateSupplyCategory_Load(object sender, EventArgs e)
        {
            reload();
            enable();
            }



        public void reload()
        {
            string query = "SELECT  supply_categoryID, categoryName, categoryDescription,typeOfMeasure FROM supply_category";
            MySqlCommand myComm = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            dgSupplyCategories.DataSource = myDt;
            conn.Close();


            dgSupplyCategories.Columns["supply_categoryID"].Visible = false;
            dgSupplyCategories.Columns["categoryName"].HeaderText = "Category Name";
            dgSupplyCategories.Columns["categoryDescription"].HeaderText = "Category Description";
            dgSupplyCategories.Columns["typeOfMeasure"].HeaderText = "Type of Measure";

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();

            string myQuery = "Insert INTO supply_category( categoryName, categoryDescription, typeOfMeasure) values('" + txtCategoryName.Text + "','"  + txtCategoryDescription.Text + "','" + cbTypeofMeasure.Text + "')";
            MySqlCommand myComm = new MySqlCommand(myQuery, conn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            conn.Close();
            reload();

       

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCategoryName.Clear();
            txtCategoryDescription.Clear();
            cbTypeofMeasure.SelectedIndex = -1;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string myQuery = "UPDATE supply_category set categoryName ='" + txtCategoryName.Text + "', categoryDescription = '" + txtCategoryDescription.Text+ "', typeOfMeasure ='" + cbTypeofMeasure.Text + "' where supply_categoryID = " + supply_categoryID ;
            MySqlCommand myComm = new MySqlCommand(myQuery, conn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            conn.Close();
            MessageBox.Show("Update Success");
            reload();

            txtCategoryName.Clear();
            txtCategoryDescription.Clear();
            cbTypeofMeasure.SelectedIndex = -1;
            btnUpdate.Enabled = false;


        }

        private void dgSupplyCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
            supply_categoryID = dgSupplyCategories.CurrentRow.Cells[0].Value.ToString();
            txtCategoryName.Text = dgSupplyCategories.CurrentRow.Cells[1].Value.ToString();
            txtCategoryDescription.Text = dgSupplyCategories.CurrentRow.Cells[2].Value.ToString();
            cbTypeofMeasure.Text = dgSupplyCategories.CurrentRow.Cells[3].Value.ToString();

            btnUpdate.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT supply_categoryID, categoryName, categoryDescription, typeOfMeasure FROM supply_category  where categoryName LIKE '%" + txtSearch.Text + "%' OR categoryDescription LIKE '%" + txtSearch.Text + "%' OR typeOfMeasure LIKE '%" + txtSearch.Text + "%'";
            MySqlCommand myComm = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            dgSupplyCategories.DataSource = myDt;
            conn.Close();
        }



        private void enable()
        {

            int categoryName = txtCategoryName.TextLength;
            int categoryDescription = txtCategoryDescription.TextLength;
            int typeOfMeasure = cbTypeofMeasure.SelectedIndex;



            if (categoryName > 0 && categoryDescription > 0 && typeOfMeasure > -1)
            {
                btnAdd.Enabled = true;
          
            }
            else
            {
                btnAdd.Enabled = false;
            
            }

        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            enable();
        }

        private void txtCategoryDescription_TextChanged(object sender, EventArgs e)
        {
            enable();
        }

        private void cbTypeofMeasure_SelectedIndexChanged(object sender, EventArgs e)
        {
            enable();
        }
    }
}
