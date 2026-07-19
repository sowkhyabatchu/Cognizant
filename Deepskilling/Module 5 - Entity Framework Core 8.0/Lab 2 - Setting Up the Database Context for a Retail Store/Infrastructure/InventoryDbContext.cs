using Microsoft.EntityFrameworkCore;
using StoreManagement.Entities;

namespace StoreManagement.Infrastructure;

public class InventoryDbContext : DbContext
{
    public DbSet<Item> Items => Set<Item>();
    public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=(localdb)\\mssqllocaldb;Database=StoreManagementDb;Trusted_Connection=True;");
    }
}
