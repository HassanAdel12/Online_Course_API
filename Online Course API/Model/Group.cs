﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Course_API.Model
{
    public class Group
    {
        [Key]
        public int Group_ID { get; set; }

        [Required(ErrorMessage = "Group name is required")]
        [StringLength(50, ErrorMessage = "Group name must be between 3 and 50 characters", MinimumLength = 3)]
        public string GroupName { get; set; }

        [Required(ErrorMessage = "Number of students is required")]
        [Range(0, 22, ErrorMessage = "Number of students must be at least 0")]
        public int Num_Students { get; set; }

        [ForeignKey("Instructor")]
        public int Instructor_ID { get; set; }

        public virtual Instructor Instructor { get; set; }

        public virtual ICollection<Student_Group> StudentGroups { get; set; }


    }
}
