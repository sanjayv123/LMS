using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Principal;

using LMS.Data;
using LMS.Service;

namespace Home
{
    public partial class EmployeeMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (WindowsIdentity.GetCurrent().IsAuthenticated)
            //{
            //    EmployeeRepository employeeRepository = new EmployeeRepository();                
            //   var name= WindowsIdentity.GetCurrent().Name.Split('\\');
            //    lblusername.Text = name[1];
            //   var roleid= getEmployeeIDFromUsername(name[1]);
            //    if (roleid == 2)

            //    {
            //        menuItemAddEmployee.Visible = false;
            //        menuItemEmployeeLeaveApproval.Visible = false;
            //        menuItemEmployeeLeaveDetails.Visible = false;
            //    }
   
            //}
        }

        public int getEmployeeIDFromUsername(string userName)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            var employeeId = employeeRepository.getEmployeeFromUserName(userName);
            return employeeId.Select(e=>e.RoleId).FirstOrDefault();
        }

    }
}