using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Course_API.Model
{
    public class Quiz
    {
        [Key]
        public int Quiz_ID { get; set; }

        public string Quiz_Name { get; set; }


        [ForeignKey("Instructor")]
        public int Instructor_ID { get; set; }

        public virtual Instructor Instructor { get; set; }


        [ForeignKey("Course")]
        public int Course_ID { get; set; }

        public virtual Course Course { get; set; }

        public virtual ICollection<Question> Questions { get; set; }

        public virtual ICollection<Student_Quiz> StudentQuizzes { get; set; }

    }
}
