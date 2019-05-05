using System.Data;

namespace CQRS.Logic.Infrastructure.Dapper
{
    public abstract class DapperBaseRepository
    {
        protected IDbTransaction Transaction { get; private set; }
        protected IDbConnection Connection => Transaction.Connection;
        public DapperBaseRepository(IDbTransaction transaction)
        {
            Transaction = transaction;
        }
    }
}
