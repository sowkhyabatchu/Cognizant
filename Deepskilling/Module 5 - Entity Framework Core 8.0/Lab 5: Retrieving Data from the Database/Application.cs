using Microsoft.EntityFrameworkCore;
using StoreManagement.Infrastructure;

Console.WriteLine("Lab 5: Retrieving Data from the Database using EF Core.");

await using var context = new InventoryDbContext();

Console.WriteLine("Retrieving all items...");
var items = await context.Items.ToListAsync();

foreach (var item in items)
{
    Console.WriteLine($"{item.Name} - Stock Level: {item.StockLevel}");
}

Console.WriteLine();

Console.WriteLine("Finding item with ID = 1...");
var itemFound = await context.Items.FindAsync(1);

Console.WriteLine($"Found: {itemFound?.Name ?? "Not found"}");

Console.WriteLine();

Console.WriteLine("Finding an item with Stock Level > 50...");
var highStockItem = await context.Items
    .FirstOrDefaultAsync(i => i.StockLevel > 50);

Console.WriteLine($"High Stock Item: {highStockItem?.Name ?? "None"}");
