using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BPT.Test.JASM.BackEnd.DataAccess
{
    public class Assignments
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Assigment name is required")]
        [StringLength(60, ErrorMessage = "Error, 60 character is the most value range permitted")]
        public string Name { get; set; }

        public virtual ICollection<StudenAssigments> StudenAssigments { get; set; }

    }
}
