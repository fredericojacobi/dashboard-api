using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Context
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property<Guid>("Id").ValueGeneratedOnAdd();
            builder.Property<string>("UserName");
            builder.Property<DateTime>("CreatedAt")
                .ValueGeneratedOnAdd();
            builder.Property<DateTime>("ModifiedAt")
                .ValueGeneratedOnUpdate();
        }
    }
}