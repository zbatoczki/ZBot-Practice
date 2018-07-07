using AutoMapper;
using ZBot.Models;

namespace ZBot.Entities
{
    public class EntityMapper : Profile
    {
        public EntityMapper()
        {
            CreateMap<User, ZBotUser>();
            CreateMap<Token, ZBotUser>();
        }
    }
}
