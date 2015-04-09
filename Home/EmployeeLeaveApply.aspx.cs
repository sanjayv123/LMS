using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using LMS.Data;
using LMS.Service;
using System.Globalization;
using System.Security.Principal;
using System.Web.DynamicData;
using LMS.Service.Helper;

namespace Home
{
    public partial class EmployeeLeaveApply : System.Web.UI.Page
    {
        internal readonly IEmployee employees = new EmployeeRepository();
        private EmployeeRepository employeeRepository;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

               // string username = WindowsIdentity.GetCurrent().Name;
               // int employeeid = getEmployeeIDFromUsername(username);
                string username = AuthenticationHelper.username;
                int employeeid = getEmployeeIDFromUsername(username); 
                employeeRepository = new EmployeeRepository();
                ddlleavetype.DataSource = GetLeaveType();
                ddlleavetype.DataBind();

                var managerId = employeeRepository.getNewemployee(employeeid);
                var manager = employeeRepository.getNewemployee(managerId.ReportingManager);
                txtReportingManager.Text = manager.FullName;
                txtFillManagerID.Text = managerId.ReportingManager.ToString();

                var query = employeeRepository.getleaveDetails(employeeid);

                if (query != null)
                {
                    gvEmployeeLeave.DataSource = query.ToList();
                    gvEmployeeLeave.DataBind();
                }
            }

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {

            string username = AuthenticationHelper.username;
          int employeeid = getEmployeeIDFromUsername(username);
          

            employeeRepository = new EmployeeRepository();
            var employeedetail = employeeRepository.getNewemployee(1);
            var departmentid = employeedetail.DepartmentId;
            var jobid = employeedetail.JobId;
            var leaveid =
                employeeRepository.getLeaveTypes()
                    .Where(l => l.LEAVE_TYPE == ddlleavetype.SelectedItem.ToString())
                    .Select(d => d.LEAVE_ID).FirstOrDefault();
                    
            TimeSpan totaldays = Convert.ToDateTime(txtleaveto.Text, System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat) -
                                 Convert.ToDateTime(txtleavefrom.Text, System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);
         
            var weekendAndHolidayCount = calculateWeekendorHolidayinLeave(Convert.ToDateTime(txtleavefrom.Text),
                Convert.ToDateTime(txtleaveto.Text));

            //var totalleaves = (totaldays - weekendAndHolidayCount) + 1;

            EmployeeLeave objleave = new EmployeeLeave
            {
                EmployeeId = employeeid,
                DepartmentId = departmentid,
                JobId = jobid,
                LeaveId = leaveid,
                LeaveStatus ="InProgress",
                LeaveReason = txtleavereason.Text,
                LeaveFromdate = Convert.ToDateTime(txtleavefrom.Text),
                LeaveToDate = Convert.ToDateTime(txtleaveto.Text),
                RemainingDays = 0, 
                ReJoiningdate = Convert.ToDateTime(txtleavejoiningdate.Text),
                LeaveApprovedBy = Convert.ToInt32(txtFillManagerID.Text),
                WeekendORHolidaysInLeave = weekendAndHolidayCount,
                TotaldaysOnLeaveCurrent =(int)totaldays.TotalDays-weekendAndHolidayCount+1,
                TotalLeaveTakenInYear = (int)totaldays.TotalDays - weekendAndHolidayCount+1,
            };
            employees.InsertIntoEmployeeLeave(objleave);
            Response.Redirect("EmployeeLeaveApply.aspx");
            //    Response.Redirect("EmployeeLeaveAppliedList.aspx");
        }


        public int calculateWeekendorHolidayinLeave(DateTime fromdate, DateTime todate)
        {
            employeeRepository = new EmployeeRepository();
            var holidayAndWeekendList = employeeRepository.getCalendar();
            List<string> leavedatesList = new List<string>();
            int weekendAndHolidayCount = 0;
            DateTime leaveStartDate = fromdate;
            DateTime leaveEnddate = todate;
            for (DateTime date = leaveStartDate; date <= leaveEnddate; date = date.AddDays(1))
                leavedatesList.Add(date.ToShortDateString());
            var spanLeavedates = leavedatesList;
            foreach (var VARIABLE in spanLeavedates)
            {
                if (holidayAndWeekendList.Contains(VARIABLE))
                {
                    weekendAndHolidayCount++;
                }
            }
            return weekendAndHolidayCount;
        }


        public List<string> GetLeaveType()
        {
            employeeRepository = new EmployeeRepository();
            var leave = employeeRepository.getLeaveTypes();
            var leavetype = leave.Select(e => e.LEAVE_TYPE).ToList();
            return leavetype.ToList();
        }

        protected void _gvEmployeeLeaveRowCommand(object sender, GridViewCommandEventArgs e)
        {
            //string username = WindowsIdentity.GetCurrent().Name;
           // int employeeid = getEmployeeIDFromUsername(username);
            string username = AuthenticationHelper.username; 
            int employeeid = getEmployeeIDFromUsername(username);

            if (e.CommandName == "CancelLeave")
            {
                employeeRepository = new EmployeeRepository();
                employeeRepository.deleteEmployeeLeave(Convert.ToInt32(e.CommandArgument));
                var query = employeeRepository.getleaveDetails(Convert.ToInt32(employeeid));
                if (query != null)
                {
                    gvEmployeeLeave.DataSource = query.ToList();
                    gvEmployeeLeave.DataBind();
                }
            }
        }


        public int getEmployeeIDFromUsername(string userName)
        {
           // var username = userName.Split('\\');
            employeeRepository = new EmployeeRepository();
            var employeeid = employeeRepository.getEmployeeFromUserName(userName);
            return employeeid.Select(e => e.EmployeeID).FirstOrDefault();
            //var employeeId = employeeRepository.getEmployeedetails();
            //return employeeId.Select(e => e.RoleId).FirstOrDefault();

        }


    }
}