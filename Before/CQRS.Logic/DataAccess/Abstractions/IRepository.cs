using System.Collections.Generic;

namespace CQRS.Logic.DataAccess
{
    public interface IRepository<T>
    {
        T Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        T FindById(int id);
        IEnumerable<T> List();
    }
}