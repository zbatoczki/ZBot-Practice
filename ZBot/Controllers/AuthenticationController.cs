using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZBot.Services;

namespace ZBot.Controllers
{
    public class AuthenticationController : Controller
    {
        string twitchURL_GET = "https://id.twitch.tv/oauth2/authorize";
        string twitchURL_POST = "https://id.twitch.tv/oauth2/token";

        [Route("/authentication/authorize")]
        public ActionResult Authorize(string code, string scope)
        {           
            if (code == null)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(twitchURL_GET);
                sb.Append("?client_id=");
                sb.Append("wwqvmentego4volic66z9kgiws0u42");
                sb.Append("&redirect_uri=http://localhost:53628/authentication/confirm");
                sb.Append("&response_type=code");
                sb.Append("&scope=user_read channel_editor channel_commercial channel_subscriptions");
                return new RedirectResult(sb.ToString());
            }

            //sb.Append(twitchURL_POST);
            //sb.Append("?client_id=");
            //sb.Append("wwqvmentego4volic66z9kgiws0u42");
            //sb.Append("&client_secret=w1o53ggb19ivh3iacu1mbbce3gcn86");
            //sb.Append("&code=<authorization code received above>");
            //sb.Append(code);
            //sb.Append("&grant_type=authorization_code");            
            //sb.Append("&redirect_uri=http://localhost:53628/authentication/confirm");

            Dictionary<string, string> postParams = new Dictionary<string, string>();
            postParams.Add("client_id", "wwqvmentego4volic66z9kgiws0u42");
            postParams.Add("client_secret", "");
            postParams.Add("code", code);
            postParams.Add("grant_type", "authorization_code");
            postParams.Add("redirect_uri", "http://localhost:53628/authentication/confirm");

            var response = WebRequest.MakeRequest("POST", twitchURL_POST, postParams);

            return View("Dashboard/Index");
        }

        [Route("/authentication/confirm")]
        public ActionResult ConfirmAuth(string code, string scope)
        {
            if(code != null)
            {
                Dictionary<string, string> postParams = new Dictionary<string, string>();
                postParams.Add("client_id", "wwqvmentego4volic66z9kgiws0u42");
                postParams.Add("client_secret", "");
                postParams.Add("code", code);
                postParams.Add("grant_type", "authorization_code");
                postParams.Add("redirect_uri", "http://localhost:53628/authentication/confirm");

                var response = WebRequest.MakeRequest("POST", twitchURL_POST, postParams);
            }
            

            return View("Dashboard/Index");
        }
    }
}