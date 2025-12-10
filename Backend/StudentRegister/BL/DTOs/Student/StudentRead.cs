using BL.DTOs.Course;

namespace BL.DTOs.Student
{
    public class StudentRead
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<CouseRead> Courses { get; set; } = new HashSet<CouseRead>();
    }
}
