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
    public class TeamRepository : RepositoryBase<Team>, ITeamRepository
    {

        public TeamRepository(DashboardContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Team>> ReadAllTeamsAsync() => await ReadAllAsync();

        public async Task<Team> ReadTeamAsync(Guid id)
        {
            var result = await ReadByConditionAsync(x =>
                x.Id.Equals(id),
                x => x.Vehicle);
            return result.FirstOrDefault();
        }

        public async Task<IList<Team>> ReadTeamsByQuantityAsync(int quantity) => await ReadByQuantityAsync(quantity);

        public async Task<Team> CreateTeamAsync(Team team)
        {
            team.CreatedAt = DateTime.Now;
            return await CreateAsync(team);
        }

        public async Task<Team> UpdateTeamAsync(Team team)
        {
            team.ModifiedAt = DateTime.Now;
            return await UpdateAsync(team.Id, team);
        }

        public async Task<bool> DeleteTeamAsync(Team team) => await DeleteAsync(team);
    }
}