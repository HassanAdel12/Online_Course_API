﻿using Online_Course_API.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.DTO
{
    public class StudentCourseDTO
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Student")]
        public int Student_ID { get; set; }


        [Key]
        [Column(Order = 1)]
        [ForeignKey("Course")]
        public int Course_ID { get; set; }

        public DateTime Enroll_Date { get; set; }
    }
}
