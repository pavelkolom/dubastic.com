using Microsoft.AspNetCore.Mvc;

namespace AdsMaster.Mvc.Areas.Ads.Controllers
{
    [Area("Ads")]
    public class PageController : Controller
    {
        public IActionResult Faq()
        {
            ViewBag.Title = "Ads Master - FAQ";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Title = "Ads Master - Privacy Policy";
            return View();
        }

        public IActionResult Terms()
        {
            ViewBag.Title = "Ads Master - Terms & Conditions";
            return View();
        }
    }
}
