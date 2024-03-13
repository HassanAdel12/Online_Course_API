using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.Model
{
    public class Grade
    {
        [Key]
        public int Grade_ID { get; set; }

        [Required(ErrorMessage = "Grade name is required")]
        [StringLength(50, ErrorMessage = "Grade name must be between 1 and 50 characters", MinimumLength = 1)]
        public string Grade_Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

    }
}
