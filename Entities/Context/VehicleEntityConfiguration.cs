using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Context
{
    public class VehicleEntityConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.Property<Guid>("Id").ValueGeneratedOnAdd();
            builder.Property<Guid?>("TeamId");
            builder.Property<string>("IdentificationPlate");
            builder.Property<string?>("Brand");
            builder.Property<string?>("Model");
            builder.Property<DateTime>("CreatedAt")
                .ValueGeneratedOnAdd();
            builder.Property<DateTime>("ModifiedAt")
                .ValueGeneratedOnUpdate();
            builder.HasOne(x => x.Team).WithOne(x => x.Vehicle).HasForeignKey<Team>(x => x.VehicleId);
            // builder.HasOne(x => x.Team).WithOne(x => x.Vehicle);
            //builder.HasOne(x => x.Team).WithOne(x => x.Vehicle).HasForeignKey("Team", "Id");

        }
    }
}