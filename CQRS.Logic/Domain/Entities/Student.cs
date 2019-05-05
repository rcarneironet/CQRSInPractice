namespace CQRS.Logic.Domain.Entities
{
    public class Student : BaseEntity
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Address { get; set; }
        public Student(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

    }
}
