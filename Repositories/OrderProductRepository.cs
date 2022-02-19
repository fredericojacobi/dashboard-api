using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.Repositories;
using Entities.Context;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class OrderProductRepository : RepositoryBase<OrderProduct>, IOrderProductRepository
    {
        private readonly DashboardContext _context;

        public OrderProductRepository(DashboardContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IList<OrderProduct>> ReadAllOrderProductsAsync() => await ReadAllAsync();

        public async Task<IList<OrderProduct>> ReadOrderProductsByOrderIdAsync(Guid id)
        {
            return await _context.OrderProducts
                .Where(x => x.OrderId.Equals(id))
                .Select(x => new OrderProduct {Product = x.Product, ProductId = x.ProductId})
                .ToListAsync();
        }

        public async Task<OrderProduct> ReadOrderProductsAsync(Guid id)
        {
            var result = await ReadByConditionAsync(x =>
                    x.Id.Equals(id),
                x => x.Order,
                x => x.Product);
            return result.FirstOrDefault();
        }

        public async Task<OrderProduct> CreateOrderProductsAsync(OrderProduct orderProduct)
        {
            orderProduct.CreatedAt = DateTime.Now;
            return await CreateAsync(orderProduct);
        }

        public async Task<OrderProduct> UpdateOrderProductsAsync(OrderProduct orderProduct)
        {
            orderProduct.ModifiedAt = DateTime.Now;
            return await UpdateAsync(orderProduct.Id, orderProduct);
        }

        public async Task<bool> DeleteOrderProductsAsync(OrderProduct orderProduct) => await DeleteAsync(orderProduct);
    }
}