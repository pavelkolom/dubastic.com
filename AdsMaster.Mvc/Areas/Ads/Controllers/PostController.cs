using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdsMaster.Mvc.Areas.Ads.Controllers
{
	[Area("Ads")]
	public class PostController : Controller
	{
		public ViewResult New()
		{
			ViewBag.Title = "Ads Master - Post new Ad";
			return View();
		}
		public ViewResult Details()
		{
			ViewBag.Title = "Ads Master - Details";
			return View();
		}
		public ViewResult PostNotFound()
		{
			ViewBag.Title = "Ads Master - Not Found";
			return View();
		}
	}
}
