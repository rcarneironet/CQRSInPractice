using CQRS.Logic.DTOs;
using CQRS.Logic.Entities;
using CQRS.Logic.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.API.Controllers
{
    [Route("api/[Controller]")]
    public class StudentController : Controller
    {
        readonly IStudentService _service;
        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Insert([FromBody] StudentDto dto)
        {
            if (string.IsNullOrEmpty(dto?.Name))
                return BadRequest("Error: Missing student name.");

            if (dto?.Age <= 0)
                return BadRequest("Error: Student age must be higher than zero.");

            if (string.IsNullOrEmpty(dto?.Address))
                return BadRequest("Error: Student address cannot be empty");

            var student = new Student(dto.Name, dto.Age, dto.Address);

            var data = _service.Insert(student);
            return Created(nameof(Insert), data);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] StudentDto dto)
        {
            if (id <= 0)
                return BadRequest("Error: Incorrect ID. Must be higher than 0.");

            if (string.IsNullOrEmpty(dto?.Name))
                return BadRequest("Error: Missing student name.");

            if (dto?.Age <= 0)
                return BadRequest("Error: Student age must be higher than zero.");

            if (string.IsNullOrEmpty(dto?.Address))
                return BadRequest("Error: Student address cannot be empty");

            var student = new Student(dto.Name, dto.Age, dto.Address);
            student.ID = id;

            _service.Update(student);

            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Read([FromRoute] int id)
        {
            var data = _service.FindById(id);
            if (data == null)
            {
                return NotFound();
            }

            return Ok(data);
        }
    }
}