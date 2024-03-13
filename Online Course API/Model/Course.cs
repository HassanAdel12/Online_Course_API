using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Course_API.Model
{
    public class Course
    {
        [Key]
        public int Course_ID { get; set; }

        [Required(ErrorMessage = "Course name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Course name must be between 3 and 100 characters")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string Description { get; set; }

        [Display(Name = "Duration ( days)")]
        public DateTime Duration { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0, 1000, ErrorMessage = "Price must be a positive number")]

        public float Price { get; set; }

        [ForeignKey("Grade")]
        public int Grade_ID { get; set; }

        public virtual Grade Grade { get; set; }

        public virtual ICollection<Quiz> Quizzes { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }

        public virtual ICollection<Instructor_Course> Instructor_Courses { get; set; }

        public virtual ICollection<Student_Course> StudentCourses { get; set; }

    }
}
