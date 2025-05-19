using CarServiceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceApp.Controllers
{
    public class MyAppointmentsController : Controller
    {
        public IActionResult Index()
        {
            var myRequests = new List<ServiceRequest>
            {
                new ServiceRequest { FullName = "You (Fake User)", Email = "you@example.com", VehicleModel = "Toyota Supra", ProblemDescription = "Brake check" }
            };

            return View(myRequests);
        }

    }
}