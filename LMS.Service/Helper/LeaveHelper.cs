using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Service.Helper
{
    public class LeaveHelper
    {
        public int EmployeeleaveId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFullName { get; set; }
        public string DepartmentName { get; set; }
        public string JobName { get; set; }
        public int LeaveId { get; set; }
        public int LeaveRemainingdays { get; set; }
        public bool IsLeaveApprovalStatus { get; set; }
        public string LeaveApprovalStatus { get; set; }
        public string LeaveStatus { get; set; } 
        public string LeaveType { get; set; }
        public string LeaveReason { get; set; }
        public string LeaveApprovedBy { get; set; }     
        public DateTime? LeaveFromDateTime { get; set; }
        public DateTime? LeaveTodatDateTime { get; set; }
        public DateTime? JoiningDateTime { get; set; }
        public int WeekendOrHolidayInLeave { get; set; }
        public int TotaldaysOnLeaveCurrent { get; set; }
        public int TotalLeaveTakenInYear { get; set; }
    }
}