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
    public class AllQuestionController : ControllerBase
    {
        private readonly OnlineCourseDBContext _context;
        private readonly IMapper _mapper;

        public AllQuestionController(OnlineCourseDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

     

        [HttpGet("AllQuestions/{quizId}")]
        public ActionResult<IEnumerable<AllQuestionsinExamDTO>> GetGroupsByCourse(int quizId)
        {
            var questions = _context.Questions
                .Where(g => g.Quiz_ID == quizId).Include(g => g.Choises).ToList();

            var questionsDTO = _mapper.Map<List<AllQuestionsinExamDTO>>(questions);
            return Ok(questionsDTO);
        }

    }
}
