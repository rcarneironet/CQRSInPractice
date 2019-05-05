using System;

namespace CQRS.Logic.Infrastructure.Repositores
{
    public interface IUnitOfWork : IDisposable
    {
        //ICompanyQueryRepository CompanyQueryRepository { get; }
        void Commit();
        void Rollback();
    }
}
