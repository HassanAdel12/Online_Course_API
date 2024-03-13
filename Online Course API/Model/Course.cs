using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Course_API.Model
{
    public class Course
    {
        [Key]
        public int Course_ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Duration { get; set; }

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
