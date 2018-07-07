using AutoMapper;
using ZBot.Data;
using ZBot.Entities;
using ZBot.Models;

namespace ZBot.Services
{
    public class ZBotService : IZBotService
    {
        private ZBotDbContext db; //holds context to communicate with database
        private readonly IMapper mapper;

        public ZBotService(ZBotDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public ZBotUser GetUser(string id)
        {
            User dbUser =  db.Find<User>(id);
            return mapper.Map<ZBotUser>(dbUser);
        }

        public void AddUser(ZBotUser user)
        {           
            db.Add( mapper.Map<User>(user) );
            db.Add( mapper.Map<Token>(user) );
            db.SaveChanges();
        }
    }
}
