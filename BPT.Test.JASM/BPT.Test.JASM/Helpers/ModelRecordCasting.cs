using BPT.Test.JASM.BackEnd.DataAccess;
using BPT.Test.JASM.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPT.Test.JASM.Helpers
{
    public class ModelRecordCasting
    {

        internal static StudentListAssigmentsDTO ToStudentWihtListAssigments (Student studen, IQueryable <StudenAssigments> studenAssigments)
        {
            var studentListAssigmentsDTO = new StudentListAssigmentsDTO();
            studentListAssigmentsDTO.StudentName = studen.Name;
            studentListAssigmentsDTO.ListAssigments = ToListAssigments(studenAssigments);

            return studentListAssigmentsDTO;
        }

        internal static List<AssigmentDTO> ToListAssigments(IQueryable<StudenAssigments> studenAssigments)
        {
            var lstAssigments = new List<AssigmentDTO>();

            foreach (var studentassigment in studenAssigments)
            {
                var assigment = new AssigmentDTO();

                assigment.Id = studentassigment.IdAssignments;
                assigment.Name = studentassigment.Assignments.Name;
                lstAssigments.Add(assigment);
            }

            return lstAssigments;

            
        }


        internal static AssigmentListStudentsDTO ToAssigmentWihtListStudents(Assignments assigment, IQueryable<StudenAssigments> studenAssigments)
        {
            var studentListAssigmentsDTO = new AssigmentListStudentsDTO();
            studentListAssigmentsDTO.AssigmentName = assigment.Name;
            studentListAssigmentsDTO.ListStudents = ToListStudents(studenAssigments);

            return studentListAssigmentsDTO;
        }

        internal static List<StudentDTO> ToListStudents(IQueryable<StudenAssigments> studenAssigments)
        {
            var lstStudents = new List<StudentDTO>();

            foreach (var studentassigment in studenAssigments)
            {
                var student = new StudentDTO();

                student.Id = studentassigment.IdStudent;
                student.Name = studentassigment.Student.Name;
                lstStudents.Add(student);
            }

            return lstStudents;


        }

    }
}
