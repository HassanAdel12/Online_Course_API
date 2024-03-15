using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_Course_API.DTO;
using Online_Course_API.Model;

namespace Online_Course_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly OnlineCourseDBContext context;

        private readonly IMapper mapper;

        public CourseController(OnlineCourseDBContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            return Ok(mapper.Map<IEnumerable<CourseDTO>>(context.Courses.ToList()));
        }


        [HttpGet("{ID:int}")]
        public IActionResult GetOneByID(int ID)
        {
            Course course = context.Courses.Find(ID);
            if (course == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(mapper.Map<CourseDTO>(course));
            }
        }


        [HttpPost]
        public IActionResult Add(CourseDTO courseDto)
        {

            if (ModelState.IsValid)
            {
                context.Courses.Add(mapper.Map<Course>(courseDto));
                context.SaveChanges();

                string URL = Url.Action(nameof(GetOneByID), new { ID = courseDto.Course_ID });

                return Created(URL, courseDto);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


        [HttpPut("{ID:int}")]
        public IActionResult Update(CourseDTO courseDto, int ID)
        {

            if (ModelState.IsValid)
            {

                Course oldCourse = context.Courses.Find(ID);
                if (oldCourse != null)
                {
                    courseDto.Course_ID = ID;
                    mapper.Map(courseDto, oldCourse);
                    context.Courses.Update(oldCourse);
                    context.SaveChanges();

                    return Ok();
                }
                else
                {
                    return NotFound();
                }

            }
            else
            {
                return BadRequest(ModelState);
            }
        }


        [HttpDelete("{ID:int}")]
        public IActionResult Delete(int ID)
        {

            Course course = context.Courses.Find(ID);
            if (course != null)
            {
                context.Courses.Remove(course);
                context.SaveChanges();

                return Ok();
            }
            else
            {
                return NotFound();
            }


        }
    }
}
