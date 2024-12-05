using Cadastro.Domain.Entities;

namespace Cadastro.Domain.Repositories;
public interface IUserRepository
{
    Task Create(User user);

}
