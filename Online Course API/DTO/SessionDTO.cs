using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.DTO
{
    public class SessionDTO
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
    }
}
