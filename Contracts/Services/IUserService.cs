using System.Threading.Tasks;
using Entities.Models;
using Generics.Entities;

namespace Contracts.Services
{
    public interface IUserService
    {
        Task<RequestData<User>> ReadAllUsersAsync();
        Task<RequestData<User>> ReadUserAsync(string userName);
        Task<RequestData<User>> CreateUserAsync(User user);
    }
}