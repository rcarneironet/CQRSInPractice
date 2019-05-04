using CQRS.Logic.Entities;

namespace CQRS.Logic.DataAccess.Implementations
{
    public class GradeRepository
        : EfRepository<Grade>, IGradeRepository
    {
        public GradeRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
