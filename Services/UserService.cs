using System;
using System.Threading.Tasks;
using Contracts.Repositories;
using Contracts.Services;
using Entities.Models;
using Generics.Entities;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IRepositoryWrapper _repository;

        public UserService(IRepositoryWrapper repository) => _repository = repository;
        
        public async Task<RequestData<User>> ReadAllUsersAsync() 
        {
            try
            {
                var users = await _repository.User.ReadAllUsersAsync();
                return new RequestData<User>(users);
            }
            catch (Exception e)
            {
                return new RequestData<User>(e);
            }
        }

        public async Task<RequestData<User>> ReadUserAsync(string userName)
        {
            try
            {
                var user = await _repository.User.ReadUserAsync(userName);
                return new RequestData<User>(user);
            }
            catch (Exception e)
            {
                return new RequestData<User>(e);
            }
        }

        public async Task<RequestData<User>> CreateUserAsync(User user)
        {
            var requestData = new RequestData<User>();
            
            try
            {
                var checkUser = await ReadUserAsync(user.UserName);
                if (checkUser.Result)
                {
                    requestData.Message = "This user already exist!";
                    return requestData;
                }
                var newUser = await _repository.User.CreateUserAsync(user);
                return new RequestData<User>(newUser);
            }
            catch (Exception e)
            {
                return new RequestData<User>(e);
            }
        }
    }
}