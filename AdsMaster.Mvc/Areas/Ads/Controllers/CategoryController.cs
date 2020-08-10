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

        public async Task<IActionResult> Index(int category = 0, int page = 1)
        {
            ViewBag.Category = category;
            ViewBag.Page = page;
            ViewBag.Title = "Ads Master - Category";

            int pageSize = 10;

            IQueryable<Post> source = _db.Post.Include(a => a.Topic);
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);

            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Posts = items
            };

            return View(viewModel);
        }
    }
}
