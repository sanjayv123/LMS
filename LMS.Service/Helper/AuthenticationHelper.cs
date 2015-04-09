using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Service.Helper
{
   public static class AuthenticationHelper
    {
      
       public static string username
       {
           get
           {
               return "bharati";//WindowsIdentity.GetCurrent().Name;
               
           }
           
       }

       public static int role
       {
           get
           {
               EmployeeRepository employeeRepository = new EmployeeRepository();
               var employeeId = employeeRepository.getEmployeeFromUserName(username);
              // var employeeId = employeeRepository.getEmployeedetails();
               return employeeId.Select(e => e.RoleId).FirstOrDefault();
              // return 2;
           }
       }
    }
}
