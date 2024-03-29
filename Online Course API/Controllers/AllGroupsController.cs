using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Course_API.Data;
using Online_Course_API.DTO;

namespace Online_Course_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllGroupsController : ControllerBase
    {

        private readonly OnlineCourseDBContext _context;
        private readonly IMapper _mapper;

        public AllGroupsController(OnlineCourseDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("Course/{courseId}")]
        public ActionResult<IEnumerable<CourseGroupesDTO>> GetGroupsByCourse(int courseId)
        {
            try
            {
                var groups = _context.Groups
               .Where(g => g.Course_ID == courseId).
               Include(g => g.Instructor).
               Include(g => g.Course).ToList();


                var courseGroupesDTO = _mapper.Map<List<CourseGroupesDTO>>(groups);
                return Ok(courseGroupesDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
           
        }

        [HttpGet("Instructor/{instructorId}")]
        public ActionResult<IEnumerable<CourseGroupesDTO>> GetGroupsByInstructor(int instructorId)
        {
            try
            {
                var groups = _context.Groups
                .Where(g => g.Instructor_ID == instructorId).
                Include(g => g.Instructor).Include(g => g.Course).ToList();

                var courseGroupesDTO = _mapper.Map<List<CourseGroupesDTO>>(groups);
                return Ok(courseGroupesDTO);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }

        [HttpGet("BycourseName/{courseName}")]
        public ActionResult<IEnumerable<CourseGroupesDTO>> GetGroupsByCourseName(string courseName)
        {
            try
            {
                var groups = _context.Groups
                .Include(g => g.Instructor)
                .Include(g => g.Course)
                .Where(g => g.Course.Name == courseName).ToList();
                var courseGroupesDTO = _mapper.Map<List<CourseGroupesDTO>>(groups);
                return Ok(courseGroupesDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }
    }
}
