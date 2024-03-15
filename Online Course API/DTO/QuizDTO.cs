using Online_Course_API.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.DTO
{
    public class QuizDTO
    {
        [Key]
        public int Quiz_ID { get; set; }

        [Required(ErrorMessage = "Quiz name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Quiz name must be between 3 and 50 characters")]
        public string Quiz_Name { get; set; }

        public int Instructor_ID { get; set; }

        public int Course_ID { get; set; }
    }
}
