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
    public partial class LoginForm : Form
    {
        internal int employeeStatus;
        internal bool LogInMatch = false;
        internal int employeeid;
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        Home parenthomeForm;
        public LoginForm()
        {
            InitializeComponent();
        }
        public LoginForm(Home parenthomeForm) {
            InitializeComponent();
            this.parenthomeForm = parenthomeForm;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
     
            string username = this.usernameTextBox.Text;
            string password = this.passwordTextBox.Text;

            bool r = loginValidate(username, password);
            if (r)
            {
    
                
                //openHome();
                this.Close();
            }
            else if (username == "" || password == "")
            {
                MessageBox.Show("Can't Login. Try again");
            }
            else
            {
                MessageBox.Show("Can't Login. Try again");
            }
        }
        private void openHome() {
            Home homeForm = new Home(employeeid,employeeStatus);
            homeForm.Show();
        }
        private bool loginValidate(string username, string password)
        {
            DataTable empStat_dt;
            DataTable empId_dt;
            try
            {             
                MySqlConnection my_conn = new MySqlConnection(connString);
                String query = "SELECT * FROM employee WHERE username = @username AND password = @password;";
                MySqlCommand command = new MySqlCommand(query, my_conn);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password); // AddWithValue for security SQL injection
                MySqlDataReader LogInReader;
                my_conn.Open();

                LogInReader = command.ExecuteReader();     // execute query
                LogInMatch = LogInReader.Read(); // gets if both username and password are right. outputs TRUE if right.
                my_conn.Close();
                if (LogInMatch) //getEmployeeStatus number
                {

                    query = "SELECT employeeStatus FROM employee WHERE username = @username;";
                    command = new MySqlCommand(query, my_conn);
                    command.Parameters.AddWithValue("@username", username);
                    my_conn.Open();
                    employeeStatus = Convert.ToInt32(command.ExecuteScalar());
                    my_conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (LogInMatch)
            {
                String employeeStatus_String = "SELECT employeeStatus FROM employee WHERE username = @username AND password = @password;";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand employeeStatus_Command = new MySqlCommand(employeeStatus_String, my_conn);
                employeeStatus_Command.Parameters.AddWithValue("@username", username);
                employeeStatus_Command.Parameters.AddWithValue("@password", password);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(employeeStatus_Command);
                empStat_dt = new DataTable();
                my_adapter.Fill(empStat_dt);
                parenthomeForm.employeeStatus = Int32.Parse(empStat_dt.Rows[0][0].ToString());


                String employeeId_String = "SELECT employeeID FROM employee WHERE username = @username AND password = @password;";
                MySqlCommand employeeId_Command = new MySqlCommand(employeeId_String, my_conn);
                employeeId_Command.Parameters.AddWithValue("@username", username);
                employeeId_Command.Parameters.AddWithValue("@password", password);
                my_adapter = new MySqlDataAdapter(employeeId_Command);
                empId_dt = new DataTable();
                my_adapter.Fill(empId_dt);
                parenthomeForm.employeeId = Int32.Parse(empId_dt.Rows[0][0].ToString());

                //MessageBox.Show(employeeid.ToString() + " " + employeeStatus.ToString());
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!LogInMatch) {
                Application.Exit();
            }
        }


        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(this, e);
                    
            }
        }
    }
}
