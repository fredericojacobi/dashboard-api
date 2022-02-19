using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts.Repositories
{
    public interface IAddressRepository : IRepositoryBase<Address>
    {
        Task<IList<Address>> ReadAllAddressesAsync();
        Task<IList<Address>> ReadAddressesByQuantityAsync(int quantity);
        Task<Address> ReadAddressAsync(Guid id);
        Task<Address> CreateAddressAsync(Address address);
        Task<Address> UpdateAddressAsync(Address address);
        Task<bool> DeleteAddressAsync(Address address);
    }
}