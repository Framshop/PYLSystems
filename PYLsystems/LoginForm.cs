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
        bool LogInMatch = false;
        public LoginForm()
        {
            InitializeComponent();
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

        private bool loginValidate(string username, string password)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
                string query = "SELECT * FROM pyldb.users WHERE username = @username AND password = @password;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password); // AddWithValue for security SQL injection
                MySqlDataReader LogInReader;
                connection.Open();

                LogInReader = command.ExecuteReader();     // execute query
                LogInMatch = LogInReader.Read(); // gets if both username and password are right. outputs TRUE if right.
                connection.Close();
                if (LogInMatch) //getEmployeeStatus number
                {

                    query = "SELECT employeeStatus FROM pyldb.users WHERE username = @username;";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    connection.Open();
                    employeeStatus = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (LogInMatch)
            {

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
    }
}
