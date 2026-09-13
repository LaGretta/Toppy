using Toppy.Domain.Entities.Users;

namespace Toppy.Application.Interfaces.Repository;

public interface IUserRepository
{
    Task<User?>  GetUserByEmailAsync(string email ,CancellationToken ct);
    Task<User?> GetUserByIdAsync(int id, CancellationToken ct);
    Task<List<User>> SearchAsync(string query,int limit ,CancellationToken ct);
}