using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Context
{
    public class ProductsEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property<Guid>("Id").ValueGeneratedOnAdd();;
            builder.Property<Guid?>("OrderId");
            builder.Property<string>("Name");
            builder.Property<string>("Description");
            builder.Property<string>("Price");
            builder.Property<DateTime>("CreatedAt")
                .ValueGeneratedOnAdd();
            builder.Property<DateTime>("ModifiedAt")
                .ValueGeneratedOnUpdate();
            builder.HasMany(x => x.OrdersProducts)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);

        }
    }
}