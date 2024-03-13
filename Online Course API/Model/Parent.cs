using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.Model
{
    public class Parent
    {
        [Key]
        public int Parent_ID { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Gender { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
