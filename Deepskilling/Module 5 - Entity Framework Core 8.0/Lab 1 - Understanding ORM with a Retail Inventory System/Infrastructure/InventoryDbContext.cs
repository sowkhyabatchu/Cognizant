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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.ItemId);

            entity.Property(e => e.Name)
                  .IsRequired()
                  .HasMaxLength(200);

            entity.Property(e => e.StockLevel)
                  .IsRequired();

            entity.HasOne(e => e.Category)
                  .WithMany(c => c.Items)
                  .HasForeignKey(e => e.ProductCategoryId);
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.ProductCategoryId);

            entity.Property(e => e.Name)
                  .IsRequired()
                  .HasMaxLength(100);
        });
    }
}
