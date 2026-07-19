# Lab 4: Inserting Initial Data into the Database

## Scenario
The store manager wants to add initial product categories and products to the system.

## Objective
Use EF Core to insert records using `AddAsync` and `SaveChangesAsync`.

## Steps
1. Insert Data in `Application.cs`:
```csharp
using StoreManagement.Entities;
using StoreManagement.Infrastructure;
using var context = new InventoryDbContext();
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
```
2. Run the App:
   - `dotnet run`
3. Verify in SQL Server:
   - Check that the data is inserted correctly into `ProductCategories` and `Items`.

## Project Structure
- `StoreManagement.csproj`
- `Application.cs`
- `Entities/`
  - `Item.cs`
  - `ProductCategory.cs`
- `Data/`
  - `InventoryDbContext.cs`

## Notes
- `AddRangeAsync` adds multiple entities to the change tracker asynchronously.
- `SaveChangesAsync` commits the inserted rows to the database.
- You can verify the inserted data in SQL Server Management Studio or Azure Data Studio.
