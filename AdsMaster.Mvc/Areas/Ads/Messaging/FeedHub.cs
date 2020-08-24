﻿using Microsoft.AspNetCore.SignalR;
using PopForums.Services;

namespace AdsMaster.Mvc.Areas.Ads.Messaging
{
	public class FeedHub : Hub
	{
		private readonly ITenantService _tenantService;

		public FeedHub(ITenantService tenantService)
		{
			_tenantService = tenantService;
		}

		public void ListenToAll()
		{
			var tenant = _tenantService.GetTenant();
			Groups.AddToGroupAsync(Context.ConnectionId, $"{tenant}:feed");
		}
	}
}