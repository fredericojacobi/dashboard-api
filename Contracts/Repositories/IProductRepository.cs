using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts.Repositories
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        Task<IList<Product>> ReadAllProductsAsync();
        Task<Product> ReadProductAsync(Guid id);
        Task<IList<Product>> ReadProductsByQuantityAsync(int quantity);
        Task<Product> CreateProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(Product product);
    }
}