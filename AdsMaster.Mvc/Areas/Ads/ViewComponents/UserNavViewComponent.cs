using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdsMaster.Mvc.Areas.Ads.Models;
using AdsMaster.Mvc.Areas.Ads.Services;
using PopForums.Services;

namespace PopForums.Mvc.Areas.Forums.ViewComponents
{
    public class UserNavViewComponent : ViewComponent
    {
	    private readonly IUserRetrievalShim _userRetrievalShim;
	    private readonly IPrivateMessageService _privateMessageService;

	    public UserNavViewComponent(IUserRetrievalShim userRetrievalShim, IPrivateMessageService privateMessageService)
	    {
		    _userRetrievalShim = userRetrievalShim;
		    _privateMessageService = privateMessageService;
	    }

	    public async Task<IViewComponentResult> InvokeAsync()
	    {
		    var container = new UserNavContainer();
            container.User = _userRetrievalShim.GetUser();
		    if (container.User != null)
		    {
			    var count = await _privateMessageService.GetUnreadCount(container.User);
			    if (count > 0)
				    container.PMCount = $"<span class=\"badge\">{count}</span>";
		    }
		    return View(container);
	    }
    }
}
