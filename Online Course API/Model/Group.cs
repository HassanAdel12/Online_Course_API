using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Course_API.Model
{
    public class Group
    {
        [Key]
        public int Group_ID { get; set; }

        public string GroupName { get; set; }

        public int Num_Students { get; set; }

        [ForeignKey("Instructor")]
        public int Instructor_ID { get; set; }

        public virtual Instructor Instructor { get; set; }

        public virtual ICollection<Student_Group> StudentGroups { get; set; }


    }
}
