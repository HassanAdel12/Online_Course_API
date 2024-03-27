using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Online_Course_API.Model;

namespace Online_Course_API.DTO
{
    public class AllQuestionsinExamDTO
    {
        public int Question_ID { get; set; }
        public string Question_Text { get; set; }

        [ForeignKey("Quiz")]
        public int Quiz_ID { get; set; }

        public List <String> ChoisesText { get; set; }

    }
}
