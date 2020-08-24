using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PopForums.Configuration;
using AdsMaster.Mvc.Areas.Ads.Controllers;
using PopForums.Services;

namespace AdsMaster.Mvc.Areas.Ads.Authorization
{
	public class AdsMasterPrivateForumsFilter : IActionFilter
	{
		private readonly IUserRetrievalShim _userRetrievalShim;
		private readonly ISettingsManager _settingsManager;

		public AdsMasterPrivateForumsFilter(IUserRetrievalShim userRetrievalShim, ISettingsManager settingsManager)
		{
			_userRetrievalShim = userRetrievalShim;
			_settingsManager = settingsManager;
		}

		public void OnActionExecuting(ActionExecutingContext context)
		{
			if (!_settingsManager.Current.IsPrivateForumInstance)
				return;
			if (_userRetrievalShim.GetUser() == null)
				context.Result = new RedirectToActionResult("Login", AccountController.Name, null);
		}

		public void OnActionExecuted(ActionExecutedContext context)
		{
		}
	}
}