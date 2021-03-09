using System;
using System.Collections.Generic;
using System.Text;

namespace BPT.Test.JASM.FrontEnd.Client.Service
{
    public class StudentService
    {
        ApiConnection apiConnection;

        public StudentService()
        {
            apiConnection = new ApiConnection();
        }


        public List<StudentDTO> GetListOfStudent()
        {
            var lstStudents = apiConnection.GetListOfStudents();
            return lstStudents;
        }

        public StudentListAssigmentsDTO GetStudent(Guid idStudent)
        {
            var student = apiConnection.GetStudent(idStudent);
            return student;
        }


        public StudentDTO CreateStudent(string name, DateTime dateBrith)
        {

            var studentDto = new StudentDTO() {
                Name = name, DateBirth = dateBrith
            };

            return studentDto = apiConnection.PostStudent(studentDto);
        }

        public StudentDTO UpdateStudent(string idStudent, string name, DateTime dateBrith)
        {

            var studentDto = new StudentDTO()
            {
                Id = Guid.Parse(idStudent),
                Name = name,
                DateBirth = dateBrith
            };

            return studentDto = apiConnection.PutStudent(studentDto);
        }

        public bool DeleteStudent (string idStudent)
        {
            return apiConnection.DeleteStudent(Guid.Parse(idStudent));
        }


    }
}
