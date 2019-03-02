using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PYLsystems.EmployeeManagement
{   //Add Employee storage handler before passing to database as well handling Add Employee-relatedForms.
    public partial class addEmployeeInstance
    {
        addEmpForm addEmployee;
        addUserForm addUser; 
        EmployeeList parentForm;
        public addEmployeeInstance(EmployeeList parent)
        {
            this.parentForm = parent;
            addEmployee = new addEmpForm(this);
            addUser = new addUserForm(this);
        }
        //Form opener methods
        public void openAddEmployeeForm(EmployeeList form, EventArgs e) //open from employee list
        {
            addEmployee.ShowDialog();
        }
        private void openAddUserForm(addEmpForm form, EventArgs e)
        {         
            addUser.ShowDialog();
        }
        //data storage methods
    }
}
