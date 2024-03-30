﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Course_API.Data;
using Online_Course_API.DTO;
using System.Text.RegularExpressions;

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

        [HttpGet("courseName/{courseName}")]
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


        [HttpGet("Student/{StudentId}")]
        public ActionResult<IEnumerable<CourseGroupesDTO>> GetGroupsByStudent(int StudentId)
        {
            try
            {
                IEnumerable<CourseGroupesDTO> groups = _context.Student_Groups
                .Where(g => g.Student_ID == StudentId).
                Include(g => g.Group.Course).Include(g => g.Group.Instructor).
                Select(g => new CourseGroupesDTO
                {
                    Group_ID = g.Group_ID,
                    GroupName = g.Group.GroupName,
                    Course_ID = g.Group.Course_ID,
                    courseName = g.Group.Course.Name,
                    Instructor_ID = g.Group.Instructor_ID,
                    InstructorName = g.Group.Course.Name,
                    Num_Students = g.Group.Num_Students,
                    Creation_Date = g.Group.Creation_Date,
                    End_Date = g.Group.End_Date,
                    Price = g.Group.Price

                });

                return Ok(groups);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}
