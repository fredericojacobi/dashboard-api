using Contracts.Repositories;
using Entities.Context;

namespace Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly DashboardContext _context;

        private IOrderRepository _order;

        public RepositoryWrapper(DashboardContext context) => _context = context;

        public IOrderRepository Order => _order ??= new OrderRepository(_context);
    }
}