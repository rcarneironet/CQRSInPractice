using CQRS.Logic.Core.Commands;
using CQRS.Logic.Core.Utils;
using CQRS.Logic.Core.Validators;
using CQRS.Logic.Domain.Dtos;
using CQRS.Logic.Infrastructure.Dapper;
using CSharpFunctionalExtensions;

namespace CQRS.Logic.Core.Handlers
{
    public sealed class RegisterCommandStudentHandler : ICommandHandler<RegisterStudentCommand>
    {
        readonly CommandsConnectionString _connectionString;
        public RegisterCommandStudentHandler(CommandsConnectionString connectionString)
        {
            _connectionString = connectionString;
        }
        public Result Handle(RegisterStudentCommand command)
        {
            var validator = new RegisterStudentValidator();
            var result = validator.Validate(command);

            if (!result.IsValid)
                return Result.Fail($"Business Error: '{ result.Errors[0].ErrorMessage }'");

            var student = new RegisterStudentDto()
            {
                Name = command.Name,
                Age = command.Age,
                Address = command.Address
            };

            using (var UoW = new UnitOfWork(_connectionString.Value))
            {
                UoW.StudentCommandRepository.RegisterStudent(student);
                UoW.Commit();
            }

            return Result.Ok();

        }
    }
}
