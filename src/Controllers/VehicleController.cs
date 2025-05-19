using CarServiceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceApp.Controllers
{
    public class VehiclesController : Controller
    {
        public IActionResult Index()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle { Id = 1, Make = "Toyota", Model = "Corolla", Year = 2020 },
                new Vehicle { Id = 2, Make = "Honda", Model = "Civic", Year = 2019 },
                new Vehicle { Id = 3, Make = "Ford", Model = "Focus", Year = 2021 }
            };

            return View(vehicles);
        }
    }

}
