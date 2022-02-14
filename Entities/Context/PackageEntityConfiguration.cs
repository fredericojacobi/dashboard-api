using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Context
{
    public class PackageEntityConfiguration : IEntityTypeConfiguration<Package>
    {
        public void Configure(EntityTypeBuilder<Package> builder)
        {
            builder.Property<Guid>("Id").ValueGeneratedOnAdd();
            builder.Property<Guid?>("OrderId");
            builder.Property<Guid?>("TeamId");
            builder.Property<DateTime>("CreatedAt")
                .ValueGeneratedOnAdd();
            builder.Property<DateTime>("ModifiedAt")
                .ValueGeneratedOnUpdate();
            builder.HasOne(x => x.Order).WithOne(x => x.Package).HasForeignKey<Order>(x => x.PackageId);
            builder.HasOne(x => x.Team).WithMany(x => x.Packages).HasForeignKey(x => x.TeamId);
        }
    }
}