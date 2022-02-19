using System;
using System.Collections.Generic;
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
            builder.Navigation(x => x.Team).AutoInclude();
            builder.HasData(new List<Vehicle>
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    IdentificationPlate = "AAA-123456",
                    CreatedAt = DateTime.Now.AddHours(4.3)
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    IdentificationPlate = "BBB-885774",
                    CreatedAt = DateTime.Now.AddHours(5.1)
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    IdentificationPlate = "CCC-953292",
                    CreatedAt = DateTime.Now.AddHours(6.2)
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    IdentificationPlate = "DDD-854821",
                    CreatedAt = DateTime.Now.AddHours(7.6)
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    IdentificationPlate = "EEE-757329",
                    CreatedAt = DateTime.Now.AddHours(9.4)
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    IdentificationPlate = "FFF-t85302",
                    CreatedAt = DateTime.Now.AddHours(3.7)
                }
            });

        }
    }
}