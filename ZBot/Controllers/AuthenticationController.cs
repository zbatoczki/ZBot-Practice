using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TwitchLib.Api;
using ZBot.Models;
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

        //[Route("/authentication/confirm")]
        //public IActionResult ConfirmAuth(string code, string scope)
        //{
        //    PostResponse response = new PostResponse();
        //    if(code == null)
        //    {
        //        return BadRequest();
        //    }
        //    var jsonResponse = twitchService.GetOAuth(code);
        //    response = JsonConvert.DeserializeObject<PostResponse>(jsonResponse);

        //    ZBotUser newUser = twitchService.RegisterUser(response);

        //    return RedirectToAction("Index", "Dashboard", newUser);

        //    //return View("/Views/Dashboard/Index.cshtml", newUser);
        //}

    }
}