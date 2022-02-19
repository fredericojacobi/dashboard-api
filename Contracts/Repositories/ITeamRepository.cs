using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts.Repositories
{
    public interface ITeamRepository : IRepositoryBase<Team>
    {
        Task<IEnumerable<Team>> ReadAllTeamsAsync();
        Task<Team> ReadTeamAsync(Guid id);
        Task<IList<Team>> ReadTeamsByQuantityAsync(int quantity);
        Task<Team> CreateTeamAsync(Team team);
        Task<Team> UpdateTeamAsync(Team team);
        Task<bool> DeleteTeamAsync(Team team);
    }
}