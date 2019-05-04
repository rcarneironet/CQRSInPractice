using CQRS.Logic.Entities;

namespace CQRS.Logic.DataAccess.Implementations
{
    public class GradeEnrollmentRepository
        : EfRepository<GradeEnrollment>, IGradeEnrollmentRepository
    {
        public GradeEnrollmentRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
