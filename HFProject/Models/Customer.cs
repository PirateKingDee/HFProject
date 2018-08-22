using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HFProject.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
