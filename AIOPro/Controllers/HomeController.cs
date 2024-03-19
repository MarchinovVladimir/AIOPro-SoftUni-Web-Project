using AIOPro.Web.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AIOPro.Controllers
{
    public class HomeController : Controller
	{

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			ViewBag.CompanyName = "AIO Company EOOD";
			ViewBag.AppName = "AIOPro";
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
