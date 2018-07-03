using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using TwitchLib.Client;
using TwitchLib.Client.Enums;
using TwitchLib.Client.Events;
using TwitchLib.Client.Extensions;
using TwitchLib.Client.Models;

namespace ZBot.Services
{
    public class TwitchAPI
    {
        string username = "";
        string password = "";

        string channelName = "";

        string clientID = "wwqvmentego4volic66z9kgiws0u42";
        string clientSecret = "";

        TwitchClient client;

        public TwitchAPI()
        {

        }

        public void ReturnURL()
        {
            StringBuilder sb = new StringBuilder("https://id.twitch.tv/oauth2/authorize?client_id=");
            sb.Append(clientID);
            sb.Append("&redirecturi=");
            sb.Append("http://localhost:53628");
            sb.Append("&response=code");
            sb.Append("&scope=user:edit user:read:email channel_editor chat_login");
        }
    }
}
