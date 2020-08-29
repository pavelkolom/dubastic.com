using AdsMaster.DB.Models;
using AdsMaster.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdsMaster.Mvc.Areas.Ads.Controllers
{
    [Area("Ads")]
    public class CategoryController : Controller
    {
        private readonly AdsMasterContext _db;

        public CategoryController(AdsMasterContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(int category = 0, int page = 1)
        {
            ViewBag.ForumId = category;
            ViewBag.Page = page;
            ViewBag.Title = "Ads Master - Category";

            int pageSize = 10;

            IQueryable<Topic> source = _db.Topic
                .Include(a => a.Forum)
                .Where(a => a.ForumID == category && !a.IsDeleted);

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

        public JsonResult GetSubCategory(int CategoryID)
        {
            List<Forum> sl = new List<Forum>();

            sl = (from su in _db.Forum where su.CategoryID == CategoryID select su).ToList();

            sl.Insert(0, new Forum() { ForumID = 0, Title = "Select" });

            return Json(sl);
        }
    }
}
