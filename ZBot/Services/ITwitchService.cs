using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZBot.Models;

namespace ZBot.Services
{
    public interface ITwitchService
    {
        ZBotUser RegisterUser(PostResponse response);
        PostResponse GetOAuth(string code);
    }
}
