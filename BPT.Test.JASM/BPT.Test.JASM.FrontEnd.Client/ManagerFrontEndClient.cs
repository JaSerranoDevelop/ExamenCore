using BPT.Test.JASM.FrontEnd.Client.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace BPT.Test.JASM.FrontEnd.Client
{
    public class ManagerFrontEndClient
    {
        StudentService studenService;
        AssigmentService assigmentService;
        StudentAssigmentService studentAssigmentService;

        public ManagerFrontEndClient()
        {
            studenService = new StudentService();
            assigmentService = new AssigmentService();
            studentAssigmentService = new StudentAssigmentService();
        }


        #region Students
        public void CreateStudent(string Name, DateTime brithDay)
        {
            var student = studenService.CreateStudent(Name, brithDay);
        }

        public void EditStudent(string id, string Name, DateTime brithDay)
        {
            var student = studenService.UpdateStudent(id, Name, brithDay);
        }

        public List<StudentDTO> GetListStudents()
        {
            var lstStudents = studenService.GetListOfStudent();
            return lstStudents;
        }


        public StudentListAssigmentsDTO GetStudent(string id)
        {
            var student = studenService.GetStudent(Guid.Parse(id));
            return student;
        }


        public void DeleteStudent(string Id)
        {
            var student = studenService.DeleteStudent(Id);
        }
        #endregion

        #region Assigments

        public void CreateAssigment(string Name )
        {
            var assigment = assigmentService.CreateAssigment(Name);
        }

        public void EditAssigment(string id, string Name)
        {
            var assigment = assigmentService.UpdateAssigment(id, Name);
        }

        public List<AssigmentDTO> GetListAssigment()
        {
            var lstAssigment = assigmentService.GetListOfAssigments();
            return lstAssigment;
        }


        public AssigmentListStudentsDTO GetAssigment(string id)
        {
            var assigment = assigmentService.GetAssigment(Guid.Parse(id));
            return assigment;
        }


        public void DeleteAssigment(string Id)
        {
            var student = assigmentService.DeleteAssigment(Id);
        }
        #endregion


        #region StudentAssigment

        public StudentAssigmentDTO CreateStudentAssigment(string IdAssigment, string IdStudent)
        {
            var assigment = studentAssigmentService.CreateStudentAssigment(Guid.Parse(IdStudent), Guid.Parse(IdAssigment));
            return assigment;
        }

        public StudenAssigmenDetailDTO GetStudentAssigment(string IdAssigment, string IdStudent)
        {
            var assigment = studentAssigmentService.GetStudentAssigment(IdStudent, IdAssigment);
            return assigment;
        }

        public void DeleteStudentAssigment(string IdAssigment, string IdStudent)
        {
          studentAssigmentService.DeleteStudentAssigment(IdStudent, IdAssigment);
        }

        #endregion

    }
}
