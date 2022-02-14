using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities.Context
{
    public class DashboardContext : DbContext
    {
        public DashboardContext(DbContextOptions<DashboardContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderProductEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PackageEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductsEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TeamEntityConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleEntityConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<Address> Addresses { get; set; }
        
        public DbSet<Order> Orders { get; set; }
        
        public DbSet<OrderProduct> OrderProducts { get; set; }
        
        public DbSet<Package> Packages { get; set; }
        
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Team> Teams { get; set; }
        
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}