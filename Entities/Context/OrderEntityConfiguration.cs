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
            builder.Property<DateTime>("DeliveredAt");
            builder.Property<DateTime>("CreatedAt")
                .ValueGeneratedOnAdd();
            builder.Property<DateTime>("ModifiedAt")
                .ValueGeneratedOnUpdate();
            builder.HasMany(x => x.OrdersProducts)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);
            builder.HasOne(x => x.Address).WithMany(x => x.Orders).HasForeignKey(x => x.AddressId);
            builder.Navigation(x => x.Address).AutoInclude();
            builder.Navigation(x => x.Team).AutoInclude();
        }
    }
}