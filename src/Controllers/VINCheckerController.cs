using Microsoft.AspNetCore.Mvc;

namespace CarServiceApp.Controllers
{
	public class VINCheckerController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
        [HttpPost]
        public IActionResult Index(string vin)
        {
            if (string.IsNullOrWhiteSpace(vin))
            {
                ViewBag.Error = "Please enter a VIN.";
                return View();
            }

            if (vin.Length != 17)
            {
                ViewBag.Error = "VIN must be exactly 17 characters.";
                return View();
            }

            // Dummy or real API call below
            var vehicleInfo = new
            {
                VIN = vin,
                Make = "Toyota",
                Model = "Supra",
                Year = "1999",
                Engine = "3.0L I6 Turbo"
            };

            return View("Result", vehicleInfo);
        }

    }
}
