using System;

namespace BPT.Test.JASM.FrontEnd.Client
{
    class Program
    {
        static void Main(string[] args)
        {

            var manager = new ManagerFrontEndClient();

            #region Student
            //List 
            //var students = manager.GetListStudents();

            //Console.WriteLine("List of Students");
            //Console.WriteLine("**************************************************");
            //foreach (var student in students)
            //{

            //    Console.WriteLine($"Student Id: {student.Id}");
            //    Console.WriteLine($"Student Name: {student.Name}");
            //    Console.WriteLine($"Student day of birth: {student.DateBirth}");
            //    Console.WriteLine("**************************************************");

            //}

            //Get student
            //var id = "114128A1-EDD6-470D-AFB7-E5B857AEE411"; //Change this id
            //var student = manager.GetStudent(id);
            //Console.WriteLine($"Assigment Name {student.StudentName} ");
            //Console.WriteLine("**************************************************");
            //Console.WriteLine("Student assignment list ");
            //Console.WriteLine("**************************************************");
            //foreach (var assigment in student.ListAssigments)
            //{

            //    Console.WriteLine($"Assigment Id: {assigment.Id}");
            //    Console.WriteLine($"Assigment Name: {assigment.Name}");
            //    Console.WriteLine("**************************************************");

            //}


            //Create 
            //var studentName = "Alan";
            //var studentBrithDay =  DateTime.Parse( "1998-11-14");
            //manager.CreateStudent(studentName, studentBrithDay);
            //Console.WriteLine($"Successfully created student  [{studentName}]");

            //Edit
            //var id = "31976E9E-2940-48F5-8E1D-936C023246A0"; //Change this id
            //var studentName = "Alan Garrido Mercado";
            //var studentBrithDay = DateTime.Parse("1998-11-14");
            //manager.EditStudent(id, studentName, studentBrithDay);
            //Console.WriteLine($"Successfully updated student  [{studentName}]");

            //Delete
            //var id = "31976E9E-2940-48F5-8E1D-936C023246A0"; //Change this id
            //manager.DeleteStudent(id);
            //Console.WriteLine($"Successfully erased student ");

            #endregion

            #region Assigments

            //List 
            //var assigments = manager.GetListAssigment();

            //Console.WriteLine("List of Assigments");
            //Console.WriteLine("**************************************************");
            //foreach (var assigment in assigments)
            //{

            //    Console.WriteLine($"Assigment Id: {assigment.Id}");
            //    Console.WriteLine($"Assigment Name: {assigment.Name}");
            //    Console.WriteLine("**************************************************");

            //}

            //GET Assigment 
            //var id = "266324D6-C255-4C47-8D08-4FECD44DB334"; //Change this id
            //var assigment = manager.GetAssigment(id);

            //Console.WriteLine($"Assigment Name {assigment.AssigmentName} ");
            //Console.WriteLine("**************************************************");
            //Console.WriteLine("Student assignment list ");
            //Console.WriteLine("**************************************************");
            //foreach (var student in assigment.ListStudents)
            //{

            //    Console.WriteLine($"Assigment Id: {student.Id}");
            //    Console.WriteLine($"Student Name: {student.Name}");
            //    Console.WriteLine("**************************************************");

            //}

            //Create 
            //var assigmentName = "Historia Universal";
            //manager.CreateAssigment(assigmentName);
            //Console.WriteLine($"Successfully created assigment  [{assigmentName}]");


            //Edit
            //var id = "0C956B5D-C2C5-4738-8011-87F40642DE7E"; //Change this id
            //var assigmentName = "Historia Mexico";
            //manager.EditAssigment(id, assigmentName);
            //Console.WriteLine($"Successfully updated assigment  [{assigmentName}]");

            //var id = "0C956B5D-C2C5-4738-8011-87F40642DE7E"; //Change this id
            //manager.DeleteAssigment(id);
            //Console.WriteLine($"Successfully erased assigment");


            #endregion

            #region StudentAssigment

            //Assigment 
            //var idStudent = "114128A1-EDD6-470D-AFB7-E5B857AEE411"; //Change this id
            //var idAssigment = "9397A01C-DFA7-4B7D-B65F-05967EA4E6D9"; //Change this id

            //Detail 
            //var studentAssigment = manager.GetStudentAssigment(idAssigment, idStudent);
            //Console.WriteLine($"Assigment Name: {studentAssigment.AssigmentName}");
            //Console.WriteLine($"Student Name: {studentAssigment.StudentName}");


            //CreateAssigment 
            //var studentAssigment = manager.CreateStudentAssigment(idAssigment, idStudent);
            //Console.WriteLine($"Successfully created assigment to student");


            //Delete 
            // manager.DeleteStudentAssigment(idAssigment, idStudent);
            //Console.WriteLine($"Assigment-Student delete");



            #endregion

        }
    }
}
