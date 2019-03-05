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
    public partial class MainForm : Form
    {
        private int employeeStatus; //type of account based on database. 1 - admin programmer/owner, 2 - manager, 3 - cashier, 4 - framer.
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();
            //this.employeeStatus = loginForm.employeeStatus;
            homeControl_Load();

        }
        private void homeControl_Load() //initial load
        {
            HomeControl homeControl = new HomeControl(this);
            mainWindow(homeControl);
        }
        //for controls
        internal void homeControl_Load(UserControl oldControl)
        {
            HomeControl homeControl = new HomeControl(this);
            mainWindow(homeControl);
            oldControl.Dispose();
        }
        internal void empManControl_Load(UserControl oldControl)
        {
            EmpManControl empManageControl = new EmpManControl(this);
            mainWindow(empManageControl);
            oldControl.Dispose();

        }
        internal void empListControl_Load(UserControl oldControl)
        {
            EmployeeManagement.EmployeeList emplist = new EmployeeManagement.EmployeeList(this);
            mainWindow(emplist);
            oldControl.Dispose();

        }
        //Single Window interface. No opening of new window other than login
        private void mainWindow(UserControl newUserControl) {
            this.content.Controls.Clear();    
            this.content.Controls.Add(newUserControl);
        }
        
        //public void mainWindow(Form newForm, Form oldForm)
        //oldControl.Dispose();
        //{
        //    newForm.TopLevel = false;
        //    content.Controls.Clear();
        //    content.Controls.Add(newForm);
        //    newForm.Show();
        //    oldForm.Dispose();
        //}
        //public void mainWindow(Form newForm, Panel content)
        //{
        //    newForm.TopLevel = false;
        //    content.Controls.Clear();
        //    this.content.Controls.Clear();
        //    this.content.Controls.Add(newForm);
        //    newForm.Show();
        //}

        //public void homeForm_Load(Form form)
        //{
        //    form.Close();
        //    HomeForm homeForm = new HomeForm();
        //    mainWindow(homeForm);
        //}
        //public void empMan_Load(Form form, Panel prevPanel)
        //{
        //    //form.Close();
        //    EmpManage empManageForm = new EmpManage();
        //    mainWindow(empManageForm, prevPanel);
        //    form.Dispose();
        //}
        // public void empMan_Load(Form oldForm)
        //{
        //    //form.Close();
        //    EmpManage empManageForm = new EmpManage();
        //    mainWindow(oldForm,empManageForm);
        //}
        //private void MainForm_Load(object sender, EventArgs e)
        //{
        //    //LoginForm loginForm = new LoginForm();
        //    //loginForm.ShowDialog();
        //    //this.employeeStatus = loginForm.employeeStatus;
        //    homeControl_Load();
        //    /*this.accountId = loginForm.accountId;
        //    if (accountType == null)
        //    {
        //        Application.Exit();
        //    }
        //    else if (accountType.Contains("encoder"))
        //    {
        //        usersToolStripMenuItem.Enabled = false;
        //        menuStrip.ShowItemToolTips = true;
        //    }*/

        //}
    }
}
