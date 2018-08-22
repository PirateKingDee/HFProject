using HFProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using System.Linq;

namespace HFProject.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppointmentController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult ViewAppointment()
        {
            var appointments = _context.Appointment.ToList();
            var appointmensViewModel = new AppointmentViewModel();
            appointmensViewModel.UpcomingAppointments = new Collection<AppointmentForm>();


            foreach (var appointment in appointments){

                var customer = _context.Customers.Single(c => c.CustomerId == appointment.CustomerId);

                var appointmentForm = new AppointmentForm
                {
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    PhoneNumber = customer.PhoneNumber,
                    Date = appointment.AppointmentDate.Month.ToString() + "/" + appointment.AppointmentDate.Day.ToString() + "/" + appointment.AppointmentDate.Year.ToString(),
                    Time = appointment.AppointmentDate.TimeOfDay.ToString(),
                    Type = appointment.Type,
                    Note = appointment.Note
                };

                appointmensViewModel.UpcomingAppointments.Add(appointmentForm);
            }

            //var viewModel = new AppointmentViewModel()
           // {
           //     UpcomingAppointments = appointment
           // };
            return View("Appointment", appointmensViewModel);
        }

    }
}