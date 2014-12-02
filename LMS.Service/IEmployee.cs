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
        

        //insert into employee
        void InsertIntoEmployee(AllEmployeeDetails Emp);

        ////update into employee
        void EmployeeLogin(string Username,string Password);

        void getEmployee(int Id);

        void getEmployeeAttendance(int Id);

        void getEmployeeLeave(int Id);
        
       


        ////delete employee
        //void DeleteEmployee(EmployeeService Emp);
    }
}
