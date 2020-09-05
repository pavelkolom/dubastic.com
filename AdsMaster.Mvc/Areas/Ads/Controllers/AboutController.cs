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
		public ViewResult Contact()
		{
			ViewBag.Title = "Ads Master - Contact";
			return View();
		}
	}
}
