using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BPT.Test.JASM
{
    public class AssigmentDTO
    {
      
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Assigment name is required")]
        [StringLength(60, ErrorMessage = "Error, 60 character is the most value range permitted")]
        public string Name { get; set; }
    }
}
