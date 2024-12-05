using Cadastro.API.DTOs.Requests;
using Cadastro.API.DTOs.Responses;

namespace Cadastro.Application.UseCase.User;
public class UserCreateUseCase
{
    public UserCreateResponseJson Execute(UserCreateRequestJson request)
    {
        Validate(request);

        return new UserCreateResponseJson
        {
            Name = request.Name
        };

        //valida
        //criptografa
        //mapeia
        //retorna
    }

    private void Validate(UserCreateRequestJson request)
    {
        var validator = new UserCreateValidator();
        var result = validator.Validate(request);
        if (result.IsValid == false)
        {
            throw new System.Exception();
        }

    }
}
