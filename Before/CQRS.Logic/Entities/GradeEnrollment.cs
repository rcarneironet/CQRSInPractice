using CQRS.Logic.DataAccess;

namespace CQRS.Logic.Entities
{
    public class GradeEnrollment : BaseEntity
    {
        public int StudentId { get; private set; }
        public int GradeId { get; private set; }

        public GradeEnrollment()
        {

        }
        public GradeEnrollment(int studentId, int gradeId)
        {
            StudentId = studentId;
            GradeId = gradeId;
        }
    }
}
