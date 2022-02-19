using AutoMapper;
using Contracts.Repositories;
using Contracts.Services;

namespace Services
{
    public class ServiceWrapper : IServiceWrapper
    {
        private readonly IRepositoryWrapper _repository;
        
        private IOrderService _order;
        private ITokenService _token;
        private IUserService _user;

        private readonly IMapper _mapper;
        
        public ServiceWrapper(IRepositoryWrapper repository, IMapper  mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public IOrderService Order => _order ??= new OrderService(_repository, _mapper);
        public ITokenService Token => _token ??= new TokenService();
        public IUserService User => _user ??= new UserService(_repository);
    }
}