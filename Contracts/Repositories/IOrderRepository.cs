using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts.Repositories
{
    public interface IOrderRepository : IRepositoryBase<Order>
    {
        Task<IList<Order>> ReadAllOrdersAsync();
        Task<Order> ReadOrderAsync(Guid id);
        Task<Order> CreateOrderAsync(Order order);
        Task<bool> CreateMultipleOrdersAsync(IList<Order> orders);
        Task<Order> UpdateOrderAsync(Order order);
        Task<bool> DeleteOrderAsync(Order order);
    }
}