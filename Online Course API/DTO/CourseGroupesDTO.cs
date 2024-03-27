﻿using Online_Course_API.Model;
using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.DTO
{
    public class CourseGroupesDTO
    {
      
        public int Group_ID { get; set; }

        public string GroupName { get; set; }

        public int Instructor_ID { get; set; }

        public int Course_ID { get; set; }

        public string InstructorName { get; set; }

        public string  courseName { get; set; }


    }
}
