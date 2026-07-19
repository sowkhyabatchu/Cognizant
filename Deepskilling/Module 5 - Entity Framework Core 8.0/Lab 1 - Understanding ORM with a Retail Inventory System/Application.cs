using StoreManagement.Entities;
using StoreManagement.Infrastructure;

Console.WriteLine("Store Management ORM Demonstration using EF Core 8.0");
Console.WriteLine("This application demonstrates how C# classes are mapped to SQL Server tables using Entity Framework Core.");
Console.WriteLine();

var context = new InventoryDbContext();

Console.WriteLine($"DbContext: {context.GetType().Name}");
Console.WriteLine("Mapped Entities:");
Console.WriteLine(" - Item -> Items");
Console.WriteLine(" - ProductCategory -> ProductCategories");
Console.WriteLine("Database Provider: Microsoft SQL Server");
Console.WriteLine();

var category = new ProductCategory
{
    Name = "Electronics"
};

var item = new Item
{
    Name = "Wireless Mouse",
    StockLevel = 120,
    Category = category
};

Console.WriteLine("Sample Data");
Console.WriteLine($"Category     : {category.Name}");
Console.WriteLine($"Item         : {item.Name}");
Console.WriteLine($"Stock Level  : {item.StockLevel}");
Console.WriteLine($"Relationship : {item.Name} belongs to {item.Category?.Name}");
