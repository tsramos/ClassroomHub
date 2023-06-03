using AutoMapper;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;

namespace ClassroomHub.Web.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        { 
            CreateMap<UserViewModel,User>()
                .ForMember(x => x.Email, src => src.MapFrom(x => x.UserName))
                .ForMember(x => x.Password, src => src.MapFrom(x => x.Password))
                .ReverseMap();
            
        }
    }
}
