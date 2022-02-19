using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> ReadAllUsersAsync();
        Task<User> ReadUserAsync(string userName);
        Task<User> CreateUserAsync(User user);
    }
}