using Online_Course_API.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.DTO
{
    public class Student_GroupDTO
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Student")]
        public int Student_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Group")]
        public int Group_ID { get; set; }

     
    }
}
