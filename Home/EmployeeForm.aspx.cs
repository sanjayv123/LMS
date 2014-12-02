using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LMS.Data;
using LMS.Service;

namespace Home
{
    public partial class EmployeeForm : System.Web.UI.Page
    {
        internal readonly IEmployee employees = new EmployeeRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            gd1.DataSource = employees.getEmployeedetails();

        }
    }
}