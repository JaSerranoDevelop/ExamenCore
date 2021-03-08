using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BPT.Test.JASM.DTO
{
    public class StudentDTO
    {
       
        public Guid Id { get; set; }
        [StringLength(60, ErrorMessage = "Error, 60 character is the most value range permitted")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        public DateTime DateBirth { get; set; }
    }
}
