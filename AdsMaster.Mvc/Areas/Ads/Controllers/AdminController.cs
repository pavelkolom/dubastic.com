using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PopForums.Models;
using AdsMaster.Mvc.Areas.Ads.Authorization;

namespace AdsMaster.Mvc.Areas.Ads.Controllers
{

	[Authorize(Policy = PermanentRoles.Admin, AuthenticationSchemes = AdsMasterAuthorizationDefaults.AuthenticationScheme)]
	[Area("Ads")]
	public class AdminController : Controller
	{
		public static string Name = "Admin";

		public ViewResult App(string vue = "")
		{
			return View();
		}
	}
}
