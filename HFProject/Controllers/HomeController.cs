using HFProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HFProject.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Schedule()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MakeAppointment(AppointmentForm form)
        {
            Customer customer = new Customer();
            customer.FirstName = form.FirstName;
            customer.LastName = form.LastName;
            customer.PhoneNumber = form.PhoneNumber;

            Appointment appointment = new Appointment();
            appointment.AppointmentDate = form.DateTime;
            appointment.Type = form.Type;
            appointment.Note = form.Note;

            customer.Appointments = new System.Collections.ObjectModel.Collection<Appointment>();
            customer.Appointments.Add(appointment);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return RedirectToAction("Confirmation", "Home");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Confirmation()
        {
            ViewData["Message"] = "Your confirmation page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
