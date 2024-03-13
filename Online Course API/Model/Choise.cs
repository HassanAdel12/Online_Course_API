using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Course_API.Model
{
    public class Choise
    {
        [Key]
        public int Choise_ID { get; set; }


        [Required(ErrorMessage = "Text is required")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Text must be between 5 and 100 characters")]
        public string Text { get; set; }

        [Display(Name = "Correct Answer")]
        public bool IsCorrect { get; set; }

        [Required(ErrorMessage = "Question ID is required")]
        [ForeignKey("Question")]
        public int Question_ID { get; set; }

        public virtual Question Question { get; set; }

    }
}
