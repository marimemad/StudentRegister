using DAL.Repositories.CourseRepo;
using DAL.Repositories.StudentRepo;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWorkRepo
    {
        ICourseRepo CourseRepo { get; }
        IStudentRepo StudentRepo { get; }
    }
}
