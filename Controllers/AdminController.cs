using CarServiceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ServiceRequests()
        {
            var requests = new List<ServiceRequest>
    {
        new ServiceRequest { FullName = "John Doe", Email = "john@example.com", VehicleModel = "Mazda MX-5", ProblemDescription = "Oil change" },
        new ServiceRequest { FullName = "Jane Smith", Email = "jane@example.com", VehicleModel = "BMW M3", ProblemDescription = "Check engine light" }
    };

            return View(requests);
        }

    }
}