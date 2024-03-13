using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.Model
{
    public class Grade
    {
        [Key]
        public int Grade_ID { get; set; }

        public string Grade_Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

    }
}
