using System;
using System.Threading.Tasks;
using AdsMaster.DB.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdsMaster.Mvc.Areas.Ads.Controllers
{
    [Area("Ads")]
    public class PostController : Controller
    {
        private readonly AdsMasterContext _db;

        public PostController(AdsMasterContext db)
        {
            _db = db;
        }

        public ViewResult New()
        {
            ViewBag.Title = "Ads Master - Post new Ad";
            return View();
        }
        public ViewResult Details()
        {
            ViewBag.Title = "Ads Master - Details";
            return View();
        }
        public ViewResult PostNotFound()
        {
            ViewBag.Title = "Ads Master - Not Found";
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> NewAsync(
            string title,
            string price,
            string file,
            string usertype,
            string firstname,
            string lastname,
            string phone,
            string address)
        {
            var post = new Post()
            {
                Title = title,
                TopicID = 10,
                Votes = 0,
                ParentPostID = 1,
                IsFirstInTopic = true,
                ShowSig = true,
                UserID = 1,
                Name = "",
                PostTime = DateTime.Now,
                IsEdited = false,
                IsDeleted = false,
            };

            _db.Post.Add(post);

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                LogError(ex);
                return View("ErrorSave");
            }

            return View("SaveDone");
        }

        private void LogError(Exception ex)
        {
        }
    }
}
