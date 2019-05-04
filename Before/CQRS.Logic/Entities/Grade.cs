using CQRS.Logic.DataAccess;

namespace CQRS.Logic.Entities
{
    public class Grade : BaseEntity
    {
        public string Name { get; private set; }
        public Grade()
        {

        }
        public Grade(string name)
        {
            Name = name;
        }
    }
}
