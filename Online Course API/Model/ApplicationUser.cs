using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.Model
{
    public class ApplicationUser : IdentityUser
    {
        //public ICollection<Instructor> Instructors { get; set; }
        //public ICollection<Student> Students { get; set; }

        [RegularExpression("^(Male|Female)$", ErrorMessage = "Invalid gender")]
        public string? Gender { get; set; }


    }
}
