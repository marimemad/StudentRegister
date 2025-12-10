using DAL.Context;
using DAL.Repositories.CourseRepo;
using DAL.Repositories.StudentRepo;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public static class DALDependencies
    {
        public static IServiceCollection AddDALDependencies(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<StudentRegisterContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("dbcontext"));
            });

            services.AddScoped<IStudentRepo, StudentRepo>();
            services.AddScoped<ICourseRepo, CourseRepo>();
            services.AddScoped<IUnitOfWorkRepo, UnitOfWorkRepo>();

            return services;
        }
    }
}
