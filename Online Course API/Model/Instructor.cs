using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.Model
{
    public class Instructor
    {
        [Key]
        public int Instructor_ID { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters")]
        public string First_Name { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters")]
        public string Last_Name { get; set; }

        [RegularExpression(@"^01\d{9}$", ErrorMessage = "Phone number must start with 01 and be 11 digits long")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [RegularExpression(@"^\w+@gmail\.com$", ErrorMessage = "Email address must be from @gmail.com domain")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^.{6,20}$", ErrorMessage = "Password must be between 6 and 20 characters long")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [RegularExpression("^(Male|Female)$", ErrorMessage = "Invalid gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter your birth date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Please enter About yourself")]
        [StringLength(200)]
        public string AboutMe { get; set; }


        [StringLength(50)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your country")]
        [StringLength(50)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter your city")]
        [StringLength(50)]
        public string City { get; set; }

        public virtual ICollection<Group>? Groups { get; set; }

        public virtual ICollection<Session>? Sessions { get; set; }

        public virtual ICollection<Quiz> Quizzes { get; set; }

        public virtual ICollection<Instructor_Course> Instructor_Courses { get; set; }

    }
}
