using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ZBot.Models;
using ZBot.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZBot.Controllers
{
    public class DashboardController : Controller
    {

        IWebRequest webRequest;
        ITwitchService twitchService;
        IZBotService zbotService;

        public DashboardController(IWebRequest webRequest, ITwitchService twitchService, IZBotService zbotService)
        {
            this.webRequest = webRequest;
            this.twitchService = twitchService;
            this.zbotService = zbotService;
        }

        public IActionResult Index(string code, string scope)
        {
            if (code == null)
            {
                return BadRequest();
            }
            var jsonResponse = twitchService.GetOAuth(code);

            ZBotUser newUser = twitchService.RegisterUser(jsonResponse);

            zbotService.AddUser(newUser);

            return View(newUser);
        }
    }
}
