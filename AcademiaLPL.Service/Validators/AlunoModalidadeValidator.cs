using AcademiaLPL.Domain.Entities;
using FluentValidation;

namespace AcademiaLPL.Service.Validators
{
    public class AlunoModalidadeValidator : AbstractValidator<AlunoModalidade>
    {
        public AlunoModalidadeValidator()
        {
            RuleFor(c => c.DataInicio)
                .NotEmpty().WithMessage("Por favor informe a data de inicio.")
                .NotNull().WithMessage("Por favor informe a data de inicio.");
        }
    }
}
