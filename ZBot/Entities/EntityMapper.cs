using AutoMapper;
using ZBot.Models;

namespace ZBot.Entities
{
    public class EntityMapper : Profile
    {
        public EntityMapper()
        {
            CreateMap<ZBotUser, User>().ForMember(x => x.Token, opt => opt.Ignore());
            CreateMap<ZBotUser, Token>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.User, opt => opt.Ignore());
        }
    }
}
