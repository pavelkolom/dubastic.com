using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdsMaster.Mvc.Areas.Ads.Controllers
{
	[Area("Ads")]
	public class CategoryController : Controller
	{
		public ViewResult Index()
		{
			ViewBag.Title = "Ads Master - Category";
			return View();
		}
	}
}
