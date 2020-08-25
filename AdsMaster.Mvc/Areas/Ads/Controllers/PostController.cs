using AdsMaster.DB.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdsMaster.Mvc.Areas.Ads.Controllers
{
    [Area("Ads")]
    public class PostController : Controller
    {
        private readonly AdsMasterContext _db;
        IWebHostEnvironment _appEnvironment;

        public PostController(AdsMasterContext db, IWebHostEnvironment appEnvironment)
        {
            _db = db;
            _appEnvironment = appEnvironment;
        }

        public ViewResult New()
        {
            ViewBag.Title = "Ads Master - Post new Ad";
            return View();
        }

        public async Task<ViewResult> DetailsAsync(int id)
        {
            ViewBag.Title = "Ads Master - Details";
            var post = await _db.Post.Where(o => o.PostID == id).FirstOrDefaultAsync();
            return View(post);
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
            string address,
            string message,
            IFormFile uploadedFile)
        {
            var forum = new Forum()
            {
                Title = title,
                Description = message,
                CategoryID = 1,
                IsQAForum = false,
                IsVisible = true,
                IsArchived = false,
                SortOrder = 1,
                TopicCount = 1,
                PostCount = 1,
                LastPostName = "",
                UrlName = "",
            };

            if (uploadedFile != null)
            {
                string path = "/Files/" + uploadedFile.FileName;

                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }

                forum.Image = uploadedFile.FileName;
            }

            _db.Forum.Add(forum);

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
