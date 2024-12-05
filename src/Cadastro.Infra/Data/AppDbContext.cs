using Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Infra.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<User> users { get; set; }

}
