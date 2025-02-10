using AcademiaLPL.Domain.Entities;
using FluentValidation;

namespace AcademiaLPL.Service.Validators
{
    public class AulaValidator : AbstractValidator<Aula>
    {
        public AulaValidator()
        {
            RuleFor(c => c.DiaSemana)
                .NotEmpty().WithMessage("Por favor informe o dia da semana.")
                .NotNull().WithMessage("Por favor informe o dia da semana.");

            RuleFor(c => c.HorarioInicio)
                .NotEmpty().WithMessage("Por favor informe o de inicio.")
                .NotNull().WithMessage("Por favor informe o de inicio.");

            RuleFor(c => c.HorarioFim)
                .NotEmpty().WithMessage("Por favor informe de finalização.")
                .NotNull().WithMessage("Por favor informe de finalização.");
        }
    }
}
