using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LMS.Data;
using LMS.Service;
using System.Globalization;


namespace Home
{
    public partial class EmployeeForm1 : System.Web.UI.Page
    {
        internal readonly IEmployee employees = new EmployeeRepository();
        private EmployeeRepository employeeRepository;

        protected void Page_Load(object sender, EventArgs e)
        {
           if (!Page.IsPostBack)
            {

                if (Request.QueryString["EMP_ID"] != null)
                {
                    int value;
                    if (int.TryParse(Request.QueryString["EMP_ID"], out value))
                        showEmployee(Convert.ToInt32(Request.QueryString["EMP_ID"]));
                    btnsave.Text = "Update";
                    lblEmployeeFormType.Text = "Update Employee";
                }
               else
                {
                    lblEmployeeFormType.Text = "Add New Employee";
                }

                fillAllDropDownList();
            }

        }


        public void fillAllDropDownList()
        {
            employeeRepository = new EmployeeRepository();
            var departmentList = employeeRepository.getAllDepartment();
            var jobRoleList = employeeRepository.getAlljobDescription();
            var reportingManagerList = employeeRepository.getmanager();
            var rolelist = employeeRepository.getallrole();
            foreach (var deptname in departmentList)
            {
                ddlDepartmentList.Items.Add(deptname.DEP_NAME);
            }

            foreach (var jobrole in jobRoleList)
            {
                ddlJobRole.Items.Add(jobrole.JOB_ROLE);
            }

            foreach (var reportmanager in reportingManagerList)
            {                
                ddlReportingManager.Items.Add(reportmanager.FullName);
            }

            foreach (var role in rolelist)
            {
                ddlRoleList.Items.Add(role.RoleName);
            }

         
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            //getdepartmentId
            employeeRepository = new EmployeeRepository();     
            var departmentList = employeeRepository.getAllDepartment();
            var jobRoleList = employeeRepository.getAlljobDescription();
            var departmentid = departmentList.Where(d => d.DEP_NAME == ddlDepartmentList.SelectedItem.ToString()).Select(d => d.DEP_ID).FirstOrDefault();
            var jobid = jobRoleList.Where(j => j.JOB_ROLE == ddlJobRole.SelectedItem.ToString()).Select(j => j.JOB_ID).FirstOrDefault();
            var reportingManagerList = employeeRepository.getmanager();
            var reportingManagerId = reportingManagerList.Where(r => r.FullName == ddlReportingManager.SelectedItem.ToString()).Select(r=>r.EmployeeID).FirstOrDefault();
            var rolelist = employeeRepository.getallrole();
            var roleid = rolelist.Where(r => r.RoleName == ddlRoleList.SelectedItem.ToString()).Select(r => r.RoleId).FirstOrDefault();
            //getjobid


            AllEmployeeDetails objEmployee = new AllEmployeeDetails();
            objEmployee.DepartmentId = Convert.ToInt32(departmentid);
            objEmployee.JobId = Convert.ToInt32(jobid);
            objEmployee.FirstName = txtname.Text;
            objEmployee.LastName = txtSurname.Text;
            objEmployee.FullName = txtname.Text + " " + txtSurname.Text; 
            objEmployee.Address = txtaddress.Text;
            objEmployee.Email = txtemail.Text;
            objEmployee.PersonalEmailId= txtpersonalemail.Text;
            objEmployee.Mobile= Convert.ToInt32(txtmobile.Text);
            objEmployee.PhoneNo= Convert.ToInt32(txtphone.Text);
            objEmployee.EmployeeCode= Convert.ToInt32(txtempcode.Text);
            objEmployee.DOB = Convert.ToDateTime(txtDOB.Text);
            objEmployee.JoiningDate= Convert.ToDateTime(txtJoiningDate.Text);
            objEmployee.Gender= ddlGender.SelectedValue;
            objEmployee.ReportingManager = Convert.ToInt32(reportingManagerId);
            objEmployee.UserName = txtusername.Text;
            objEmployee.RoleId = Convert.ToInt32(roleid);

            if (btnsave.Text == "Save")
            {
              
              employees.InsertIntoEmployee(objEmployee);
              Response.Redirect("EmployeeList.aspx");
            }
            else
            {
                int EmployeeID = 0;
                
                if (!String.IsNullOrEmpty(Request.QueryString["EMP_ID"].ToString()))
                {
                    EmployeeID = Convert.ToInt32(Request.QueryString["EMP_ID"]);
                }
               
                objEmployee.EmployeeID = EmployeeID;
                employees.updateEmployee(objEmployee);
                Response.Redirect("EmployeeList.aspx");
               
            }

        }
      
        protected void showEmployee(int EmployeeID)
        {
            AllEmployeeDetails objEmployee = employees.getEmployee(EmployeeID);
            txtname.Text = objEmployee.FirstName;
           // txtfullname.Text = objEmployee.FullName;
            txtaddress.Text = objEmployee.Address;
            txtemail.Text = objEmployee.Email;
            txtpersonalemail.Text = objEmployee.PersonalEmailId;
            txtmobile.Text = Convert.ToString(objEmployee.Mobile);
            txtphone.Text = Convert.ToString(objEmployee.PhoneNo);
            txtempcode.Text = Convert.ToString(objEmployee.EmployeeCode);
            txtDOB.Text = objEmployee.DOB.ToString();
            txtJoiningDate.Text = objEmployee.JoiningDate.ToString();
            ddlGender.SelectedValue = objEmployee.Gender;
        }

       //////for job
       // public List<Tuple<int, string>> getJobRoleAndId()
       // {
       //     List<Tuple<int, string>> jobList = new List<Tuple<int, string>>();

       //     var jobRoleList = employeeRepository.getAlljobDescription();
       //     foreach (var job in jobRoleList)
       //     {
       //         jobList.Add(new Tuple<int, string>(job.JOB_ID, job.JOB_ROLE));
       //     }
       //     return jobList;
       // }


       //// //for department
       // public List<Tuple<int, string>> getDepartmentNameAndId()
       // {
       //     List<Tuple<int, string>> department = new List<Tuple<int, string>>();

       //     var departmentList = employeeRepository.getAllDepartment();
       //     foreach (var depart in departmentList)
       //     {
       //         department.Add(new Tuple<int, string>(depart.DEP_ID, depart.DEP_NAME));
       //     }
       //     return department;
       // }

       //////for manager
       // public List<Tuple<int, string>> getManagerNameAndId()
       // {
       //     List<Tuple<int, string>> managerlList = new List<Tuple<int, string>>();

       //     var manager = employeeRepository.getmanager();
       //     foreach (var mng in manager)
       //     {
       //         managerlList.Add(new Tuple<int, string>(mng.EmployeeID, mng.FullName));
       //     }
       //     return managerlList;
       // }
     

    }
}