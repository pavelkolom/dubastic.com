using AdsMaster.DB.Models;
using AdsMaster.Mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PopForums.Mvc.Areas.Forums.Authorization;
using PopForums.Mvc.Areas.Forums.Services;
using PopForums.Services;
using System.Linq;
using System.Threading.Tasks;

namespace AdsMaster.Mvc.Areas.Admin.Controllers
{
    [Authorize(Policy = PopForums.Models.PermanentRoles.Admin, AuthenticationSchemes = PopForumsAuthorizationDefaults.AuthenticationScheme)]
    [Area("Admin")]
    public class ModerateController : Controller
    {
        private readonly AdsMasterContext _db;

        public ModerateController(ITopicService topicService, AdsMasterContext db, IUserRetrievalShim userRetrievalShim)
        {
            _db = db;
            _topicService = topicService;
            _userRetrievalShim = userRetrievalShim;
        }

        private readonly ITopicService _topicService;
        private readonly IUserRetrievalShim _userRetrievalShim;

        public async Task<IActionResult> Index(string q, int page = 1)
        {
            ViewBag.Page = page;
            ViewBag.Title = "Ads Master - items to moderate";

            int pageSize = 10;

            IQueryable<Topic> source = _db.Topic
                .Include(a => a.Forum)
                .Where(a => !a.IsDeleted && !a.IsModerated);

            if (!string.IsNullOrEmpty(q))
                source = _db.Topic
                    .Include(a => a.Forum)
                    .Where(a => (a.Title.Contains(q) || a.Description.Contains(q)) && !a.IsDeleted && a.IsModerated);

            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);

            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Items = items
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<RedirectToActionResult> ToggleIsModerated(int id)
        {
            var topic = await _db.Topic.Where(o => o.TopicID == id).FirstOrDefaultAsync();
            topic.IsModerated = !topic.IsModerated;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index", "Moderate");
        }

    }
}
