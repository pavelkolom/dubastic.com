using Microsoft.AspNetCore.Mvc;

namespace PopForums.Mvc.Controllers
{
    public class HomeController : Controller
    {
	    public IActionResult Index()
	    {
			return RedirectToAction("Index", "Ads");
            //return View();
        }
	}
}
