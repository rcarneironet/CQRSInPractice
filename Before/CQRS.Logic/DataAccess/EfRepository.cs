using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CQRS.Logic.DataAccess
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationContext _dbContext;
        public EfRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public T Insert(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
        public void Delete(T entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

        public T FindById(int id)
        {
            return _dbContext.Set<T>()
                           .AsNoTracking()
                           .FirstOrDefault(x => x.ID == id);
        }
        public IEnumerable<T> List()
        {
            return _dbContext.Set<T>()
                .AsEnumerable();
        }


    }
}
