using StoreManagement.Entities;
using StoreManagement.Infrastructure;

Console.WriteLine("Lab 2: Setting up the EF Core database context for Store Management.");
Console.WriteLine("This example configures InventoryDbContext to connect to SQL Server.");
Console.WriteLine();

using var context = new InventoryDbContext();

Console.WriteLine($"DbContext Type: {context.GetType().Name}");
Console.WriteLine("Entities Configured:");
Console.WriteLine(" - Item -> Items");
Console.WriteLine(" - ProductCategory -> ProductCategories");
Console.WriteLine();

Console.WriteLine("Example Entity Definitions:");

var category = new ProductCategory
{
    Name = "Office Supplies"
};

var item = new Item
{
    Name = "Printer Paper",
    StockLevel = 100,
    Category = category
};

Console.WriteLine($"Category      : {category.Name}");
Console.WriteLine($"Item          : {item.Name}");
Console.WriteLine($"Stock Level   : {item.StockLevel}");
Console.WriteLine($"Belongs To    : {item.Category?.Name}");
