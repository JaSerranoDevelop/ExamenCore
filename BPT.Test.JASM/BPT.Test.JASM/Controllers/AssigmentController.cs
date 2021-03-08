using BPT.Test.JASM.BackEnd.DataAccess;
using BPT.Test.JASM.Services;
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
    public class AssigmentController : ControllerBase
    {

        public DBContext _context;
        private AssigmentService assigmentService;

        public AssigmentController(DBContext dBContext)
        {
            _context = dBContext;
            assigmentService = new AssigmentService(_context);
        }

        // GET: api/<AssigmentController>
        [HttpGet]
        public ActionResult <List<AssigmentDTO>> Get()
        {
            var assigments = assigmentService.GetAssigments();
            return assigments;
        }

        // GET api/<AssigmentController>/5
        [HttpGet("{id}", Name = "GetAssigment")]
        public ActionResult<AssigmentDTO> Get (Guid id)
        {
            if (id == null)
                return NotFound();

            var assigment = assigmentService.GetAssigment(id);

            if (assigment == null)
                return NotFound();

            return assigment;
        }

        // POST api/<AssigmentController>
        [HttpPost]
        public ActionResult Post([FromBody] AssigmentDTO assigmentDTO)
        {
            var assigment = assigmentService.CreateAssigment(assigmentDTO);

            if (assigment == null)
                return NoContent();

            return new CreatedAtRouteResult("GetAssigment", new { id = assigment.Id }, assigment);
        }

        // PUT api/<AssigmentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] AssigmentDTO assigmentDTO)
        {
            if (id == null)
                return NotFound();

            if (assigmentDTO.Id != id)
                return NotFound();

            var student = assigmentService.EditAssigment(assigmentDTO);

            if (student == null)
                return NoContent();

            return new CreatedAtRouteResult("GetStudent", new { id = student.Id }, student);
        }

        // DELETE api/<AssigmentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            if (id == null)
                return NotFound();

            assigmentService.DeleteAssigment(id);
            return Ok();
        }
    }
}
