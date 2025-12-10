using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Student
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        //[RegularExpression(@"^(010|011|012|015)[0-9]{8}$",
        //ErrorMessage = "Phone must be an Egyptian mobile number.")]
        [Required]
        [Phone]
        public string Phono { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
