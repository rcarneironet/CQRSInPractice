using CQRS.Logic.Entities;
using System.Collections.Generic;

namespace CQRS.Logic.Services.Abstractions
{
    public interface IStudentService
    {
        Student Insert(Student entity);
        void Update(Student entity);
        void Delete(Student entity);
        Student FindById(int id);
        IEnumerable<Student> List();
    }
}
