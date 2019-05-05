namespace CQRS.Logic.Core.Commands
{
    public sealed class RegisterStudentCommand : ICommand
    {
        public string Name { get; }
        public int Age { get; }
        public string Address { get; }
        public RegisterStudentCommand(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
    }
}
