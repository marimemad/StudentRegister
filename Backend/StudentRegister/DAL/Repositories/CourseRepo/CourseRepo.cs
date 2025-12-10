using DAL.Context;
using DAL.Models;
using DAL.Repositories.GenericRepo;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.CourseRepo
{
    public class CourseRepo : GenericRepo<Course>, ICourseRepo
    {
        private readonly DbSet<Course> _courses;

        public CourseRepo(StudentRegisterContext applicationDBContext) : base(applicationDBContext)
        {
            _courses = applicationDBContext.Set<Course>();
        }
    }

}
