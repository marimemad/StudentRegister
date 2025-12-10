using BL.Bases;
using BL.DTOs.Student;

namespace BL.Managers.StudentManager
{
    public interface IStudentManager
    {
        public Task<Response<List<StudentRead>>> GetStudentWithCoursesAsync();
        public Task<Response<string>> CreateStudentAsync(StudentWrite model);
    }
}
