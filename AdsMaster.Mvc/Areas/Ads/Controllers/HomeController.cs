using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdsMaster.Mvc.Areas.Ads.Controllers
{
	[Area("Ads")]
	public class HomeController : Controller
	{
		public ViewResult Index()
		{
			ViewBag.Title = "Ads Master";
			return View();
		}
		public ViewResult Index1()
		{
			ViewBag.Title = "Ads Master";
			return View();
		}
		public ViewResult Index2()
		{
			ViewBag.Title = "Ads Master";
			return View();
		}
	}
}
