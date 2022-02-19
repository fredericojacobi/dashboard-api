using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.Repositories;
using Entities.Context;
using Entities.Models;

namespace Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DashboardContext context) : base(context)
        {
        }

        public async Task<IList<Product>> ReadAllProductsAsync() => await ReadAllAsync();

        public async Task<Product> ReadProductAsync(Guid id)
        {
            var result = await ReadByConditionAsync(x =>
                x.Id.Equals(id));
            return result.FirstOrDefault();
        }

        public Task<IList<Product>> ReadProductsByQuantityAsync(int quantity) => ReadByQuantityAsync(quantity);

        public async Task<Product> CreateProductAsync(Product product)
        {
            product.CreatedAt = DateTime.Now;
            return await CreateAsync(product);
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            product.ModifiedAt = DateTime.Now;
            return await UpdateAsync(product.Id, product);
        }

        public async Task<bool> DeleteProductAsync(Product product) => await DeleteAsync(product);
    }
}