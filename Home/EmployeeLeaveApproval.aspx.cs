using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LMS.Service;

namespace Home
{
    public partial class EmployeeLeaveApproval : System.Web.UI.Page
    {
        private EmployeeRepository employeeRepository;
        private static bool leaveApprovalStatus;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                
                //pass manager id on login

                employeeRepository = new EmployeeRepository();
                var allEmployeeLeaveDetails = employeeRepository.getleaveDetailsForApproval(2);
                if (allEmployeeLeaveDetails != null)
                {
                    gvEmployeeLeave.DataSource = allEmployeeLeaveDetails;
                    gvEmployeeLeave.DataBind();
                }
            }

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
           
        }

   

        protected void _updateApproval(object sender, GridViewCommandEventArgs e)
        {
            employeeRepository = new EmployeeRepository();
            if (e.CommandName == "UpdateLeaveApproval")
                  employeeRepository.updateleaveApprovalstatus(Convert.ToInt32(e.CommandArgument),true);
            
            if(e.CommandName=="UpdateLeaveReject")       
                  employeeRepository.updateleaveApprovalstatus(Convert.ToInt32(e.CommandArgument),false);   
              
            Response.Redirect("EmployeeLeaveApproval.aspx");
        }

        protected void _UpdateLeaveApprovalOnCheckedChanged(object sender, EventArgs e)
        {
           //employeeRepository = new EmployeeRepository();
          // employeeRepository.updateleaveApprovalstatus();
        }

    }
}