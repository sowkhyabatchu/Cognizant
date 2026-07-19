# Lab 2: Setting Up the Database Context for a Retail Store

## Scenario
The store management system needs to store item and product category information in a SQL Server database.

## Objective
Configure InventoryDbContext and connect the application to SQL Server using Entity Framework Core.

## Steps
1. Create Entity Classes:
   - `ProductCategory` with `ProductCategoryId`, `Name`, and `Items`.
   - `Item` with `ItemId`, `Name`, `StockLevel`, `ProductCategoryId`, and `Category`.
2. Create `InventoryDbContext`:
   - Configure `DbSet<Item>` and `DbSet<ProductCategory>`.
   - Override `OnConfiguring()` to connect with SQL Server.
3. Configure the Connection String: 
    - Add the SQL Server connection string inside `InventoryDbContext`.


## Project Structure
- `StoreManagement.csproj`
- `Application.cs`
- `Entitis/`
  - `ProductCategory.cs`
  - `Iteem.cs`
- `Data/`
  - `InventoryDbContext.cs`

## Notes
  -`InventoryDbContext` is the central EF Core class responsible for configuring the database connection and entity mappings.
  -`DbSet<Item>` represents the Items table in the database.
  -`DbSet<ProductCategory>` represents the ProductCategories table in the database.
  -In ASP.NET Core applications, the connection string is typically stored in `appsettings.json` and registered through Dependency Injection (DI).
  -EF Core automatically maps the `Item` and `ProductCategory` classes to SQL Server tables using the `InventoryDbContext`.
