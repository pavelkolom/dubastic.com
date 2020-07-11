using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdsMaster.Mvc.Areas.Ads.Controllers
{
	[Area("Ads")]
	public class AboutController : Controller
	{
		public ViewResult Index()
		{
			ViewBag.Title = "Ads Master - About Us";
			return View();
		}
		public ViewResult Pricing()
		{
			ViewBag.Title = "Ads Master - Pricing";
			return View();
		}
		public ViewResult FAQ()
		{
			ViewBag.Title = "Ads Master - FAQ";
			return View();
		}
		public ViewResult Contact()
		{
			ViewBag.Title = "Ads Master - FAQ";
			return View();
		}
	}
}
