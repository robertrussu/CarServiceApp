using CarServiceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceApp.Controllers
{
    public class ServiceController : Controller
    {
        [HttpGet]
        public IActionResult Schedule()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Schedule(ServiceRequest request)
        {
            if (ModelState.IsValid)
            {
                // For now just return a "Thank You" page or back to home
                return RedirectToAction("ThankYou");
            }

            return View(request);
        }

        public IActionResult ThankYou()
        {
            return View();
        }
    }

}
