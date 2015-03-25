using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using LMS.Data;
using LMS.Service;
using System.Globalization;
using System.Web.DynamicData;
using LMS.Service.Helper;

namespace Home
{
    public partial class EmployeeLeaveDetails : System.Web.UI.Page
    {
        private EmployeeRepository employeeRepository;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                employeeRepository = new EmployeeRepository();
                var allEmployeeLeaveDetails = employeeRepository.getleaveDetailsForAllEmployee();
                if (allEmployeeLeaveDetails != null)
                {
                    gvEmployeeLeave.DataSource = allEmployeeLeaveDetails;
                    gvEmployeeLeave.DataBind();
                }
            }
        }
    }
}