﻿using System.ComponentModel.DataAnnotations;

namespace Online_Course_API.DTO
{
    public class AllExamByGroupDTO
    {
        public int Quiz_ID { get; set; }
        public string Quiz_Name { get; set; }

        public int Group_ID { get; set; }

        
    }
}
