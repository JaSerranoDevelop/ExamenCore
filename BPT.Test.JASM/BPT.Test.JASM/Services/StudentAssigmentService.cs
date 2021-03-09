using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPT.Test.JASM.BackEnd.DataAccess;
using BPT.Test.JASM.DTO;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace BPT.Test.JASM.Services
{
    public class StudentAssigmentService
    {
        private DBContext _context { get; }

        public StudentAssigmentService(DBContext context)
        {
            _context = context;
        }


        public StudenAssigmenDetailDTO GetStudentAssigment (Guid IdStudent, Guid IdAssigment)
        {
            try
            {
                var StudentAssigment = _context.StudenAssigments.Include(a => a.Assignments).Include(a => a.Student).Where(a => a.IdAssignments == IdAssigment && a.IdStudent == IdStudent).FirstOrDefault();
                return Mapper.Map<StudenAssigmenDetailDTO>(StudentAssigment);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public StudenAssigments CreateStudentAssigment(StudentAssigmentDTO studentAssigmentDTO)
        {
            try
            {
                var studentAssigment = new StudenAssigments();

                studentAssigment.IdAssignments = studentAssigmentDTO.IdAssignments;
                studentAssigment.IdStudent = studentAssigmentDTO.IdStudent;

                _context.Add(studentAssigment);
                _context.SaveChanges();

                return studentAssigment;
            }
            catch (Exception e)
            {

                throw;
            }
        }


        public void DeteleStudentAssigment (Guid IdStudent, Guid IdAssigment)
        {
            try
            {
                var studenAssigment = _context.StudenAssigments.Where(a => a.IdStudent == IdStudent && a.IdAssignments == IdAssigment).FirstOrDefault();

                _context.Remove(studenAssigment);
                _context.SaveChanges();
            }
            catch (Exception)
            {
               
            }
        }
    }
}
