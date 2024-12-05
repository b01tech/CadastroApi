using Cadastro.API.DTOs.Requests;
using FluentValidation;
using Cadastro.Exception.ExceptionMessages;

namespace Cadastro.Application.UseCase.User;

public class UserCreateValidator : AbstractValidator<UserCreateRequestJson>
{
    public UserCreateValidator()
    {
        RuleFor(_ => _.Name)
            .NotEmpty().WithMessage(ExceptionMessages.NAME_EMPTY)
            .MaximumLength(100).WithMessage(ExceptionMessages.NAME_SIZE);

        RuleFor(_ => _.Email)
            .NotEmpty().WithMessage(ExceptionMessages.EMAIL_EMPTY)
            .EmailAddress().WithMessage(ExceptionMessages.EMAIL_INVALID);

        RuleFor(_ => _.Password)
            .NotEmpty().WithMessage(ExceptionMessages.PASSWORD_EMPTY)
            .MinimumLength(6).WithMessage(ExceptionMessages.PASSWORD_SIZE);

        RuleFor(_ => _.PhoneNumber)
            .NotEmpty().WithMessage(ExceptionMessages.PHONE_EMPTY)
            .Matches(@"^\d{8,9}$").WithMessage(ExceptionMessages.PHONE_INVALID);

        RuleFor(_ => _.AreaCode)
            .NotEmpty().WithMessage(ExceptionMessages.AREACODE_EMPTY)
            .Length(2).WithMessage(ExceptionMessages.AREACODE_LENGHT)
            .Must(_ => int.TryParse(_, out int result) && result >= 11 && result <= 99)
                .WithMessage(ExceptionMessages.AREACODE_INVALID);
            
    }
}
