using System;
using System.Collections.Generic;
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
            builder.HasOne(x => x.Vehicle).WithOne(x => x.Team).HasForeignKey<Vehicle>(x => x.TeamId);
            builder.HasData(new List<Team>
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Time de recrutamento e seleção",
                    Description = "Colaboradores com principais atribuições relativas a recrutamento e seleção de candidatos.",
                    CreatedAt = DateTime.Now.AddHours(10)
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Time de estagiários em recrutamento e seleção",
                    Description = "Colaboradores com principais atribuições relativas a recrutamento e seleção de candidatos. Time de estagiários.",
                    CreatedAt = DateTime.Now.AddHours(11)
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Time de desenvolvimento front-end",
                    Description = "Colaboradores com principais atribuições relativas a desenvolvimento de front-end.",
                    CreatedAt = DateTime.Now.AddHours(12)
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Time de estagiários em desenvolvimento front-end",
                    Description = "Colaboradores com principais atribuições relativas a recrutamento e seleção de candidatos. Time de estagiários.",
                    CreatedAt = DateTime.Now.AddHours(13)
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Gerentes",
                    Description = "Colaboradores com cargo de gerência.",
                    CreatedAt = DateTime.Now.AddHours(72)
                }
            });
        }
    }
}