using Cliente.Domain.Entities;
using FluentValidation;

namespace Cliente.Service.Validators
{
    public class ClienteValidator : AbstractValidator<Client>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Por favor preencha o nome.")
                .NotNull().WithMessage("Por favor preencha o nome.")
                .Length(1, 100);

            RuleFor(c => c.CPF)
                .NotEmpty().WithMessage("Por favor preencha o CPF.")
                .NotNull().WithMessage("Por favor preencha o CPF.")
                .Length(1, 100);

            RuleFor(c => c.Sex)
                .NotEmpty().WithMessage("Por favor preencha o Sexo.")
                .NotNull().WithMessage("Por favor preencha o Sexo.")
                .Length(1, 100);

            RuleFor(c => c.Telephone)
                .NotEmpty().WithMessage("Por favor preencha o Telefone.")
                .NotNull().WithMessage("Por favor preencha o Telefone.")
                .Length(1, 100);

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Por favor preencha o Email.")
                .NotNull().WithMessage("Por favor preencha o Email.")
                .Length(1, 100)
                .EmailAddress();

            RuleFor(c => c.BirthDate)
                .NotEmpty().WithMessage("Por favor preencha a Data de Nascimento.")
                .NotNull().WithMessage("Por favor preencha a Data de Nascimento.")
                .GreaterThan(new DateTime());
        }
    }
}
