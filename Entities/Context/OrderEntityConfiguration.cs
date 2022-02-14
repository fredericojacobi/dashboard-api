using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Context
{
    public class OrderEntityConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property<Guid>("Id").ValueGeneratedOnAdd();
            builder.Property<Guid?>("AddressId");
            builder.Property<Guid?>("PackageId");
            builder.Property<DateTime>("DeliveredAt");
            builder.Property<DateTime>("CreatedAt")
                .ValueGeneratedOnAdd();
            builder.Property<DateTime>("ModifiedAt")
                .ValueGeneratedOnUpdate();
            builder.HasMany(x => x.OrdersProducts)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);
            builder.HasOne(x => x.Package).WithOne(x => x.Order).HasForeignKey<Package>(x => x.OrderId);
        }
    }
}