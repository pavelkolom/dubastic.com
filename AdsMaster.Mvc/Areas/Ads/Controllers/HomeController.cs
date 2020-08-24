using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdsMaster.Mvc.Areas.Ads.Authorization;
using AdsMaster.Mvc.Areas.Ads.Extensions;
using AdsMaster.Mvc.Areas.Ads.Services;
using PopForums.Services;

namespace AdsMaster.Mvc.Areas.Ads.Controllers
{
	[Area("Ads")]
	[TypeFilter(typeof(AdsMasterPrivateForumsFilter))]
	public class HomeController : Controller
	{
		public HomeController(IForumService forumService, IUserService userService, IUserSessionService userSessionService, IUserRetrievalShim userRetrievalShim)
		{
			_forumService = forumService;
			_userService = userService;
			_userSessionService = userSessionService;
			_userRetrievalShim = userRetrievalShim;
		}

		public static string Name = "Home";

		private readonly IForumService _forumService;
		private readonly IUserService _userService;
		private readonly IUserSessionService _userSessionService;
		private readonly IUserRetrievalShim _userRetrievalShim;

		public async Task<ViewResult> Index()
		{
			ViewBag.OnlineUsers = await _userService.GetUsersOnline();
			var sessionCount = await _userSessionService.GetTotalSessionCount();
			ViewBag.TotalUsers = sessionCount.ToString("N0");
			ViewBag.TopicCount = _forumService.GetAggregateTopicCount().Result.ToString("N0");
			ViewBag.PostCount = _forumService.GetAggregatePostCount().Result.ToString("N0");
			var registeredUsers = await _userService.GetTotalUsers();
			ViewBag.RegisteredUsers = registeredUsers.ToString("N0");
			var user = _userRetrievalShim.GetUser();
			ViewBag.SitemapUrl = this.FullUrlHelper("Index", SitemapController.Name);
			return View(await _forumService.GetCategorizedForumContainerFilteredForUser(user));
		}
		public async Task<ViewResult> Index1()
		{
			ViewBag.OnlineUsers = await _userService.GetUsersOnline();
			var sessionCount = await _userSessionService.GetTotalSessionCount();
			ViewBag.TotalUsers = sessionCount.ToString("N0");
			ViewBag.TopicCount = _forumService.GetAggregateTopicCount().Result.ToString("N0");
			ViewBag.PostCount = _forumService.GetAggregatePostCount().Result.ToString("N0");
			var registeredUsers = await _userService.GetTotalUsers();
			ViewBag.RegisteredUsers = registeredUsers.ToString("N0");
			var user = _userRetrievalShim.GetUser();
			ViewBag.SitemapUrl = this.FullUrlHelper("Index", SitemapController.Name);
			return View(await _forumService.GetCategorizedForumContainerFilteredForUser(user));
		}
		public async Task<ViewResult> Index2()
		{
			ViewBag.OnlineUsers = await _userService.GetUsersOnline();
			var sessionCount = await _userSessionService.GetTotalSessionCount();
			ViewBag.TotalUsers = sessionCount.ToString("N0");
			ViewBag.TopicCount = _forumService.GetAggregateTopicCount().Result.ToString("N0");
			ViewBag.PostCount = _forumService.GetAggregatePostCount().Result.ToString("N0");
			var registeredUsers = await _userService.GetTotalUsers();
			ViewBag.RegisteredUsers = registeredUsers.ToString("N0");
			var user = _userRetrievalShim.GetUser();
			ViewBag.SitemapUrl = this.FullUrlHelper("Index", SitemapController.Name);
			return View(await _forumService.GetCategorizedForumContainerFilteredForUser(user));
		}

		public async Task<ViewResult> Index3()
		{
			ViewBag.OnlineUsers = await _userService.GetUsersOnline();
			var sessionCount = await _userSessionService.GetTotalSessionCount();
			ViewBag.TotalUsers = sessionCount.ToString("N0");
			ViewBag.TopicCount = _forumService.GetAggregateTopicCount().Result.ToString("N0");
			ViewBag.PostCount = _forumService.GetAggregatePostCount().Result.ToString("N0");
			var registeredUsers = await _userService.GetTotalUsers();
			ViewBag.RegisteredUsers = registeredUsers.ToString("N0");
			var user = _userRetrievalShim.GetUser();
			ViewBag.SitemapUrl = this.FullUrlHelper("Index", SitemapController.Name);
			return View(await _forumService.GetCategorizedForumContainerFilteredForUser(user));
		}


	}
}
