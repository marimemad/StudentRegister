using BL.Managers.CourseManager;
using BL.Managers.StudentManager;

namespace BL.UnitOfWork
{
    public interface IUnitOfWorkManager
    {
        IStudentManager StudentManager { get; }
        ICourseManager CourseManager { get; }
    }
}
