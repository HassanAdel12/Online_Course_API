using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.DTO
{
    public class CourseDTO
    {
        [Key]
        public int Course_ID { get; set; }

        [Required(ErrorMessage = "Course name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Course name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string Description { get; set; }

        public DateTime Duration { get; set; }


        [Required(ErrorMessage = "Price is required")]
        [Range(0, 1000, ErrorMessage = "Price must be a positive number")]

        public float Price { get; set; }

        public int Grade_ID { get; set; }
    }
}
