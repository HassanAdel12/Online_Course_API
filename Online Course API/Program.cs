
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Online_Course_API.Model;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

namespace Online_Course_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var hmac = new HMACSHA256();
            //var secretKey = Convert.ToBase64String(hmac.Key);
            //// SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));


            var builder = WebApplication.CreateBuilder(args);

           

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<OnlineCourseDBContext>(Options =>
            {
                Options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
            });
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<OnlineCourseDBContext>();

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("InstructorPolicy", policy =>
                    policy.RequireRole("Instructor"));
                options.AddPolicy("StudentPolicy", policy => policy.RequireRole("Student"));
                options.AddPolicy("ParentPolicy", policy => policy.RequireRole("Parent"));
            });


            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options => {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
                    ValidateAudience = true,
                    ValidAudience = builder.Configuration["JWT:ValidAudiance"],
                    IssuerSigningKey =
                    //new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:SecretKey"]))
                //new SymmetricSecurityKey(keyBytes)
                };
            });

            builder.Services.AddCors(corsOptions => {
                corsOptions.AddPolicy("MyPolicy", corsPolicyBuilder =>
                {
                    corsPolicyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });
            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.AddAutoMapper(typeof(Program));

            var app = builder.Build();

           
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseAuthentication();//Check JWT token
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
