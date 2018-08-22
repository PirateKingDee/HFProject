using System;

namespace HFProject.Models
{
    public class AppointmentForm
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public DateTime DateTime
        {
            get
            {
                return DateTime.Parse(string.Format("{0} {1}", Date, Time));
            }
        }
        public string Type { get; set; }
        public string Note { get; set; }
    }
}
