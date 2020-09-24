using AdsMaster.DB.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PopForums.Mvc.Areas.Forums.Services;
using PopForums.Services;
using System.Threading.Tasks;

namespace AdsMaster.Mvc.Areas.Ads.Controllers
{
    [Area("Ads")]
    public class AboutController : Controller
    {
        private readonly AdsMasterContext _db;
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly IForumService _forumService;
        private readonly IUserRetrievalShim _userRetrievalShim;

        public AboutController(
            AdsMasterContext db,
            IWebHostEnvironment appEnvironment,
            IUserRetrievalShim userRetrievalShim,
            IForumService forumService)
        {
            _db = db;
            _appEnvironment = appEnvironment;
            _userRetrievalShim = userRetrievalShim;
            _forumService = forumService;
        }

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

        [HttpPost]
        public async Task<ActionResult> ContactAsync(string Name, string Email, string Subject, string Message)
        {
            ContactMessage contactMessage = new ContactMessage()
            {
                Name = Name,
                Email = Email,
                Subject = Subject,
                Message = Message,
            };

            _db.ContactMessage.Add(contactMessage);

            await _db.SaveChangesAsync();

            return View("MessageSent");
        }
    }
}
