﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdsMaster.Mvc.Areas.Ads.Authorization;
using AdsMaster.Mvc.Areas.Ads.Extensions;
using PopForums.Services;

namespace AdsMaster.Mvc.Areas.Ads.Controllers
{
	[Area("Ads")]
	[TypeFilter(typeof(AdsMasterPrivateForumsFilter))]
	public class SitemapController : Controller
	{
		private readonly ISitemapService _sitemapService;

		public static string Name = "Sitemap";

		public SitemapController(ISitemapService sitemapService)
		{
			_sitemapService = sitemapService;
		}

		[HttpGet("/Forums/Sitemap.xml")]
		[ResponseCache(Duration = 900)]
		public async Task<IActionResult> Index()
		{
			string SitemapPageLinkGenerator(int page) => this.FullUrlHelper("Page", Name, new { page });
			var sitemapIndex = await _sitemapService.GenerateIndex(SitemapPageLinkGenerator);
			return Content(sitemapIndex, "text/xml");
		}

		[HttpGet("/Forums/Sitemap.{page}.xml")]
		[ResponseCache(Duration = 900)]
		public async Task<IActionResult> Page(int page)
		{
			string TopicLinkGenerator(string id) => this.FullUrlHelper("Topic", ForumController.Name, new { id });
			var sitemap = await _sitemapService.GeneratePage(TopicLinkGenerator, page);
			return Content(sitemap, "text/xml");
		}
	}
}