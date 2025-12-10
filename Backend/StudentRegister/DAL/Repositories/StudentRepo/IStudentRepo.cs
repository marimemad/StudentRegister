using DAL.Models;
using DAL.Repositories.GenericRepo;

namespace DAL.Repositories.StudentRepo
{
    public interface IStudentRepo : IGenericRepo<Student>
    {
        public Task<List<Student>> GetStudentWithCoursesAsync();
    }
}
