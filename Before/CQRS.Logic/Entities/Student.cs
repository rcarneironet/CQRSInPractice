using CQRS.Logic.DataAccess;

namespace CQRS.Logic.Entities
{
    public class Student : BaseEntity
    {
        public Student()
        {
        }

        public Student(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Address { get; private set; }
    }
}
