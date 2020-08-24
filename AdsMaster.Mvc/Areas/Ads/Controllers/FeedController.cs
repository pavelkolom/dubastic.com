using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PopForums.Feeds;
using AdsMaster.Mvc.Areas.Ads.Authorization;

namespace AdsMaster.Mvc.Areas.Ads.Controllers
{
	[Area("Ads")]
	[TypeFilter(typeof(AdsMasterPrivateForumsFilter))]
	public class FeedController : Controller
    {
	    private readonly IFeedService _feedService;

	    public static string Name = "Feed";

	    public FeedController(IFeedService feedService)
	    {
		    _feedService = feedService;
		}

		public async Task<ViewResult> Index()
		{
			var feed = await _feedService.GetFeed();
			return View(feed);
		}
	}
}
