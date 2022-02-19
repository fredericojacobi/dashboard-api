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
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {

        public AddressRepository(DashboardContext context) : base(context)
        {
        }

        public async Task<IList<Address>> ReadAllAddressesAsync() => await ReadAllAsync();

        public async Task<IList<Address>> ReadAddressesByQuantityAsync(int quantity) => await ReadByQuantityAsync(quantity);

        public async Task<Address> ReadAddressAsync(Guid id)
        {
            var result = await ReadByConditionAsync(x => x.Id.Equals(id));
            return result.FirstOrDefault();
        }

        public async Task<Address> CreateAddressAsync(Address address)
        {
            address.CreatedAt = DateTime.Now;
            return await CreateAsync(address);
        }

        public async Task<Address> UpdateAddressAsync(Address address)
        {
            address.ModifiedAt = DateTime.Now;
            return await UpdateAsync(address.Id, address);
        }

        public async Task<bool> DeleteAddressAsync(Address address) => await DeleteAsync(address);
    }
}