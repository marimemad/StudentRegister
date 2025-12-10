using DAL.Repositories.CourseRepo;
using DAL.Repositories.StudentRepo;

namespace DAL.UnitOfWork
{
    public class UnitOfWorkRepo : IUnitOfWorkRepo
    {
        public ICourseRepo CourseRepo { get; }
        public IStudentRepo StudentRepo { get; }

        public UnitOfWorkRepo(ICourseRepo courseRepo, IStudentRepo studentRepo)
        {
            CourseRepo = courseRepo;
            StudentRepo = studentRepo;
        }
    }
}
