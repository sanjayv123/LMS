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
            if (WindowsIdentity.GetCurrent().IsAuthenticated)
            {
                EmployeeRepository employeeRepository = new EmployeeRepository();                
                //var username = Session["username"].ToString();
                //var role   = employeeRepository.GetUser(username);
                //var getRoleId = employeeRepository.GetRole(Convert.ToInt32(role.RoleId));
                lblusername.Text = WindowsIdentity.GetCurrent().Name;
                // Menu3.Visible = getRoleId.Authorization;
            }
        }
    }
}