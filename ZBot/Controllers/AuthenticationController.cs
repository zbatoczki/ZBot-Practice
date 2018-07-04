using System.Text;
using Microsoft.AspNetCore.Mvc;
using ZBot.Services;

namespace ZBot.Controllers
{
    public class AuthenticationController : Controller
    {

        IWebRequest webRequest;
        ITwitchService twitchService;

        public AuthenticationController(IWebRequest webRequest, ITwitchService twitchService)
        {
            this.webRequest = webRequest;
            this.twitchService = twitchService;
        }

        [Route("/authentication/authorize")]
        public ActionResult Authorize()
        {           
                StringBuilder sb = new StringBuilder();
                sb.Append(Startup.Configuration["twitchURL_GET"]);
                sb.Append("?client_id=");
                sb.Append(Startup.Configuration["appSettings:clientID"]);
                sb.Append("&redirect_uri=");
                sb.Append(Startup.Configuration["appRedirectURL"]);
                sb.Append("&response_type=code");
                sb.Append("&scope=user:read:email");
                return new RedirectResult(sb.ToString());            
        }
    }
}