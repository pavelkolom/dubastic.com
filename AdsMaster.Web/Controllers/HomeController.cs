using Microsoft.AspNetCore.Mvc;

namespace AdsMaster.Mvc.Controllers
{
    public class HomeController : Controller
    {
	    public IActionResult Index()
	    {
			      //return RedirectToAction("Index", "Ads");
            return View();
        }
	}
}
