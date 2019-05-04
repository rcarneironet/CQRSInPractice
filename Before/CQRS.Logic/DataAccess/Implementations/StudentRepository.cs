using CQRS.Logic.Entities;

namespace CQRS.Logic.DataAccess.Implementations
{
    public class StudentRepository : EfRepository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
