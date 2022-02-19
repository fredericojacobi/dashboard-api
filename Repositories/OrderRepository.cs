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
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(DashboardContext context) : base(context)
        {
        }

        public async Task<IList<Order>> ReadAllOrdersAsync() => await ReadAllAsync(x => x.Address, x => x.Team);
        
        public async Task<Order> ReadOrderAsync(Guid id)
        {
            var result = await ReadByConditionAsync(x => 
                    x.Id.Equals(id),
                    x => x.Address);
            return result.FirstOrDefault();
        }

        public async Task<Order> CreateOrderAsync(Order order)
        {
            order.CreatedAt = DateTime.Now;
            return await CreateAsync(order);
        }

        public async Task<bool> CreateMultipleOrdersAsync(IList<Order> orders) => await CreateMultipleAsync(orders);

        public async Task<Order> UpdateOrderAsync(Order order)
        {
            order.ModifiedAt = DateTime.Now;
            return await UpdateAsync(order.Id, order);
        }

        public async Task<bool> DeleteOrderAsync(Order order) => await DeleteAsync(order);
    }
}