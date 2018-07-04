using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZBot.Models;

namespace ZBot.Services
{
    public interface IZBotService
    {
        ZBotUser GetUser(string id);
        void AddUser(ZBotUser user);
    }
}
