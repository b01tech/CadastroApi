using Cadastro.Domain.Entities.Enums;
namespace Cadastro.API.DTOs.Requests;

public class UserCreateRequestJson
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string AreaCode { get; set; } = string.Empty;
    public AccessLevel AccessLevel { get; set; }
}
