using Microsoft.AspNetCore.Mvc;

namespace CarServiceApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
