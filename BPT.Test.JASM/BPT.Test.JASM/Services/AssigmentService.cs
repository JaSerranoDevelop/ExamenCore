using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPT.Test.JASM.BackEnd.DataAccess;
using BPT.Test.JASM.DTO;
using AutoMapper;

namespace BPT.Test.JASM.Services
{
    public class AssigmentService
    {
        private DBContext _context { get; }

        public AssigmentService(DBContext context)
        {
            _context = context;
        }

        public List<AssigmentDTO> GetAssigments()
        {
            var assigments = _context.Assignments.AsQueryable();
            var assigmentsDto = Mapper.Map<List<AssigmentDTO>>(assigments);
            return assigmentsDto;
        }

        public AssigmentDTO GetAssigment(Guid id)
        {
            var assigment = _context.Assignments.Where(a => a.Id == id).FirstOrDefault();
            var assigmentDto = Mapper.Map<AssigmentDTO>(assigment);
            return assigmentDto;
        }

        public Assignments CreateAssigment(AssigmentDTO studenDTO)
        {
            try
            {
                var assigment = Mapper.Map<Assignments>(studenDTO);
                assigment.Id = Guid.NewGuid();

                _context.Add(assigment);
                _context.SaveChanges();

                return assigment;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Assignments EditAssigment(AssigmentDTO assigmentsDto)
        {
            try
            {

                var assigment = _context.Assignments.Where(a => a.Id == assigmentsDto.Id).FirstOrDefault();

                if (assigment == null)
                    return null;


                assigment.Name = assigmentsDto.Name;
              
                _context.Update(assigment);
                _context.SaveChanges();

                return assigment;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteAssigment(Guid id)
        {
            try
            {
                var assigment = _context.Assignments.Where(a => a.Id == id).FirstOrDefault();

                _context.Remove(assigment);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
