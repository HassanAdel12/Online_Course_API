using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.Model
{
    public class Student_Session
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Student")]
        public int Student_ID { get; set; }

    
        public virtual Student Student { get; set; }


        [Key]
        [Column(Order = 1)]
        [ForeignKey("Session")]
        public int Session_ID { get; set; }

        [Required(ErrorMessage = "Session ID is required.")]
        public virtual Session Session { get; set; }

        [Range(0, 5, ErrorMessage = "Rate must be between 0 and 5.")]
        public float Rate { get; set; }

        [StringLength(500, ErrorMessage = "Comment length cannot exceed 500 characters.")]
        public string Comment { get; set; }


    }
}
