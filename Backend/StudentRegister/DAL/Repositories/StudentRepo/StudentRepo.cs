using DAL.Context;
using DAL.Models;
using DAL.Repositories.GenericRepo;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.StudentRepo
{
    public class StudentRepo : GenericRepo<Student>, IStudentRepo
    {
        private readonly DbSet<Student> _students;

        public StudentRepo(StudentRegisterContext applicationDBContext) : base(applicationDBContext)
        {
            _students = applicationDBContext.Set<Student>();
        }
        public async Task<List<Student>> GetStudentWithCoursesAsync()
        {
            return await _students.Include(s => s.Courses).ToListAsync();
        }
    }
}
