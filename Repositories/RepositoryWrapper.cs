using Contracts.Repositories;
using Entities.Context;

namespace Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly DashboardContext _context;

        private IAddressRepository _address;
        private IOrderRepository _order;
        private IOrderProductRepository _orderProduct;
        private IProductRepository _product;
        private ITeamRepository _team;
        private IUserRepository _user;
        private IVehicleRepository _vehicle;
        
        public RepositoryWrapper(DashboardContext context) => _context = context;

        public IAddressRepository Address => _address ??= new AddressRepository(_context);
        public IOrderRepository Order => _order ??= new OrderRepository(_context);
        public IOrderProductRepository OrderProduct => _orderProduct ??= new OrderProductRepository(_context);
        public IProductRepository Product => _product ??= new ProductRepository(_context);
        public ITeamRepository Team => _team ??= new TeamRepository(_context);
        public IUserRepository User => _user ??= new UserRepository(_context);
        public IVehicleRepository Vehicle => _vehicle ??= new VehicleRepository(_context);
    }
}