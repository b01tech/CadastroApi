namespace Cadastro.Domain.Entities;
public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreateAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
}
