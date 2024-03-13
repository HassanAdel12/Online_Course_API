using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Course_API.Model
{
    public class Session
    {
        [Key]
        public int Session_ID { get; set; }

        [Required(ErrorMessage = "Start date is required")]
        [DataType(DataType.Date)]
        public DateTime Start_Date { get; set; }

        [Required(ErrorMessage = "End date is required")]
        [DataType(DataType.Date)]
        public DateTime End_at { get; set; }

        [Required(ErrorMessage = "Rate is required")]
        [Range(0, 5, ErrorMessage = "Rate must be a non-negative number")]
        public float Rate { get; set; }

        [ForeignKey("Course")]
        public int Course_ID { get; set; }

        public virtual Course Course { get; set; }

        public virtual ICollection<Student_Session> StudentSessions { get; set; }

    }
}
