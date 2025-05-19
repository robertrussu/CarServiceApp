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
		public IActionResult Index(string vin)
		{
			if (string.IsNullOrWhiteSpace(vin))
			{
				ViewBag.Error = "Please enter a VIN.";
				return View();
			}

			// Dummy API result (simulate API call)
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
