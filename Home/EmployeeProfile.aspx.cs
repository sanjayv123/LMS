using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Security.Principal;
using System.Web.DynamicData;
using LMS.Service;
using LMS.Service.Helper;
using LMS.Data;


namespace Home
{
    public partial class EmployeeProfile : System.Web.UI.Page
    {
        internal readonly IEmployee employees = new EmployeeRepository();
        private EmployeeRepository employeeRepository;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                employeeRepository = new EmployeeRepository();
                string username = AuthenticationHelper.username;
                int employeeid = getEmployeeIDFromUsername(username);
                 
               // int employeeid = getEmployeeIDFromUsername(username); 

                var leaveMaster = getTotalLeaveCount();
                lbltotalcasualleaves.Text = leaveMaster.Where(l => l.LEAVE_ID == 301).Select(l => l.LEAVE_TOTALDAYS).FirstOrDefault().ToString();

                var joiningDate = employeeRepository.getEmployee(employeeid).JoiningDate;
                lblTotalPlannedLeaves.Text = getemployeeEarnedleave(Convert.ToDateTime(joiningDate)).ToString();
                lblTotalSickLeaves.Text = leaveMaster.Where(l => l.LEAVE_ID == 303).Select(l => l.LEAVE_TOTALDAYS).FirstOrDefault().ToString();

                lbltotalcasualleavesTaken.Text = gettotalleavetaken(employeeid).ToString();
                lblTotalPlannedLeavesTaken.Text = gettotalPlannedleavetaken(employeeid).ToString();
                lblTotalSickLeavesTaken.Text = gettotalSickleavetaken(employeeid).ToString();
                lbltotalcasualleavesAvailable.Text = getavailableCasualleave(employeeid).ToString();
                lblTotalPlannedLeavesAvailable.Text = getavailablePlannedleave(employeeid).ToString();
                lblTotalSickLeavesAvailable.Text = getavailableSickleave(employeeid).ToString();
                
            }
        }
        protected void viewProfile(int employeeid)
        {
            employeeRepository = new EmployeeRepository();
          //  string username = WindowsIdentity.GetCurrent().Name;
           // string username = "AksharS";
           
            var employeedetail = employeeRepository.getNewemployee(1);
            var departmentid = employeedetail.DepartmentId;
            var jobid = employeedetail.JobId;

        }

        public int getEmployeeIDFromUsername(string userName)
        {
           // var username = userName.Split('\\');
            string username = AuthenticationHelper.username; 
            employeeRepository = new EmployeeRepository();
            var employeeId = employeeRepository.getEmployeeFromUserName(userName);
            return employeeId.Select(e => e.EmployeeID).FirstOrDefault();
           // var employeeId = employeeRepository.getEmployeedetails();
           // return employeeId.Select(e => e.roleid).FirstOrDefault();
        }

        public List<string> GetLeaveType()
        {
            employeeRepository = new EmployeeRepository();
            var leave = employeeRepository.getLeaveTypes();
            var leavetype = leave.Select(e => e.LEAVE_TYPE).ToList();
            return leavetype.ToList();
        }

        public List<Leave> getTotalLeaveCount()
        {
            employeeRepository = new EmployeeRepository();
            var leaveMasterdDetails = employeeRepository.getLeaveTypes();
            return leaveMasterdDetails;
        }


        public double getemployeeEarnedleave(DateTime joiningdate)
        {
            DateTime firstdayofmonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var date1 = Convert.ToDateTime(firstdayofmonth, System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);
            var month = ((date1.Year - joiningdate.Year) * 12) + date1.Month - joiningdate.Month;
            TimeSpan totalworkingdays = Convert.ToDateTime(firstdayofmonth, System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat) -
                                  Convert.ToDateTime(joiningdate, System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);
            return (month) * 1.25;

        }

        public int gettotalleavetaken(int employeeid)
        {
           employeeRepository = new EmployeeRepository();
           var totalleaves = employeeRepository.getleaveDetails(employeeid).Where(l => l.LeaveType == "Casual").Sum(l => l.TotaldaysOnLeaveCurrent);
           //foreach (var item in getleaveDetails)
           //{
           //    totalleaves += item.TotalLeaveTakenInYear;
           //}
           return totalleaves;
        }

        public int getavailableCasualleave(int employeeid)
        {
            employeeRepository = new EmployeeRepository();
            var leaveMaster = getTotalLeaveCount();
            var leave = leaveMaster.Where(l => l.LEAVE_ID == 301).Select(l => l.LEAVE_TOTALDAYS).FirstOrDefault();
            var totalleaves = employeeRepository.getleaveDetails(employeeid).Where(l=> l.LeaveType == "Casual").Sum(l => l.TotaldaysOnLeaveCurrent);
            var totalavailable =Convert.ToInt16( leave - totalleaves);
            return totalavailable;    
        }

        public int gettotalPlannedleavetaken(int employeeid)
        {
            employeeRepository = new EmployeeRepository();
            var leave = employeeRepository.getleaveDetails(employeeid).Where(l => l.LeaveType == "Planned").Sum(l =>l.TotaldaysOnLeaveCurrent);
            return leave;
        }

        public int gettotalSickleavetaken(int employeeid)
        {
            employeeRepository = new EmployeeRepository();
            var leave = employeeRepository.getleaveDetails(employeeid).Where(l => l.LeaveType == "Sick").Sum(l => l.TotaldaysOnLeaveCurrent);
            return leave;
        }

        public double getavailablePlannedleave(int employeeid)
        {
            employeeRepository = new EmployeeRepository();
            var leaveMaster = getTotalLeaveCount();
           // var leave = leaveMaster.Where(l => l.LEAVE_ID == 302).Select(l => l.LEAVE_TOTALDAYS).FirstOrDefault();
            var joiningDate = employeeRepository.getEmployee(employeeid).JoiningDate;
            var leave = getemployeeEarnedleave(Convert.ToDateTime(joiningDate)).ToString();
            var totalleaves =employeeRepository.getleaveDetails(employeeid).Where(l => l.LeaveType == "Planned").Sum(l => l.TotaldaysOnLeaveCurrent);
            var totalavailable = (double.Parse(leave) - Convert.ToDouble(totalleaves));
            return totalavailable;
        }

        public int getavailableSickleave(int employeeid)
        {
            employeeRepository = new EmployeeRepository();
            var leaveMaster = getTotalLeaveCount();
            var leave = leaveMaster.Where(l => l.LEAVE_ID == 303).Select(l => l.LEAVE_TOTALDAYS).FirstOrDefault();
            var totalleave = employeeRepository.getleaveDetails(employeeid).Where(l => l.LeaveType == "Sick").Sum(l => l.TotaldaysOnLeaveCurrent);
            var totalavailable = Convert.ToInt16(leave - totalleave);
            return totalavailable;
        }
    }

}
