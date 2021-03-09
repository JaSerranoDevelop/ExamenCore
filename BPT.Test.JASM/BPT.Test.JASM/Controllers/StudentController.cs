using BPT.Test.JASM.BackEnd.DataAccess;
using BPT.Test.JASM.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BPT.Test.JASM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        public DBContext _context;
        private StudentService studentService;


        public StudentController(DBContext dBContext)
        {
            _context = dBContext;
            studentService = new StudentService(_context);

        }

        // GET: api/<StudenController>
        [HttpGet]
        public ActionResult<List<StudentDTO>> Get()
        {
            var students = studentService.GetStudents();
            return students;
        }

        // GET api/<StudenController>/5
        [HttpGet("{id}", Name = "GetStudent")]
        public ActionResult<StudentListAssigmentsDTO> Get(Guid id)
        {
           if (id == null)
                return NotFound();

            var student = studentService.GetStudent(id);

            if (student == null)
                return NotFound();

            return student;
        }

        // POST api/<StudenController>
        [HttpPost]
        public ActionResult Post([FromBody] StudentDTO studentDTO)
        {
            var student = studentService.CreateStudent(studentDTO);

            if (student == null)
                return NoContent();

            return new CreatedAtRouteResult("GetStudent", new { id = student.Id}, student);


        }

        // PUT api/<StudenController>/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] StudentDTO studentDTO)
        {
            if (id == null)
                return NotFound();

            if (studentDTO.Id != id)
                return NotFound();

            var student = studentService.EditStudent(studentDTO);

            if (student == null)
                return NoContent();

            return new CreatedAtRouteResult("GetStudent", new { id = student.Id }, student);
        }

        // DELETE api/<StudenController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            if (id == null)
                return NotFound();

            studentService.DeleteStudent(id);
            return Ok();

        }
    }
}
