using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdsMaster.Mvc.Areas.Ads.Controllers
{
	[Area("Ads")]
	public class AccountController : Controller
	{
		public ViewResult Index()
		{
			ViewBag.Title = "Ads Master - My Account";
			return View();
		}
		public ViewResult MyAds()
		{
			ViewBag.Title = "Ads Master - My Ads";
			return View();
		}
		public ViewResult Favourite()
		{
			ViewBag.Title = "Ads Master - Favourite Ads";
			return View();
		}
		public ViewResult ForgotPassword()
		{
			ViewBag.Title = "Ads Master - Forgot Password";
			return View();
		}
		public ViewResult Archive()
		{
			ViewBag.Title = "Ads Master - Archieved Ads";
			return View();
		}
		public ViewResult Login()
		{
			ViewBag.Title = "Ads Master - Login";
			return View();
		}
		public ViewResult Signup()
		{
			ViewBag.Title = "Ads Master - Signup";
			return View();
		}
		public ViewResult CloseAccount()
		{
			ViewBag.Title = "Ads Master - Close Account";
			return View();
		}
		public ViewResult SavedSearch()
		{
			ViewBag.Title = "Ads Master - Saved Search";
			return View();
		}
		public ViewResult PendingApproval()
		{
			ViewBag.Title = "Ads Master - Pending Approval";
			return View();
		}
	}
}
