using System;
using System.Collections.Generic;
using System.Text;

namespace BPT.Test.JASM.FrontEnd.Client.Service
{
    public class StudentAssigmentService
    {
        ApiConnection apiConnection;

        public StudentAssigmentService()
        {
            apiConnection = new ApiConnection();
        }

        public StudentAssigmentDTO CreateStudentAssigment(Guid idStudent, Guid idAssigment)
        {

            var assigmentDto = new StudentAssigmentDTO()
            {
                IdStudent = idStudent, 
                IdAssignments = idAssigment
            };

            return assigmentDto = apiConnection.PostStudentAssigment(assigmentDto);
        }

        public StudenAssigmenDetailDTO GetStudentAssigment(string idStudent, string idAssigment)
        {
            return apiConnection.GetStudentAssigment(idAssigment, idStudent);
        }


        public void DeleteStudentAssigment(string idStudent, string idAssigment)
        {
            apiConnection.DeleteStudentAssigment(idAssigment, idStudent);
        }
    }
}
