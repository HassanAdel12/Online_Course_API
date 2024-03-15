using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_Course_API.DTO;
using Online_Course_API.Model;

namespace Online_Course_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly OnlineCourseDBContext context;

        private readonly IMapper mapper;

        public GroupController(OnlineCourseDBContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            return Ok(mapper.Map<IEnumerable<GroupDTO>>(context.Groups.ToList()));
        }


        [HttpGet("{ID:int}")]
        public IActionResult GetOneByID(int ID)
        {
            Group group = context.Groups.Find(ID);
            if (group == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(mapper.Map<GroupDTO>(group));
            }
        }


        [HttpPost]
        public IActionResult Add(GroupDTO groupDto)
        {

            if (ModelState.IsValid)
            {
                context.Groups.Add(mapper.Map<Group>(groupDto));
                context.SaveChanges();

                string URL = Url.Action(nameof(GetOneByID), new { ID = groupDto.Group_ID });

                return Created(URL, groupDto);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


        [HttpPut("{ID:int}")]
        public IActionResult Update(GroupDTO groupDto, int ID)
        {

            if (ModelState.IsValid)
            {

                Group oldGroup = context.Groups.Find(ID);
                if (oldGroup != null)
                {
                    groupDto.Group_ID = ID;
                    mapper.Map(groupDto, oldGroup);
                    context.Groups.Update(oldGroup);
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

            Group group = context.Groups.Find(ID);
            if (group != null)
            {
                context.Groups.Remove(group);
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
