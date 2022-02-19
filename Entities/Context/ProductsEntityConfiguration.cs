using System;
using System.Collections.Generic;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Context
{
    public class ProductsEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property<Guid>("Id").ValueGeneratedOnAdd();
            builder.Property<string>("Name");
            builder.Property<string>("Description");
            builder.Property<double>("Price");
            builder.Property<DateTime>("CreatedAt")
                .ValueGeneratedOnAdd();
            builder.Property<DateTime>("ModifiedAt")
                .ValueGeneratedOnUpdate();
            builder.HasMany(x => x.OrdersProducts)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);
            builder.HasData(new List<Product>
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Caixa de Papelão 10cm",
                    Description = "Tamanho: 10cm x 10cm x 10cm",
                    Price = 2.99,
                    CreatedAt = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Caixa de Papelão 20cm",
                    Description = "Tamanho: 20cm x 20cm x 20cm",
                    Price = 4.99,
                    CreatedAt = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Caixa de Papelão 30cm",
                    Description = "Tamanho: 30cm x 30cm x 30cm",
                    Price = 6.99,
                    CreatedAt = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Caixa de Papelão 40cm",
                    Description = "Tamanho: 40cm x 40cm x 40cm",
                    Price = 8.99,
                    CreatedAt = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Caixa de Papelão 50cm",
                    Description = "Tamanho: 50cm x 50cm x 50cm",
                    Price = 10.99,
                    CreatedAt = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Caixa de Papelão 60cm",
                    Description = "Tamanho: 60cm x 60cm x 60cm",
                    Price = 11.40,
                    CreatedAt = DateTime.Now
                }
            });
        }
    }
}