using BL.AutoMapper;
using BL.Managers.CourseManager;
using BL.Managers.StudentManager;
using BL.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace BL
{
    public static class BLDependencies
    {
        public static IServiceCollection AddBLDependencies(
            this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddScoped<IStudentManager, StudentManager>();
            services.AddScoped<ICourseManager, CourseManager>();
            services.AddScoped<IUnitOfWorkManager, UnitOfWorkManager>();
            return services;
        }
    }
}
