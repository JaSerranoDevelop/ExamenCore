using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPT.Test.JASM.BackEnd.DataAccess;
using BPT.Test.JASM.DTO;
using AutoMapper;

namespace BPT.Test.JASM
{
    public class StudentService
    {
        private DBContext _context { get; }
        public StudentService(DBContext context)
        {
            _context = context;
        }


        public List<StudentDTO> GetStudents ()
        {
            var students = _context.Students.AsQueryable();
            var studentsDto = Mapper.Map<List<StudentDTO>>(students);
            return studentsDto;
        }

        public StudentDTO GetStudent(Guid id)
        {
            var student = _context.Students.Where(a => a.Id == id).FirstOrDefault();
            var studenDto = Mapper.Map<StudentDTO>(student);
            return studenDto;
        }

        public Student CreateStudent(StudentDTO studenDTO)
        {
            try
            {
                var student = Mapper.Map<Student>(studenDTO);
                student.Id = Guid.NewGuid();

                _context.Add(student);
                _context.SaveChanges();

                return student;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public Student EditStudent(StudentDTO studenDTO)
        {
            try
            {

               var student = _context.Students.Where(a => a.Id == studenDTO.Id).FirstOrDefault();

                if (student == null)
                    return null;


                student.Name = studenDTO.Name;
                student.DateBirth = studenDTO.DateBirth;

                _context.Update(student);
                _context.SaveChanges();

                return student;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteStudent(Guid id)
        {
            try
            {
                var student = _context.Students.Where(a => a.Id == id).FirstOrDefault();

                _context.Remove(student);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
