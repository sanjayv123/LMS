using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LMS.Service;
using LMS.Data;
using LMS.Service;
using LMS.Service.Helper;

namespace LMS.Service
{
    public class EmployeeRepository : IEmployee
    {

        internal readonly LMSDBEntities _dbcontext = new LMSDBEntities();


        public void InsertIntoEmployee(AllEmployeeDetails Emp)
        {
            _dbcontext.AllEmployeeDetails.Add(Emp);
            _dbcontext.SaveChanges();

        }

        public List<AllEmployeeDetails> getEmployeedetails()
        {
            return _dbcontext.AllEmployeeDetails.ToList();
        }


        public List<Leave> getLeaveTypes()
        {
            return _dbcontext.Leaves.ToList();
        }

        public List<Attendance> getEmployeesAttendance(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Department> getAllDepartment()
        {
            return _dbcontext.Departments.ToList();
        }

        public List<JobDescription> getAlljobDescription()
        {
            return _dbcontext.JobDescriptions.ToList();
        }

        public void EmployeeLogin(string Username, string Password)
        {
            throw new NotImplementedException();
        }

        public AllEmployeeDetails getEmployee(int Id)
        {
            return _dbcontext.AllEmployeeDetails.Where(e => e.EmployeeID == Id).FirstOrDefault();

        }

        public List<AllEmployeeDetails> getEmployeeFromUserName(string userName)
        {
            return _dbcontext.AllEmployeeDetails.Where(e => e.UserName == userName).ToList();

        }
        public void updateEmployee(AllEmployeeDetails Emp)
        {

            var emp = _dbcontext.AllEmployeeDetails.Where(e => e.EmployeeID == Emp.EmployeeID).FirstOrDefault();
            emp.FirstName = Emp.FirstName;
            emp.FullName = Emp.FullName;
            emp.Address = Emp.Address;
            emp.Email = Emp.Email;
            emp.PersonalEmailId = Emp.PersonalEmailId;
            emp.Mobile = Convert.ToInt32(Emp.Mobile);
            emp.PhoneNo = Convert.ToInt32(Emp.PhoneNo);
            emp.EmployeeCode = Convert.ToInt32(Emp.EmployeeCode);
            emp.DOB = Emp.DOB;
            emp.JoiningDate = Emp.JoiningDate;
            //emp.EMP_GENDER = Emp.EMP_GENDER;
            // var entry = _dbcontext.Entry(Emp);
            //entry.CurrentValues.SetValues(Emp);
            _dbcontext.SaveChanges();

        }
        public AllEmployeeDetails getNewemployee(int Id)
        {
            return _dbcontext.AllEmployeeDetails.Where(e => e.EmployeeID == Id).FirstOrDefault();

        }



        public void getEmployeeAttendance(int Id)
        {
            throw new NotImplementedException();
        }

        public void getEmployeeLeave(int Id)
        {
            throw new NotImplementedException();
        }
        public List<Leave> getEmployeeleave(int Id)
        {
            throw new NotImplementedException();
        }

        public void InsertIntoEmployeeLeave(EmployeeLeave Empleave)
        {
            _dbcontext.EmployeeLeaves.Add(Empleave);
            _dbcontext.SaveChanges();
        }

        public List<EmployeeLeave> getLeaveRequest(int employeeid)
        {
            return _dbcontext.EmployeeLeaves.Where(e => e.EmployeeId == employeeid).ToList();
        }

        public IEnumerable<LeaveHelper> getleaveDetails(int employeeid)
        {
            var query = from l in _dbcontext.EmployeeLeaves.AsEnumerable()
                        join
                            c in _dbcontext.Leaves.AsEnumerable() on l.LeaveId equals c.LEAVE_ID
                        where l.EmployeeId == employeeid
                        select new LeaveHelper()
                        {
                            LeaveId = l.EmployeeleaveID,
                            LeaveType = c.LEAVE_TYPE,
                            LeaveFromDateTime = l.LeaveFromdate,
                            LeaveToDateTime = l.LeaveToDate,
                            JoiningDateTime = l.ReJoiningdate,
                            LeaveStatus = l.LeaveStatus,
                            WeekendOrHolidayInLeave = (int)l.WeekendORHolidaysInLeave,
                            LeaveApprovalStatus = l.LeaveApprovalStatus == true ? "Approved" : "Pending"

                        };
            return query;
        }

        public List<string> getCalendar()
        {
            return _dbcontext.Calendars.Select(c => c.Date).ToList();

        }

        public IEnumerable<LeaveHelper> getleaveDetailsForAllEmployee()
        {
            var query = from l in _dbcontext.EmployeeLeaves.AsEnumerable()
                        join
                            c in _dbcontext.Leaves.AsEnumerable() on l.LeaveId equals c.LEAVE_ID
                        join emp in _dbcontext.AllEmployeeDetails.AsEnumerable() on l.LeaveApprovedBy equals emp.EmployeeID
                        join empdetail in _dbcontext.AllEmployeeDetails.AsEnumerable() on l.EmployeeId equals empdetail.EmployeeID
                        join dept in _dbcontext.Departments.AsEnumerable() on l.DepartmentId equals dept.DEP_ID
                        join JobD in _dbcontext.JobDescriptions.AsEnumerable() on l.JobId equals JobD.JOB_ID
                        select new LeaveHelper()
                        {
                            EmployeeleaveId = l.EmployeeleaveID,
                            EmployeeId = l.EmployeeId,
                            EmployeeFullName = empdetail.FullName,
                            DepartmentName = dept.DEP_NAME,
                            JobName = JobD.JOB_ROLE,
                            LeaveId = l.LeaveId,
                            // LeaveRemainingdays=(int) l.RemainingDays,
                            LeaveStatus = l.LeaveStatus,
                            LeaveReason = l.LeaveReason,
                            LeaveType = c.LEAVE_TYPE,
                            LeaveApprovedBy = emp.FullName,
                            LeaveFromDateTime = l.LeaveFromdate,
                            LeaveToDateTime = l.LeaveToDate,
                            JoiningDateTime = l.ReJoiningdate,
                            WeekendOrHolidayInLeave = (int)l.WeekendORHolidaysInLeave,
                            TotaldaysOnLeaveCurrent = (int)l.TotaldaysOnLeaveCurrent,
                            TotalLeaveTakenInYear = (int)l.TotalLeaveTakenInYear

                        };

            return query;

        }

        public IEnumerable<LeaveHelper> getleaveDetailsForApproval(int leaveApprovalId)
        {
            var query = from l in _dbcontext.EmployeeLeaves.AsEnumerable()
                        join
                            c in _dbcontext.Leaves.AsEnumerable() on l.LeaveId equals c.LEAVE_ID
                        join emp in _dbcontext.AllEmployeeDetails.AsEnumerable() on l.LeaveApprovedBy equals emp.EmployeeID
                        join empdetail in _dbcontext.AllEmployeeDetails.AsEnumerable() on l.EmployeeId equals empdetail.EmployeeID
                        join dept in _dbcontext.Departments.AsEnumerable() on l.DepartmentId equals dept.DEP_ID
                        join JobD in _dbcontext.JobDescriptions.AsEnumerable() on l.JobId equals JobD.JOB_ID
                        where (l.LeaveApprovedBy == leaveApprovalId)
                        select new LeaveHelper()
                        {
                            EmployeeleaveId = l.EmployeeleaveID,
                            EmployeeId = l.EmployeeId,
                            EmployeeFullName = empdetail.FullName,
                            DepartmentName = dept.DEP_NAME,
                            JobName = JobD.JOB_ROLE,
                            LeaveId = l.LeaveId,
                            LeaveRemainingdays = (int)l.RemainingDays,
                            LeaveStatus = l.LeaveStatus,
                            LeaveReason = l.LeaveReason,
                            LeaveType = c.LEAVE_TYPE,
                            LeaveApprovalStatus = l.LeaveApprovalStatus == true ? "Approve" : "Rejected",
                            LeaveApprovedBy = emp.FullName,
                            LeaveFromDateTime = l.LeaveFromdate,
                            LeaveToDateTime = l.LeaveToDate,
                            JoiningDateTime = l.ReJoiningdate,
                            TotaldaysOnLeaveCurrent = (int)l.TotaldaysOnLeaveCurrent,
                            TotalLeaveTakenInYear = (int)l.TotalLeaveTakenInYear

                        };
            return query;

        }


        public void updateleaveApprovalstatus(int employeeLeaveId, bool IsApprove)
        {
            var employeeleaves =
                _dbcontext.EmployeeLeaves.Where(e => e.EmployeeleaveID == employeeLeaveId).FirstOrDefault();

            employeeleaves.LeaveApprovalStatus = IsApprove;
            _dbcontext.SaveChanges();
        }


        public EmployeeLeave getLeave(int Id)
        {
            return _dbcontext.EmployeeLeaves.Where(e => e.LeaveId == Id).FirstOrDefault();

        }

        public User GetUser(string username)
        {
            return _dbcontext.Users.Where(u => u.Username == username).FirstOrDefault();

        }

        public Role GetRole(int roleId)
        {
            return _dbcontext.Roles.Where(r => r.RoleId == roleId).FirstOrDefault();
        }



        public List<AllEmployeeDetails> GetEmployeeDetailFromFullName(string fullname)
        {
            return _dbcontext.AllEmployeeDetails.Where(e => e.FullName == fullname).ToList();
        }

        public void deleteEmployeeLeave(int employeeleaveId)
        {
            var isLeave = _dbcontext.EmployeeLeaves.Where(l => l.EmployeeleaveID == employeeleaveId).FirstOrDefault();
            if (isLeave != null)
            {
                _dbcontext.Entry(isLeave).State = System.Data.Entity.EntityState.Deleted;
                _dbcontext.SaveChanges();
            }
        }

        public List<AllEmployeeDetails> getmanager()
        {
            return _dbcontext.AllEmployeeDetails.Where(a => a.RoleId != 1).ToList();


        }

        public string getThaughts()
        {
            return _dbcontext.Thaughts.Where(e => e.ThaughtDate == DateTime.Today.Day.ToString())
                     .Select(e => e.Thaughts)
                     .FirstOrDefault();
        }

        public void InsertIntoEvents(Event events)
        {
            _dbcontext.Events.Add(events);
            _dbcontext.SaveChanges();
        }

        public string getEvents()
        {
            return _dbcontext.Events.Select(e => e.EventDescription).FirstOrDefault();
        }

    }
}
