using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_Course_API.DTO;
using Online_Course_API.Model;

namespace Online_Course_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly OnlineCourseDBContext context;

        private readonly IMapper mapper;

        public QuestionController(OnlineCourseDBContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }
        [Authorize(Roles = "Student")]
        [HttpGet]
        public IActionResult GetAll()
        {

            return Ok(mapper.Map<IEnumerable<QuestionDTO>>(context.Questions.ToList()));
        }


        [HttpGet("{ID:int}")]
        public IActionResult GetOneByID(int ID)
        {
            Question question = context.Questions.Find(ID);
            if (question == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(mapper.Map<QuestionDTO>(question));
            }
        }


        [HttpPost]
        public IActionResult Add(QuestionDTO questionDto)
        {

            if (ModelState.IsValid)
            {
                context.Questions.Add(mapper.Map<Question>(questionDto));
                context.SaveChanges();

                string URL = Url.Action(nameof(GetOneByID), new { ID = questionDto.Question_ID });

                return Created(URL, questionDto);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


        [HttpPut("{ID:int}")]
        public IActionResult Update(QuestionDTO questionDto, int ID)
        {

            if (ModelState.IsValid)
            {

                Question oldQuestion = context.Questions.Find(ID);
                if (oldQuestion != null)
                {
                    questionDto.Question_ID = ID;
                    mapper.Map(questionDto, oldQuestion);
                    context.Questions.Update(oldQuestion);
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

            Question question = context.Questions.Find(ID);
            if (question != null)
            {
                context.Questions.Remove(question);
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
