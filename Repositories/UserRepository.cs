using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.Repositories;
using Entities.Context;
using Entities.Models;
using Generics;

namespace Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DashboardContext context) : base(context)
        {
        }

        public async Task<IEnumerable<User>> ReadAllUsersAsync() => await ReadAllAsync();

        public async Task<User> ReadUserAsync(string userName)
        {
            var result = await ReadByConditionAsync(x =>
                x.UserName.Equals(userName));
            return result.FirstOrDefault();
        }

        public async Task<User> CreateUserAsync(User user)
        {
            user.CreatedAt = DateTime.Now;
            return await CreateAsync(user);
        }
    }
}