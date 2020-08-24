using Microsoft.AspNetCore.Authorization;
using PopForums.Models;
using AdsMaster.Mvc.Areas.Ads.Authorization;

namespace AdsMaster.Mvc.Areas.Ads.Extensions
{
    public static class AuthorizationOptionsExtensions
    {
		/// <summary>
		/// Adds authorization options to require certain claims for moderator and admin roles in POP Forums.
		/// </summary>
		/// <param name="options"></param>
	    public static void AddPopForumsPolicies(this AuthorizationOptions options)
		{
			options.AddPolicy(PermanentRoles.Admin, policy => policy.RequireClaim(AdsMasterAuthorizationDefaults.ForumsClaimType, PermanentRoles.Admin));
			options.AddPolicy(PermanentRoles.Moderator, policy => policy.RequireClaim(AdsMasterAuthorizationDefaults.ForumsClaimType, PermanentRoles.Moderator));
		}
    }
}
