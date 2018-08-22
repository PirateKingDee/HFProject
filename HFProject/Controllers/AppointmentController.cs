using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HFProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HFProject.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppointmentController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult ViewAppointment()
        {
            var appointment = _context.Appointment.Include(a => a.Customer).ToList();
            

            var viewModel = new AppointmentViewModel()
            {
                
                UpcomingAppointments = appointment
            };
            return View("Appointment", viewModel);
        }
    }
}