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
    public partial class EmployeeView1 : System.Web.UI.Page
    {
        internal readonly IEmployee employees = new EmployeeRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["EMP_ID"] != null)
                {
                    viewEmployee(Convert.ToInt32(Request.QueryString["EMP_ID"]));
                }

            }
        }
        protected void viewEmployee(int EmployeeID)
        {
            AllEmployeeDetails objemployee = employees.getEmployee(EmployeeID);
            // Label1.Text = objemployee.EMP_ID;
            lblName.Text = objemployee.FirstName;
            lblFullName.Text = objemployee.FullName;
            lblAddress.Text = objemployee.Address;
            lblEmail.Text = objemployee.Email;
            lblPersonalEmail.Text = objemployee.PersonalEmailId;
            lblMobileNumber.Text = Convert.ToString(objemployee.Mobile);
            lblGender.Text = objemployee.Gender;
            lblDOB.Text = Convert.ToString(objemployee.DOB);
            lblJoiningDate.Text = Convert.ToString(objemployee.JoiningDate);


        }
       
    }
}