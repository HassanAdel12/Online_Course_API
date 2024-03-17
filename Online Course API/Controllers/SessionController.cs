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
    [Authorize]
    public class SessionController : ControllerBase
    {
        private readonly OnlineCourseDBContext _context;
        private readonly IMapper _mapper;

        public SessionController(OnlineCourseDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [Authorize(Roles = "Student")]
        [HttpGet]
        public ActionResult<IEnumerable<SessionDTO>> GetSessions()
        {
            var sessions = _context.Sessions.ToList();
            var sessionDTOs = _mapper.Map<List<SessionDTO>>(sessions);
            return Ok(sessionDTOs);
        }

    
        [HttpGet("{id}")]
        public ActionResult<SessionDTO> GetSession(int id)
        {
            var session = _context.Sessions.FirstOrDefault(s => s.Session_ID == id);
            if (session == null)
            {
                return NotFound();
            }
            var sessionDTO = _mapper.Map<SessionDTO>(session);
            return Ok(sessionDTO);
        }

       
        [HttpPost]
        public IActionResult PostSession(SessionDTO sessionDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var session = _mapper.Map<Session>(sessionDTO);

            _context.Sessions.Add(session);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetSession), new { id = session.Session_ID }, sessionDTO);
        }

     
        [HttpPut("{id}")]
        public IActionResult PutSession(int id, SessionDTO sessionDTO)
        {
            if (id != sessionDTO.Session_ID)
            {
                return BadRequest();
            }

            var session = _context.Sessions.Find(id);

            if (session == null)
            {
                return NotFound();
            }

            _mapper.Map(sessionDTO, session);

            _context.SaveChanges();

            return NoContent();
        }

   
        [HttpDelete("{id}")]
        public IActionResult DeleteSession(int id)
        {
            var session = _context.Sessions.Find(id);

            if (session == null)
            {
                return NotFound();
            }

            _context.Sessions.Remove(session);
            _context.SaveChanges();

            return NoContent();
        }
    
}
}
