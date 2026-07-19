# Lab 5: Retrieving Data from the Database

## Scenario
The store wants to display product details on the dashboard.

## Objective
Use `Find`, `FirstOrDefault`, and `ToListAsync` to retrieve data.

## Steps
1. Retrieve All Products:
```csharp
var items = await context.Items.ToListAsync();
foreach (var item in items)
{
    Console.WriteLine($"{item.Name} - Stock: {item.StockLevel}");
}
```
2. Find by ID:
```csharp
var item = await context.Items.FindAsync(1);
Console.WriteLine($"Found: {item?.Name}");
```
3. FirstOrDefault with Condition:
```csharp
var highStockItem = await context.Items
    .FirstOrDefaultAsync(i => i.StockLevel > 50);
Console.WriteLine($"High Stock Item: {highStockItem?.Name}");
```

## Notes
- `ToListAsync` retrieves all records asynchronously.
- `FindAsync` uses the primary key lookup for efficient retrieval.
- `FirstOrDefaultAsync` returns the first record matching the predicate or `null`.

## Project Structure
- `StoreManagement.csproj`
- `Application.cs`
- `Entities/`
  - `ProductCategory.cs`
  - `Item.cs`
- `Infrastructure/`
  - `InventoryDbContext.cs`
