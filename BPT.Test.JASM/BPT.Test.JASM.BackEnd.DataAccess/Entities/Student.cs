using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BPT.Test.JASM.BackEnd.DataAccess
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Student name is required")]
        [StringLength(60, ErrorMessage = "Error, 60 character is the most value range permitted")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Date of Birth is required")]
        public DateTime DateBirth { get; set; }
    }
}
