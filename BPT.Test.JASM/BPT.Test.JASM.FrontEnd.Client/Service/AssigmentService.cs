using System;
using System.Collections.Generic;
using System.Text;

namespace BPT.Test.JASM.FrontEnd.Client.Service
{
    public class AssigmentService
    {
        ApiConnection apiConnection;

        public AssigmentService()
        {
            apiConnection = new ApiConnection();
        }

        public List<AssigmentDTO> GetListOfAssigments()
        {
            var lstStudents = apiConnection.GetListOfAssigments();
            return lstStudents;
        }

        public AssigmentListStudentsDTO GetAssigment(Guid idStudent)
        {
            var student = apiConnection.GetAssigment(idStudent);
            return student;
        }


        public AssigmentDTO CreateAssigment(string name)
        {

            var assigmentDto = new AssigmentDTO()
            {
                Name = name,
            };

            return assigmentDto = apiConnection.PostAssigment(assigmentDto);
        }

        public AssigmentDTO UpdateAssigment(string idAssigment, string name)
        {

            var studentDto = new AssigmentDTO()
            {
                Id = Guid.Parse(idAssigment),
                Name = name,
            };

            return studentDto = apiConnection.PutAssigment(studentDto);
        }

        public bool DeleteAssigment(string idAssigment)
        {
            return apiConnection.DeleteAssigment(Guid.Parse(idAssigment));
        }
    }
}
