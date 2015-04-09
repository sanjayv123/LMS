using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Data;

namespace LMS.Service
{
   
   public interface IEmployee
    {

        //select from employee
        List<AllEmployeeDetails> getEmployeedetails();
        List<Leave> getEmployeeleave(int Id);
        List<Attendance> getEmployeesAttendance(int Id);
        List<Department> getAllDepartment();
        List<JobDescription> getAlljobDescription();
        List<EmployeeLeave> getLeaveRequest(int employeeId);
  
        //insert into employee
        void InsertIntoEmployee(AllEmployeeDetails Emp);
        void InsertIntoEmployeeLeave(EmployeeLeave Empleave);

        ////update into employee
        void EmployeeLogin(string Username,string Password);

        AllEmployeeDetails getEmployee(int Id);

        void getEmployeeAttendance(int Id);

        void getEmployeeLeave(int Id);

        void updateEmployee(AllEmployeeDetails Emp);
        AllEmployeeDetails getNewemployee(int Id);

        EmployeeLeave getLeave(int Id);

        ////delete employee
        //void DeleteEmployee(EmployeeService Emp);
    }
}
