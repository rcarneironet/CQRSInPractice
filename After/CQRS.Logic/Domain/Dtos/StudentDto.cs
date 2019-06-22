namespace CQRS.Logic.Domain.Dtos
{
    public class StudentDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    public class RegisterStudentDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    public class EnrollStudentDto
    {
        public int ID { get; set; }
        public int CourseId { get; set; }
    }
}
