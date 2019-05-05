using CQRS.Logic.Domain.Dtos;
using CQRS.Logic.Infrastructure.Dapper;
using Dapper;
using System;
using System.Data;

namespace CQRS.Logic.Infrastructure.Repositores.Commands
{
    internal class StudentCommandRepository : DapperBaseRepository, IStudentCommandRepository
    {
        public StudentCommandRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void RegisterStudent(RegisterStudentDto student)
        {
            try
            {
                var id = Connection.ExecuteScalar<int>(
                @"INSERT INTO [dbo].[Students]
                       ([Name]
                       ,[Age]
                       ,[Address])
                 VALUES
                       (@Name
                       ,@Age
                       ,@Address);
                SELECT SCOPE_IDENTITY();",
                param: new
                {
                    Name = student.Name,
                    Age = student.Age,
                    Address = student.Address
                },
                transaction: Transaction);
            }
            catch (Exception)
            {
                //stop being lazy and implement log here
                throw;
            }
        }
    }
}
