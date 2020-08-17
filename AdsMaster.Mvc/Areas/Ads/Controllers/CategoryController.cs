using AdsMaster.DB.Models;
using AdsMaster.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IActionResult> Index(int id = 0, int page = 1)
        {
            ViewBag.Category = id;
            ViewBag.Page = page;
            ViewBag.Title = "Ads Master - Category";

            int pageSize = 10;

            IQueryable<Forum> source = _db.Forum
                .Include(a => a.Category)
                .Where(a => a.CategoryID == id);

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
    }
}
