using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Course_API.Model
{
    public class Choise
    {
        [Key]
        public int Choise_ID { get; set; }

        public string Text { get; set; }

        public bool IsCorrect { get; set; }

        [ForeignKey("Question")]
        public int Question_ID { get; set; }

        public virtual Question Question { get; set; }

    }
}
