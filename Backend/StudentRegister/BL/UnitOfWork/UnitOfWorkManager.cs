using BL.Managers.CourseManager;
using BL.Managers.StudentManager;

namespace BL.UnitOfWork
{
    // collect managers in a unit
    public class UnitOfWorkManager : IUnitOfWorkManager
    {
        public IStudentManager StudentManager { get; }

        public ICourseManager CourseManager { get; }

        public UnitOfWorkManager(IStudentManager studentManager, ICourseManager courseManager)
        {
            StudentManager = studentManager;
            CourseManager = courseManager;
        }

    }
}
