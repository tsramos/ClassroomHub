using ClassroomHub.Core.Contracts;
using ClassroomHub.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ClassroomHub.DependencyInjection
{
    public static class DependencyInjectionExtension
    {
        public static void AddServicesDependency(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IActivityService, ActivityService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IDeliveryService, DeliveryService>();
            services.AddScoped<IModuleService, ModuleService>();
        }
       
        public static void AddRepositoryDependency(this IServiceCollection services)
        {
            
        }
    }
}
