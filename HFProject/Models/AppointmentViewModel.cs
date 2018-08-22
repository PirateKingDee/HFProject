using System.Collections.Generic;

namespace HFProject.Models
{
    public class AppointmentViewModel
    {
        public ICollection<AppointmentForm> UpcomingAppointments { get; set; }
    }
}
