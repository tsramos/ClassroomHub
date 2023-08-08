using AutoMapper;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using ClassroomHub.Web.ViewModels.ActivityViewModels;

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

            CreateMap<CourseViewModel, Course>().ReverseMap();

            CreateMap<ClassViewModel, Class>().ReverseMap();

            CreateMap<StudentViewModel, Student>();

            CreateMap<Student, StudentViewModel>()
                .ForMember(x => x.Email, src => src.MapFrom(x => x.User.Email));

            CreateMap<TeacherViewModel, Teacher>()
                .ForMember(x => x.Especializacao, src => src.MapFrom(x => x.Especialization));

            CreateMap<Teacher, TeacherViewModel>()
                .ForMember(x => x.Email, src => src.MapFrom(x => x.User.Email))
                .ForMember(x => x.Especialization, src => src.MapFrom(x => x.Especializacao));

            CreateMap<ModuleViewModel, Module>()
                .ForMember(x => x.Nome, src => src.MapFrom(x => x.Name));

            CreateMap<Module, ModuleViewModel>()
                .ForMember(x => x.Name, src => src.MapFrom(s => s.Nome))
                .ForMember(x => x.TeacherName, src => src.MapFrom(x => x.Teacher.Name));

            CreateMap<Activity, ActivityViewModel>()
                .ForMember(x => x.ModuleName, src => src.MapFrom(x => x.Module.Nome))
                .ForMember(x => x.TeacherId, src => src.MapFrom(x => x.Module.TeacherId))
                .ForMember(x => x.Deliveries, src => src.MapFrom(x => x.Deliveries));

            CreateMap<ActivityViewModel, Activity>();

            CreateMap<Module, StudentAreaViewModel>()
                .ForMember(x => x.ModuleName, src => src.MapFrom(x => x.Nome));

            CreateMap<Activity, ActivityDeltailsViewModel>()
                .ForMember(x => x.ActivityId, src => src.MapFrom(x => x.Id));

            CreateMap<Delivery, ActivityDeltailsViewModel>().ReverseMap();

            CreateMap<Delivery, DeliveryViewModel>().ReverseMap();

            CreateMap<Module, DeliveryToTeacherViewModel>()
                .ForMember(x => x.Name, src => src.MapFrom(x => x.Nome))
                .ForMember(x => x.Activities, src => src.MapFrom(x => x.Activities)).ReverseMap();
                
        }
    }
}
