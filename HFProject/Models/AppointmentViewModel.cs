using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HFProject.Models
{
    public class AppointmentViewModel
    {
        public IEnumerable<Appointment> UpcomingAppointments { get; set; }
        public IEnumerable<Customer> CustomerList { get; set; }

        public IEnumerable<AppointmentCustomer> appointmentCustomer { get; set; }
    }
}
