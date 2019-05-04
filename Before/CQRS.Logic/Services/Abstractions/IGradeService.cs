using CQRS.Logic.Entities;
using System.Collections.Generic;

namespace CQRS.Logic.Services.Abstractions
{
    public interface IGradeService
    {
        Grade Insert(Grade entity);
        void Update(Grade entity);
        void Delete(Grade entity);
        Grade FindById(int id);
        IEnumerable<Grade> List();
    }
}
