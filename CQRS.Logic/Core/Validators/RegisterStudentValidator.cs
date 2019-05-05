using CQRS.Logic.Core.Commands;
using FluentValidation;

namespace CQRS.Logic.Core.Validators
{
    public class RegisterStudentValidator : AbstractValidator<RegisterStudentCommand>
    {
        public RegisterStudentValidator()
        {
            RuleFor(r => r.Name)
              .NotEmpty()
              .WithMessage("Registering a student requires a name.");

            RuleFor(r => r.Age)
                .NotEmpty()
                .WithMessage("Registering a student requires an age.");

            RuleFor(r => r.Address)
                .NotEmpty()
                .WithMessage("Registering a student requires an address.");
        }
    }
}
