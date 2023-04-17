using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Frost_Chembase_BE_APIs_Stock.Filters
{
	public class RequireHttpsAttribute : AuthorizationFilterAttribute
	{
		public override void OnAuthorization(HttpActionContext actionContext)
		{
			if (actionContext.Request.RequestUri.Scheme != Uri.UriSchemeHttps)
			{
				actionContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden)
				{
					ReasonPhrase = "HTTPS Required"
				};
			}
			else
			{
				base.OnAuthorization(actionContext);
			}
		}
	}
}
