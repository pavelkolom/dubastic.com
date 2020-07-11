using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdsMaster.Mvc.Areas.Ads.Controllers
{
	[Area("Ads")]
	public class BlogController : Controller
	{
		public IActionResult Full()
		{
			ViewBag.Title = "Ads Master - About Us";
			return View();
		}
		public IActionResult Left()
		{
			ViewBag.Title = "Ads Master - Left";
			return View();
		}
		public IActionResult Right()
		{
			ViewBag.Title = "Ads Master - Right";
			return View();
		}
		public IActionResult Details()
		{
			ViewBag.Title = "Ads Master - Details";
			return View();
		}
	}
}
