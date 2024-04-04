using LINQ.DomainLayer.DTO.Entities;
using Microsoft.EntityFrameworkCore;

namespace LINQ.InfrastructureLayer.Data.Context
{
    public class BDNorthwindContext : DbContext
    {
        public BDNorthwindContext(DbContextOptions<BDNorthwindContext> options) : base(options) { }

        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<RegionEntity> Regions { get; set; }
        public DbSet<ShipperEntity> Shippers { get; set; }
        public DbSet<SupplierEntity> Suppliers { get; set; }
        public DbSet<TerritoryEntity> Territories { get; set; }
        public DbSet<EmployeeTerritoryEntity> EmployeeTerritories { get; set; }
        public DbSet<OrderDetailEntity> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryEntity>().ToTable("Categories").HasKey(x => x.CategoryID);
            modelBuilder.Entity<CustomerEntity>().ToTable("Customers").HasKey(x => x.CustomerID);
            modelBuilder.Entity<EmployeeEntity>().ToTable("Employees").HasKey(x => x.EmployeeID);
            modelBuilder.Entity<OrderEntity>().ToTable("Orders").HasKey(x => x.OrderID);
            modelBuilder.Entity<ProductEntity>().ToTable("Products").HasKey(x => x.ProductID);
            modelBuilder.Entity<RegionEntity>().ToTable("Region").HasKey(x => x.RegionID);
            modelBuilder.Entity<ShipperEntity>().ToTable("Shippers").HasKey(x => x.ShipperID);
            modelBuilder.Entity<SupplierEntity>().ToTable("Suppliers").HasKey(x => x.SupplierID);
            modelBuilder.Entity<TerritoryEntity>().ToTable("Territories").HasKey(x => x.TerritoryID);
            modelBuilder.Entity<EmployeeTerritoryEntity>().ToTable("EmployeeTerritories").HasKey(x => new { x.EmployeeID, x.TerritoryID });
            modelBuilder.Entity<OrderDetailEntity>().ToTable("[Order Details]").HasKey(x => new { x.OrderID, x.ProductID });

            base.OnModelCreating(modelBuilder);
        }
    }
}