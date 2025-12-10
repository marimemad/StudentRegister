using BL.Bases;
using BL.DTOs.Course;

namespace BL.Managers.CourseManager
{
    public interface ICourseManager
    {
        public Task<Response<List<CouseRead>>> GetCoursesAsync();
    }
}
