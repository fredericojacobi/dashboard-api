using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Context
{
    public class AddressEntityConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property<Guid>("Id").ValueGeneratedOnAdd();
            builder.Property<int>("Number");
            builder.Property<string?>("Additional");
            builder.Property<int?>("ZipCode");
            builder.Property<string>("City");
            builder.Property<string?>("Country");
            builder.Property<DateTime>("CreatedAt")
                .ValueGeneratedOnAdd();
            builder.Property<DateTime>("ModifiedAt")
                .ValueGeneratedOnUpdate();
            builder.HasMany(x => x.Orders)
                .WithOne(x => x.Address)
                .HasForeignKey(x => x.AddressId);
            builder.HasData(
                new Address
                {
                    Id = Guid.NewGuid(),
                    Street = "Avenida Edvaldo Pereira Paiva",
                    Number = 123,
                    ZipCode = 92810129,
                    City = "Porto Alegre",
                    CreatedAt = DateTime.Now
                },
                new Address
                {
                    Id = Guid.NewGuid(),
                    Street = "Rua dos Tupis",
                    Number = 456,
                    ZipCode = 92443875,
                    City = "Belo Horizonte",
                    CreatedAt = DateTime.Now
                },
                new Address
                {
                    Id = Guid.NewGuid(),
                    Street = "Rua Cap. Macedo",
                    Number = 789,
                    ZipCode = 92938729,
                    City = "Sao Paulo",
                    CreatedAt = DateTime.Now
                },
                new Address
                {
                    Id = Guid.NewGuid(),
                    Street = "Rua Teodoro da Silva",
                    Number = 012,
                    ZipCode = 92857129,
                    City = "Rio de Janeiro",
                    CreatedAt = DateTime.Now
                }
            );
        }
    }
}