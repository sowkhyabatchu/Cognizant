using StoreManagement.Entities;
using StoreManagement.Infrastructure;

Console.WriteLine("Lab 4: Inserting Initial Data into the Database using EF Core.");

await using var context = new InventoryDbContext();

var electronics = new ProductCategory
{
    Name = "Electronics"
};

var groceries = new ProductCategory
{
    Name = "Groceries"
};

await context.ProductCategories.AddRangeAsync(electronics, groceries);

var item1 = new Item
{
    Name = "Laptop",
    StockLevel = 25,
    Category = electronics
};

var item2 = new Item
{
    Name = "Rice Bag",
    StockLevel = 100,
    Category = groceries
};

await context.Items.AddRangeAsync(item1, item2);

await context.SaveChangesAsync();

Console.WriteLine("Initial data inserted successfully.");
Console.WriteLine("Verify the Items and ProductCategories tables in StoreManagementDb.");
