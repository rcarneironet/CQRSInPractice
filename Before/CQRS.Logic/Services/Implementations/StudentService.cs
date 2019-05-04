using CQRS.Logic.DataAccess;
using CQRS.Logic.Entities;
using CQRS.Logic.Services.Abstractions;
using System.Collections.Generic;

namespace CQRS.Logic.Services.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;
        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public void Delete(Student entity)
        {
            _repository.Delete(entity);
        }

        public Student FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Student Insert(Student entity)
        {
            return _repository.Insert(entity);
        }

        public IEnumerable<Student> List()
        {
            return _repository.List();
        }

        public void Update(Student entity)
        {
            _repository.Update(entity);
        }
    }
}
