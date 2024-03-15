using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.DTO
{
    public class GroupDTO
    {
        [Key]
        public int Group_ID { get; set; }

        [Required(ErrorMessage = "Group name is required")]
        [StringLength(50, ErrorMessage = "Group name must be between 3 and 50 characters", MinimumLength = 3)]
        public string GroupName { get; set; }

        [Required(ErrorMessage = "Number of students is required")]
        [Range(0, 22, ErrorMessage = "Number of students must be at least 0")]
        public int Num_Students { get; set; }

        public int Instructor_ID { get; set; }


    }
}
