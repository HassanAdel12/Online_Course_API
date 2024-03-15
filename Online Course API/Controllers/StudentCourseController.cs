using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_Course_API.DTO;
using Online_Course_API.Model;

namespace Online_Course_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentCourseController : ControllerBase
    {
        private readonly OnlineCourseDBContext _context;
        private readonly IMapper _mapper;

        public StudentCourseController(OnlineCourseDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

    
        [HttpGet]
        public ActionResult<IEnumerable<StudentCourseDTO>> GetStudentCourses()
        {
            var studentCourses = _context.Student_Courses.ToList();
            var studentCourseDTOs = _mapper.Map<List<StudentCourseDTO>>(studentCourses);
            return Ok(studentCourseDTOs);
        }

        
        [HttpGet("{studentId}/{courseId}")]
        public ActionResult<StudentCourseDTO> GetStudentCourse(int studentId, int courseId)
        {
            var studentCourse = _context.Student_Courses.FirstOrDefault(sc => sc.Student_ID == studentId && sc.Course_ID == courseId);
            if (studentCourse == null)
            {
                return NotFound();
            }
            var studentCourseDTO = _mapper.Map<StudentCourseDTO>(studentCourse);
            return Ok(studentCourseDTO);
        }

    
        [HttpPost]
        public ActionResult<StudentCourseDTO> PostStudentCourse(StudentCourseDTO studentCourseDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var studentCourse = _mapper.Map<Student_Course>(studentCourseDTO);
            _context.Student_Courses.Add(studentCourse);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetStudentCourse), new { studentId = studentCourse.Student_ID, courseId = studentCourse.Course_ID }, studentCourseDTO);
        }

      
        [HttpPut("{studentId}/{courseId}")]
        public IActionResult PutStudentCourse(int studentId, int courseId, StudentCourseDTO studentCourseDTO)
        {
            if (studentId != studentCourseDTO.Student_ID || courseId != studentCourseDTO.Course_ID)
            {
                return BadRequest();
            }

            var studentCourse = _context.Student_Courses.FirstOrDefault(sc => sc.Student_ID == studentId && sc.Course_ID == courseId);
            if (studentCourse == null)
            {
                return NotFound();
            }

            _mapper.Map(studentCourseDTO, studentCourse);
            _context.SaveChanges();

            return NoContent();
        }

        
        [HttpDelete("{studentId}/{courseId}")]
        public IActionResult DeleteStudentCourse(int studentId, int courseId)
        {
            var studentCourse = _context.Student_Courses.FirstOrDefault(sc => sc.Student_ID == studentId && sc.Course_ID == courseId);
            if (studentCourse == null)
            {
                return NotFound();
            }

            _context.Student_Courses.Remove(studentCourse);
            _context.SaveChanges();

            return NoContent();
        }
    
}
}
