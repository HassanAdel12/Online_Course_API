﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.DTO
{
    public class ChoiseDTO
    {

        [Key]
        public int Choise_ID { get; set; }


        [Required(ErrorMessage = "Text is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Text must be between 3 and 100 characters")]
        public string Text { get; set; }


        public bool IsCorrect { get; set; }

        [Required(ErrorMessage = "Question ID is required")]
        public int Question_ID { get; set; }


    }
}
