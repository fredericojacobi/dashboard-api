using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Context
{
    public class OrderProductEntityConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        
        
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.Property<Guid>("Id").ValueGeneratedOnAdd();
            builder.Property<Guid?>("OrderId");
            builder.Property<Guid?>("ProductId");
            builder.Property<DateTime>("CreatedAt")
                .ValueGeneratedOnAdd();
            builder.Property<DateTime>("ModifiedAt")
                .ValueGeneratedOnUpdate();
            builder.HasOne(x => x.Order)
                .WithMany(x => x.OrdersProducts)
                .HasForeignKey(x => x.OrderId);
            builder.HasOne(x => x.Product)
                .WithMany(x => x.OrdersProducts)
                .HasForeignKey(x => x.ProductId);
        }
    }
}