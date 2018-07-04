using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitchLib.Api.Models.Helix.Users.GetUsers;
using TwitchLib.Api;
using ZBot.Models;
using Newtonsoft.Json;

namespace ZBot.Services
{
    public class TwitchService : ITwitchService
    {
        private IWebRequest webRequest;

        public TwitchService(IWebRequest webRequest)
        {
            this.webRequest = webRequest;
        }


        public PostResponse GetOAuth(string authCode)
            {
                Dictionary<string, string> postParams = new Dictionary<string, string>();
                postParams.Add("client_id", Startup.Configuration["appSettings:clientID"]);
                postParams.Add("client_secret", Startup.Configuration["appSettings:clientSecret"]);
                postParams.Add("code", authCode);
                postParams.Add("grant_type", "authorization_code");
                postParams.Add("redirect_uri", Startup.Configuration["appRedirectURL"]);

                var response = webRequest.MakeRequest("POST", Startup.Configuration["twitchURL_POST"], postParams);
                return JsonConvert.DeserializeObject<PostResponse>(response);
        }


        public ZBotUser RegisterUser(PostResponse response)
        {
            TwitchAPI api = new TwitchAPI();
            api.Settings.AccessToken = response.access_token;
            api.Settings.ClientId = Startup.Configuration["appSettings:clientID"];

            User[] user = api.Users.helix.GetUsersAsync().Result.Users;

            return new ZBotUser(user[0].Email, user[0].DisplayName);
        }
    }
}
