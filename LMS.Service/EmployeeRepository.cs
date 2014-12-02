using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Service;
using LMS.Data;

namespace LMS.Service
{
    public class EmployeeRepository:IEmployee
    {

        internal readonly LMSDBEntities _dbcontext = new LMSDBEntities();


        public void InsertIntoEmployee(AllEmployeeDetails Emp)
        {
            _dbcontext.EmpDetails.Add(Emp);
            _dbcontext.SaveChanges();
        }

        public List<AllEmployeeDetails> getEmployeedetails()
        {
            return _dbcontext.EmpDetails.ToList();
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
            throw new NotImplementedException();
        }

        public List<JobDescription> getAlljobDescription()
        {
            throw new NotImplementedException();
        }

        public void EmployeeLogin(string Username, string Password)
        {
            throw new NotImplementedException();
        }

        public void getEmployee(int Id)
        {
            throw new NotImplementedException();
        }

        public void getEmployeeAttendance(int Id)
        {
            throw new NotImplementedException();
        }

        public void getEmployeeLeave(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
