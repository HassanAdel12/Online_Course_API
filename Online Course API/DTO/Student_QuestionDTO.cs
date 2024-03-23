using Online_Course_API.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.DTO
{
    public class Student_QuestionDTO
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Student")]
        public int Student_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Question")]
        [Required(ErrorMessage = "Question ID is required.")]
        public int Question_ID { get; set; }


        public string St_Answer { get; set; }
    }
}
