using AdsMaster.DB.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PopForums.Extensions;
using PopForums.Mvc.Areas.Forums.Services;
using PopForums.Services;
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
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly IForumService _forumService;
        private readonly IUserRetrievalShim _userRetrievalShim;

        public PostController(
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

        public async Task<IActionResult> New()
        {
            ViewBag.Title = "Ads Master - Post new Ad";
            var user = _userRetrievalShim.GetUser();

            if (user == null)
                return RedirectToAction("Login", "Account", new { r = (Request.IsHttps ? "https://" : "http://") + Request.Host + Request.Path });

            return View(await _forumService.GetCategorizedForumContainerFilteredForUser(user));
        }

        public async Task<ViewResult> DetailsAsync(int id)
        {
            ViewBag.Title = "Ads Master - Details";

            var item = await _db.Topic
                .Where(o => o.TopicID == id)
                .FirstOrDefaultAsync();

            return View(item);
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
            string forumId,
            IFormFile uploadedFile)
        {
            var user = _userRetrievalShim.GetUser();

            if (user == null)
                return RedirectToAction("Login", "Account", new { r = (Request.IsHttps ? "https://" : "http://") + Request.Host + Request.Path });

            var urlName = title.ToUniqueUrlName(new System.Collections.Generic.List<string>() { "" });

            var topicItem = new Topic()
            {
                ForumID = int.Parse(forumId),
                Title = title,
                UrlName = urlName,
                Price = decimal.Parse(price),
                AnswerPostID = 0,
                Description = message,
                IsModerated = false,
                StartedByUserID = user.UserID,
                StartedByName = user.Name,
                LastPostUserID = user.UserID,
                LastPostName = user.Name,
                LastPostTime = DateTime.Now,
            };

            if (uploadedFile != null)
            {
                string path = "/Files/" + uploadedFile.FileName;

                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }

                topicItem.Image = uploadedFile.FileName;
            }

            _db.Topic.Add(topicItem);

            await _db.SaveChangesAsync();

            var postItem = new Post()
            {
                TopicID = topicItem.TopicID,
                FullText = message,
                Title = message,
                UserID = user.UserID,
                Name = user.Name,
                LastEditName = user.Name,
                PostTime = DateTime.Now,
                IP = HttpContext.Connection.RemoteIpAddress.ToString(),
            };

            _db.Post.Add(postItem);

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
