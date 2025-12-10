using System.ComponentModel.DataAnnotations;

namespace BL.DTOs.Student
{
    public class StudentWrite
    {
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
        public virtual ICollection<string> CourseIds { get; set; } = new HashSet<string>();
    }
}
