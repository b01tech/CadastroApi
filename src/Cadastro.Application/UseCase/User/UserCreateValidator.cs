using Cadastro.API.DTOs.Requests;
using FluentValidation;

namespace Cadastro.Application.UseCase.User;
public class UserCreateValidator : AbstractValidator<UserCreateRequestJson>
{
    public UserCreateValidator()
    {
        RuleFor(_ => _.Name)
            .NotEmpty().WithMessage("")
            .MaximumLength(100).WithMessage("");

        RuleFor(_ => _.Email)
            .NotEmpty().WithMessage("")
            .EmailAddress().WithMessage("");

        RuleFor(_ => _.Password)
            .NotEmpty().WithMessage("")
            .MinimumLength(6).WithMessage("");

        RuleFor(_ => _.PhoneNumber)
            .NotEmpty().WithMessage("")
            .Matches(@"^\d{8,9}$").WithMessage("");

        RuleFor(_ => _.AreaCode)
            .NotEmpty().WithMessage("")
            .Length(2).WithMessage("")
            .Must(_ => int.TryParse(_, out int result) && result >= 11 && result <= 99).WithMessage("");
            
    }
}
