using AcademiaLPL.Domain.Entities;
using FluentValidation;

namespace AcademiaLPL.Service.Validators
{
    public class ModalidadeValidator : AbstractValidator<Modalidade>
    {
        public ModalidadeValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
            //.Length(50).WithMessage("Nome pode ter no máximo 50 caractreres.");

            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Por favor informe a descrição.")
                .NotNull().WithMessage("Por favor informe a descrição.");

            RuleFor(c => c.Precomensal)
                .NotEmpty().WithMessage("Por favor informe o preço.")
                .NotNull().WithMessage("Por favor informe o preço.");
        }
    }
}
