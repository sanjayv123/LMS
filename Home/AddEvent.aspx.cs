using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using LMS.Service;
using  LMS.Data;
namespace Home
{
    public partial class AddEvent : System.Web.UI.Page
    {
        private EmployeeRepository employeeRepository;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaveEvents(object sender, EventArgs e)
        {
            Event _event = new Event
            {
                EventDescription = txtboxeventadd.Text,
                EventName = "Monthly"
            };
            employeeRepository = new EmployeeRepository();
            employeeRepository.InsertIntoEvents(_event);


        }
    }
}