using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts.Repositories
{
    public interface IOrderProductRepository : IRepositoryBase<OrderProduct>
    {
        Task<IList<OrderProduct>> ReadAllOrderProductsAsync();
        Task<IList<OrderProduct>> ReadOrderProductsByOrderIdAsync(Guid id);
        Task<OrderProduct> ReadOrderProductsAsync(Guid id);
        Task<OrderProduct> CreateOrderProductsAsync(OrderProduct orderProducts);
        Task<OrderProduct> UpdateOrderProductsAsync(OrderProduct orderProducts);
        Task<bool> DeleteOrderProductsAsync(OrderProduct orderProducts);
    }
}