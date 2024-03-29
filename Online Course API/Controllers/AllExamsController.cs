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
    public class AllExamsController : ControllerBase
    {
        private readonly OnlineCourseDBContext _context;
        private readonly IMapper _mapper;

        public AllExamsController(OnlineCourseDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("Group/{groupId}")]
        public ActionResult<IEnumerable<AllExamByGroupDTO>> GetExamsByGroup(int groupId)
        {
            try
            {
                var exams = _context.Quizzes
                .Where(g => g.Group_ID == groupId).ToList();

                var allExamByGroupDTO = _mapper.Map<List<AllExamByGroupDTO>>(exams);
                return Ok(allExamByGroupDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }      
    }
}
