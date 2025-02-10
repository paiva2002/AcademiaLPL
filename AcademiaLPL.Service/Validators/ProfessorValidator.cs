using AcademiaLPL.Domain.Entities;
using FluentValidation;

namespace AcademiaLPL.Service.Validators
{
    public class ProfessorValidator : AbstractValidator<Professor>
    {
        public ProfessorValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");

            RuleFor(c => c.Telefone)
                .NotEmpty().WithMessage("Por favor informe o telefone.")
                .NotNull().WithMessage("Por favor informe o telefone.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Por favor informe o email.")
                .NotNull().WithMessage("Por favor informe o email.");

            RuleFor(c => c.Especialidade)
                .NotEmpty().WithMessage("Por favor informe a sua especialidade.")
                .NotNull().WithMessage("Por favor informe a sua especialidade.");

        }
    }
}
