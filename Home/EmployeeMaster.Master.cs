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
using LMS.Service.Helper;

namespace Home
{
    public partial class EmployeeMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                if (WindowsIdentity.GetCurrent().IsAuthenticated)
                {
                    EmployeeRepository employeeRepository = new EmployeeRepository();
                    var name = AuthenticationHelper.username;
                    lblusername.Text = name;
                    int role = AuthenticationHelper.role;
                    if ((ApplicationRoles)role == ApplicationRoles.USER)
                    {
                        menuItemAddEmployee.Visible = false;
                        menuItemEmployeeLeaveApproval.Visible = false;
                        menuItemEmployeeLeaveDetails.Visible = false;
                        menuItemEmployeeList.Visible = false;
                    }
                    if ((ApplicationRoles)role == ApplicationRoles.MANAGER)
                    {
                        menuItemAddEmployee.Visible = false;
                        menuItemEmployeeLeaveApproval.Visible = true;
                        menuItemEmployeeLeaveDetails.Visible = false;
                        menuItemEmployeeList.Visible = false;
                    }
                }
        }

          

        }


    }

