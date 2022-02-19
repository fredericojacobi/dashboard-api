using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts.Repositories
{
    public interface IVehicleRepository : IRepositoryBase<Vehicle>
    {
        Task<IEnumerable<Vehicle>> ReadAllVehiclesAsync();
        Task<Vehicle> ReadVehicleAsync(Guid id);
        Task<Vehicle> CreateVehicleAsync(Vehicle vehicle);
        Task<Vehicle> UpdateVehicleAsync(Vehicle vehicle);
        Task<bool> DeleteVehicleAsync(Vehicle vehicle);
    }
}