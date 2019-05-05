using System.Collections.Generic;

namespace CQRS.Logic.Infrastructure.Repositores
{
    public interface IQueryRepository<T>
    {
        IEnumerable<T> All();
        T Find(int id);
        IEnumerable<T> FindById(int id);
    }
}
