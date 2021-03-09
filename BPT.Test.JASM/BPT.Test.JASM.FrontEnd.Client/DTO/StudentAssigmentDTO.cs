using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPT.Test.JASM.FrontEnd.Client
{
    public class StudentAssigmentDTO
    {
        public Guid IdStudent { get; set; }
        public Guid IdAssignments { get; set; }
    }

    public class StudentListAssigmentsDTO
    {

        public string StudentName { get; set; }
        public List<AssigmentDTO> ListAssigments { get; set; }
    }

    public class AssigmentListStudentsDTO
    {

        public string AssigmentName { get; set; }
        public List<StudentDTO> ListStudents { get; set; }
    }


    public class StudenAssigmenDetailDTO
    {
        public string StudentName { get; set; }
        public string AssigmentName { get; set; }
    }
}
