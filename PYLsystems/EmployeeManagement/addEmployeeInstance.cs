using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYLsystems.EmployeeManagement
{
    public partial class addEmployeeInstance
    {
        //Add Employee storage handler before passing to database as well handling Add Employee-relatedForms.
        EmployeeList parentForm;
        public addEmployeeInstance(EmployeeList parent)
        {
            this.parentForm = parent;
        }
        internal void employeeListBoot()//running from Add Employee
        {
            openAddEmployeeForm();
        }
        internal void handlingAddEmployeeForms()//handles form Transition
        {
        }
        //Form opener methods
        private void openAddEmployeeForm()
        {
            addEmpForm addEmployee = new addEmpForm(this);
            addEmployee.ShowDialog();
        }
        private void openAddUserForm()
        {
            addUserForm addUser = new addUserForm(this);
            addUser.ShowDialog();
        }
        //data storage methods
    }
}
