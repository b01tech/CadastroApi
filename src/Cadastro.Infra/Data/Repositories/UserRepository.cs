using Cadastro.Domain.Entities;
using Cadastro.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Infra.Data.Repositories;
public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task Create(User user)
    {
        await _context.users.AddAsync(user);
    }

}
