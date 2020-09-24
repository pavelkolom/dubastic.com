using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PopForums.Mvc.Areas.Forums.Authorization;

namespace AdsMaster.Mvc.Areas.Admin.Controllers
{
    [Authorize(Policy = PopForums.Models.PermanentRoles.Admin, AuthenticationSchemes = PopForumsAuthorizationDefaults.AuthenticationScheme)]
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
