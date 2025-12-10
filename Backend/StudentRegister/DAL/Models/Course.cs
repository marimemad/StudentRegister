using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Course
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
