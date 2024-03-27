using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Online_Course_API.DTO;
using Online_Course_API.Model;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Online_Course_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        
        private readonly UserManager<ApplicationUser> usermanger;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration config;

        public AccountController(UserManager<ApplicationUser> usermanger, RoleManager<IdentityRole> roleManager, IConfiguration config)
        {
            this.usermanger = usermanger;
            this.config = config;
            this.roleManager = roleManager;
        }
       
        [HttpPost("register")]
        public async Task<IActionResult> Registration(RegisterUserDto userDto)
        {
            if (ModelState.IsValid)
            {

            
                ApplicationUser user = new ApplicationUser();
                user.UserName = userDto.UserName;
                user.Email = userDto.Email;
                IdentityResult result = await usermanger.CreateAsync(user, userDto.Password);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(userDto.Role))
                    {
                       
                        if (!await roleManager.RoleExistsAsync(userDto.Role))
                        {
                            await roleManager.CreateAsync(new IdentityRole(userDto.Role));
                        }

                        //await usermanger.AddToRoleAsync(user, userDto.Role);
                        //var message = $"User account created successfully with role: {userDto.Role}";
                        //return Ok(new { message });


                        await usermanger.AddToRoleAsync(user, userDto.Role);
                        return Ok();

                    }
                    else
                    {
                        
                        return BadRequest("Role name is required.");
                    }
                }
                else
                {
                    return BadRequest(result.Errors.FirstOrDefault()?.Description);
                }
              
            }
            return BadRequest(ModelState);
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUserDto userDto)
        {
            if (ModelState.IsValid == true)
            {
                
                ApplicationUser user = await usermanger.FindByNameAsync(userDto.UserName);
                if (user != null)
                {
                    bool found = await usermanger.CheckPasswordAsync(user, userDto.Password);
                    if (found)
                    {
                     
                        var claims = new List<Claim>();

                        claims.Add(new Claim(ClaimTypes.Role, "Instructor"));
                        claims.Add(new Claim(ClaimTypes.Role, "Student"));
                        claims.Add(new Claim(ClaimTypes.Role, "Parent"));


                        claims.Add(new Claim(ClaimTypes.Name, user.UserName));
                        claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));
                        claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
          
                        
                        var roles = await usermanger.GetRolesAsync(user);
                        foreach (var itemRole in roles)
                        {
                            claims.Add(new Claim(ClaimTypes.Role, itemRole));
                            switch (itemRole)
                            {
                                case "Instructor":
                                    claims.Add(new Claim("Instructor", "true"));
                                    break;
                                case "Student":
                                    claims.Add(new Claim("Student", "true"));
                                    break;
                                case "Parent":
                                    claims.Add(new Claim("Parent", "true"));
                                    break;
                                   
                            }
                        }
                    
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:SecretKey"]));
                        var sc = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                        
                        JwtSecurityToken mytoken = new JwtSecurityToken(
                            issuer: config["JWT:ValidIssuer"],
                            audience: config["JWT:ValidAudiance"],
                            claims: claims,
                            expires: DateTime.Now.AddHours(1),
                               signingCredentials: sc
                            );
                        return Ok(new
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(mytoken),
                            expiration = mytoken.ValidTo
                        });
                    }
                }
                return Unauthorized();

            }
            return Unauthorized("Invalid username or password.");
        }
    }
}
