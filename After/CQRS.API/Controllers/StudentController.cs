using CQRS.Logic.Core.Commands;
using CQRS.Logic.Core.Utils;
using CQRS.Logic.Domain.Dtos;
using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.API.Controllers
{
    public class StudentController : BaseController
    {
        private readonly Messages _messages;
        public StudentController(Messages messages)
        {
            _messages = messages;
        }

        [HttpPost]
        public IActionResult RegisterStudent([FromBody] RegisterStudentDto dto)
        {
            var command = new RegisterStudentCommand(dto.Name, dto.Age, dto.Address);
            Result result = _messages.Dispatch(command);
            return FromResult(result);
        }
    }
}