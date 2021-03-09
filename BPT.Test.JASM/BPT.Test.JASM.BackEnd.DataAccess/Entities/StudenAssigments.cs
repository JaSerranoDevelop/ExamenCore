using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BPT.Test.JASM.BackEnd.DataAccess
{
    public class StudenAssigments
    {
        [Column(Order = 1)]
        public Guid IdStudent { get; set; }

        [Column(Order = 2)]
        public Guid IdAssignments { get; set; }

        [ForeignKey("IdStudent")]
        public Student Student { get; set; }

        [ForeignKey("IdAssignments")]
        public Assignments Assignments { get; set; }

    }
}
