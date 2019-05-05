using CQRS.Logic.Domain.Dtos;
using CQRS.Logic.Domain.Entities;

namespace CQRS.Logic.Infrastructure.Repositores.Commands
{
    public interface IStudentCommandRepository : ICommandRepository<Student>
    {
        void RegisterStudent(RegisterStudentDto student);
    }
}
