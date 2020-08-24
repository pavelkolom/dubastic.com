using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using AdsMaster.Mvc.Areas.Ads.Authorization;
using AdsMaster.Mvc.Areas.Ads.Messaging;

namespace AdsMaster.Mvc.Areas.Ads.Extensions
{
	public static class ApplicationBuilders
	{
		/// <summary>
		/// Enables the POP Forums middleware to identify PF users.
		/// </summary>
		public static IApplicationBuilder UsePopForumsAuth(this IApplicationBuilder app)
		{
			app.UseMiddleware<AdsMasterAuthorizationMiddleware>();
			return app;
		}

		/// <summary>
		/// Enables the localization (languages) for POP Forums. Call this before UseMvc.
		/// </summary>
		public static IApplicationBuilder UsePopForumsCultures(this IApplicationBuilder app)
		{
			var supportedCultures = new List<CultureInfo> { new CultureInfo("en"), new CultureInfo("de"), new CultureInfo("es"), new CultureInfo("nl"), new CultureInfo("uk"), new CultureInfo("zh-TW") };
			app.UseRequestLocalization(new RequestLocalizationOptions
			{
				DefaultRequestCulture = new RequestCulture("en", "en"),
				SupportedCultures = supportedCultures,
				SupportedUICultures = supportedCultures
			});
			return app;
		}
	}
}