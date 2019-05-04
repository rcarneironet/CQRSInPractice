using CQRS.Logic.Entities;
using System.Collections.Generic;

namespace CQRS.Logic.Services.Abstractions
{
    public interface GradeEnrollmentService
    {
        GradeEnrollment Insert(GradeEnrollment entity);
        void Update(GradeEnrollment entity);
        void Delete(GradeEnrollment entity);
        GradeEnrollment FindById(int id);
        IEnumerable<GradeEnrollment> List();
    }
}
