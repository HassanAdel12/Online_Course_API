using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Course_API.DTO;
using Online_Course_API.Model;

namespace Online_Course_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentQuizController : ControllerBase
    {
        private readonly OnlineCourseDBContext _context;
        private readonly IMapper _mapper;

        public StudentQuizController(OnlineCourseDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

      
        [HttpGet]
        public ActionResult<IEnumerable<StudentQuizDTO>> GetStudentQuizzes()
        {
            var studentQuizzes = _context.Student_Quizzes.Include(sq => sq.Student).ToList();
            var studentQuizDTOs = _mapper.Map<List<StudentQuizDTO>>(studentQuizzes);
            return Ok(studentQuizDTOs);
        }

     
        [HttpGet("{studentId}/{quizId}")]
        public ActionResult<StudentQuizDTO> GetStudentQuiz(int studentId, int quizId)
        {
            var studentQuiz = _context.Student_Quizzes.Include(sq => sq.Student).FirstOrDefault(sq => sq.Student_ID == studentId && sq.Quiz_ID == quizId);
            if (studentQuiz == null)
            {
                return NotFound();
            }
            var studentQuizDTO = _mapper.Map<StudentQuizDTO>(studentQuiz);
            return Ok(studentQuizDTO);
        }


        [HttpPost]
        public ActionResult<StudentQuizDTO> PostStudentQuiz(StudentQuizDTO studentQuizDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var studentQuiz = _mapper.Map<Student_Quiz>(studentQuizDTO);
            _context.Student_Quizzes.Add(studentQuiz);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetStudentQuiz), new { studentId = studentQuiz.Student_ID, quizId = studentQuiz.Quiz_ID }, studentQuizDTO);
        }


        [HttpPut("{studentId}/{quizId}")]
        public IActionResult PutStudentQuiz(int studentId, int quizId, StudentQuizDTO studentQuizDTO)
        {
            if (studentId != studentQuizDTO.Student_ID || quizId != studentQuizDTO.Quiz_ID)
            {
                return BadRequest();
            }

            var studentQuiz = _context.Student_Quizzes.FirstOrDefault(sq => sq.Student_ID == studentId && sq.Quiz_ID == quizId);
            if (studentQuiz == null)
            {
                return NotFound();
            }

            _mapper.Map(studentQuizDTO, studentQuiz);
            _context.SaveChanges();

            return NoContent();
        }

        
        [HttpDelete("{studentId}/{quizId}")]
        public IActionResult DeleteStudentQuiz(int studentId, int quizId)
        {
            var studentQuiz = _context.Student_Quizzes.FirstOrDefault(sq => sq.Student_ID == studentId && sq.Quiz_ID == quizId);
            if (studentQuiz == null)
            {
                return NotFound();
            }

            _context.Student_Quizzes.Remove(studentQuiz);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
