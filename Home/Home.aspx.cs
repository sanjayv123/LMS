using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using LMS.Data;
using LMS.Service;


namespace Home
{
    public partial class Home : System.Web.UI.Page
    {
        private EmployeeRepository employeeRepository;
        protected void Page_Load(object sender, EventArgs e)
        {
            
                  string username = WindowsIdentity.GetCurrent().Name;
                  int employeeid = getEmployeeIDFromUsername(username);
               // string username = AuthenticationHelper.username;
               // int employeeid = getEmployeeIDFromUsername(username);
                  employeeRepository = new EmployeeRepository();
                  var employee = employeeRepository.getNewemployee(employeeid);
                  if (employee != null)
                 {
                    lblname.Text = employee.FullName;
                    lblEmployeecode.Text = employee.EmployeeCode.ToString();
                    lblAddress.Text = employee.Address;
                    lblMobileNo.Text = employee.Mobile.ToString();
                    lblemailId.Text = employee.Email;
                    lblDOB.Text = employee.DOB.ToString();
                    lblthaughts.Text = getThaughtsFortheDay();
                    lblevents.Text = getEvents();
                 }
            

        }
        public int getEmployeeIDFromUsername(string userName)
        {
              var username = userName.Split('\\');
              employeeRepository = new EmployeeRepository();
              var employeeId = employeeRepository.getEmployeeFromUserName(username[1]);
           // var employeeId = employeeRepository.getEmployeeFromUserName(userName);
              return employeeId.Select(e => e.EmployeeID).FirstOrDefault();
        }

        public string getThaughtsFortheDay()
        {
            employeeRepository = new EmployeeRepository();
            return employeeRepository.getThaughts();
        }

        public string getEvents()
        {
            employeeRepository = new EmployeeRepository();
            return employeeRepository.getEvents();
        }

    }
}