using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Course_API.Model
{
    public class Student
    {
        [Key]
        public int Student_ID { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Gender { get; set; }

        [ForeignKey("Parent")]
        public int Parent_ID { get; set; }

        public virtual Parent Parent { get; set; }

        public virtual ICollection<Student_Course> StudentCourses { get; set; }

        public virtual ICollection<Student_Group> StudentGroups { get; set; }

        public virtual ICollection<Student_Question> StudentQuestions { get; set; }

        public virtual ICollection<Student_Quiz> StudentQuizzes { get; set; }

        public virtual ICollection<Student_Session> StudentSessions { get; set; }



    }
}
