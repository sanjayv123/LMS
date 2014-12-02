using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Service;
using LMS.Data;



namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            var datacontext = new EmpDetails();
            var emp = new BaseRepository<EmpDetails>(data);
            
            
        }


    }
}
