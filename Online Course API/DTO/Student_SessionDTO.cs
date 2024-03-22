﻿using Online_Course_API.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.DTO
{
    public class Student_SessionDTO
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Student")]
        public int Student_ID { get; set; }


        [Key]
        [Column(Order = 1)]
        [ForeignKey("Session")]
        [Required(ErrorMessage = "Session ID is required.")]
        public int Session_ID { get; set; }


        [Range(0, 5, ErrorMessage = "Rate must be between 0 and 5.")]
        public float Rate { get; set; }

        [StringLength(200, ErrorMessage = "Comment length cannot exceed 200 characters.")]
        public string Comment { get; set; }

    }
}