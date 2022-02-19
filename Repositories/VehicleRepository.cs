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
    public class VehicleRepository : RepositoryBase<Vehicle>, IVehicleRepository
    {

        public VehicleRepository(DashboardContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Vehicle>> ReadAllVehiclesAsync() => await ReadAllAsync();

        public async Task<Vehicle> ReadVehicleAsync(Guid id)
        {
            var result = await ReadByConditionAsync(x =>
                    x.Id.Equals(id),
                x => x.Team);
            return result.FirstOrDefault();
        }

        public async Task<Vehicle> CreateVehicleAsync(Vehicle vehicle)
        {
            vehicle.CreatedAt = DateTime.Now;
            return await CreateAsync(vehicle);
        }

        public async Task<Vehicle> UpdateVehicleAsync(Vehicle vehicle)
        {
            vehicle.ModifiedAt = DateTime.Now;
            return await UpdateAsync(vehicle.Id, vehicle);
        }

        public async Task<bool> DeleteVehicleAsync(Vehicle vehicle) => await DeleteAsync(vehicle);
    }
}