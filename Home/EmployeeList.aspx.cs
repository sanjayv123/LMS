
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LMS.Service;
using LMS.Data;


namespace Home
{
    public partial class EmployeeList1 : System.Web.UI.Page
    {
       internal readonly IEmployee employees = new EmployeeRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (employees.getEmployeedetails().Count > 0)
            {
                gvEmployee.DataSource = employees.getEmployeedetails();
                gvEmployee.DataBind();
            }
            
        }

      
    }
    
}