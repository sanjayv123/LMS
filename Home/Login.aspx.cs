using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using LMS.Data;
using LMS.Service;

namespace Home
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Authentication(TextBox1.Text, TextBox2.Text);
        }

        public void Authentication(string username, string password)
        {

            EmployeeRepository employeeRepository = new EmployeeRepository();

            var getUserDetail = employeeRepository.GetUser(username);

            if (getUserDetail.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && getUserDetail.Password == password)
            {
                Session["username"] = username;
                Response.Redirect("~/Home.aspx");
            }
            else
            {
                Response.Redirect("~/Login.aspx");
                Label1.Text = "Authentication failed";
                Label1.ForeColor =Color.Red;
            }
        }

    }
}