using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HFProject.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
    }
}
