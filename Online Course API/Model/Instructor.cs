using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.Model
{
    public class Instructor
    {
        [Key]
        public int Instructor_ID { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Gender { get; set; }

        public virtual ICollection<Group> Groups { get; set; }

        public virtual ICollection<Quiz> Quizzes { get; set; }

        public virtual ICollection<Instructor_Course> Instructor_Courses { get; set; }

    }
}
