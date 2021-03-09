using BPT.Test.JASM.BackEnd.DataAccess;
using BPT.Test.JASM.DTO;
using BPT.Test.JASM.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BPT.Test.JASM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAssigmentController : ControllerBase
    {
        public DBContext _context;
        public StudentAssigmentService studentAssigmentService;

        public StudentAssigmentController(DBContext dBContext)
        {
            _context = dBContext;
            studentAssigmentService = new StudentAssigmentService(_context);
        }


        // GET: api/<StudentAssigmentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StudentAssigmentController>/5
        [HttpGet("{IdStudent}/{IdAssigment}", Name = "GetStudentAssigment")]
        public ActionResult <StudenAssigmenDetailDTO> Get(Guid IdStudent, Guid IdAssigment)
        {
            if (IdStudent == Guid.Empty && IdAssigment == Guid.Empty )
                return NotFound();

            var studenAssigmentDTO = studentAssigmentService.GetStudentAssigment(IdStudent, IdAssigment);

            if (studenAssigmentDTO == null)
                return NoContent();

            return studenAssigmentDTO;

        }



        // POST api/<StudentAssigmentController>
        [HttpPost]
        public ActionResult Post([FromBody] StudentAssigmentDTO studentAssigmentDTO)
        {
            var studentAssigment = studentAssigmentService.CreateStudentAssigment(studentAssigmentDTO);

            if (studentAssigment == null)
                return NoContent();

            return new CreatedAtRouteResult("GetStudentAssigment", new { IdStudent = studentAssigment.IdStudent, IdAssigment = studentAssigment.IdAssignments});

        }

      
        // DELETE api/<StudentAssigmentController>/5
        [HttpDelete("{IdStudent}/{IdAssigment}")]
        public ActionResult Delete(Guid IdStudent, Guid IdAssigment)
        {
            if (IdStudent == Guid.Empty && IdAssigment == Guid.Empty)
                return NotFound();

            studentAssigmentService.DeteleStudentAssigment(IdStudent, IdAssigment);
            return Ok();
        }
    }
}
