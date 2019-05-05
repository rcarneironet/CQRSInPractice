using CSharpFunctionalExtensions;

namespace CQRS.Logic.Core
{
    public interface ICommand
    {
    }
    public interface ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        Result Handle(TCommand command);
    }
}
