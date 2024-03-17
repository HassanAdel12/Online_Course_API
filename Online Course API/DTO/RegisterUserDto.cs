using System.ComponentModel.DataAnnotations;
using static Online_Course_API.Controllers.AccountController;

namespace Online_Course_API.DTO
{
    public class RegisterUserDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
