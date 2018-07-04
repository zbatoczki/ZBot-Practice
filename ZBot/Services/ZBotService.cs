using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZBot.Data;
using ZBot.Models;

namespace ZBot.Services
{
    public class ZBotService : IZBotService
    {
        private UserDbContext db; //holds context to communicate with database

        public ZBotService(UserDbContext db)
        {
            this.db = db;
        }

        public ZBotUser GetUser(string id)
        {
            return db.Find<ZBotUser>(id);
        }

        public void AddUser(ZBotUser user)
        {
            db.Add(user);
            db.SaveChanges();
        }
    }
}
