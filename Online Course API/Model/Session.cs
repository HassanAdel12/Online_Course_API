using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Course_API.Model
{
    public class Session
    {
        [Key]
        public int Session_ID { get; set; }

        public DateTime Start_Date { get; set; }

        public DateTime End_at { get; set; }

        public float Rate { get; set; }

        [ForeignKey("Course")]
        public int Course_ID { get; set; }

        public virtual Course Course { get; set; }

        public virtual ICollection<Student_Session> StudentSessions { get; set; }

    }
}
