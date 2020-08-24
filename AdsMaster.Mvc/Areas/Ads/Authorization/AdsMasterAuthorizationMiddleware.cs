using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using PopForums.Services;

namespace AdsMaster.Mvc.Areas.Ads.Authorization
{
	public class AdsMasterAuthorizationMiddleware
	{
		private readonly RequestDelegate _next;

		public AdsMasterAuthorizationMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public Task InvokeAsync(HttpContext context, IUserService userService, IProfileService profileService, ISetupService setupService)
		{
			if (!setupService.IsRuntimeConnectionAndSetupGood())
				return _next.Invoke(context);
			var authResult = context.AuthenticateAsync(AdsMasterAuthorizationDefaults.AuthenticationScheme).Result;
			var identity = authResult?.Principal?.Identity as ClaimsIdentity;
			if (identity != null)
			{
				var user = userService.GetUserByName(identity.Name).Result;
				if (user != null)
				{
					foreach (var role in user.Roles)
						identity.AddClaim(new Claim(AdsMasterAuthorizationDefaults.ForumsClaimType, role));
					context.Items["PopForumsUser"] = user;
					var profile = profileService.GetProfile(user).Result;
					context.Items["PopForumsProfile"] = profile;
					context.User = new ClaimsPrincipal(identity);
				}
			}
			return _next.Invoke(context);
		}
	}
}