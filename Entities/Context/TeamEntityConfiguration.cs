using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Context
{
    public class TeamEntityConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.Property<Guid>("Id").ValueGeneratedOnAdd();
            builder.Property<Guid?>("VehicleId");
            builder.Property<string>("Name");
            builder.Property<string>("Description");
            builder.Property<DateTime>("CreatedAt")
                .ValueGeneratedOnAdd();
            builder.Property<DateTime>("ModifiedAt")
                .ValueGeneratedOnUpdate();
            builder.HasMany(x => x.Packages)
                .WithOne(x => x.Team)
                .HasForeignKey(x => x.TeamId);
            builder.HasOne(x => x.Vehicle).WithOne(x => x.Team).HasForeignKey<Vehicle>(x => x.TeamId);
        }
    }
}