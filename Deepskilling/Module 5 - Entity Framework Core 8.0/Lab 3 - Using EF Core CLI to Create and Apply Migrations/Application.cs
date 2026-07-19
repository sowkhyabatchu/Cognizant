using StoreManagement.Infrastructure;

Console.WriteLine("Lab 3: Using EF Core CLI to Create and Apply Migrations");
Console.WriteLine("This lab demonstrates how to generate migrations and update the SQL Server database.");
Console.WriteLine();

Console.WriteLine("Step 1: Install EF Core CLI (if not already installed)");
Console.WriteLine("  dotnet tool install --global dotnet-ef");
Console.WriteLine();

Console.WriteLine("Step 2: Create the Initial Migration");
Console.WriteLine("  dotnet ef migrations add InitialCreate");
Console.WriteLine();

Console.WriteLine("Step 3: Apply the Migration");
Console.WriteLine("  dotnet ef database update");
Console.WriteLine();

Console.WriteLine("The Migrations folder contains the generated schema files.");
Console.WriteLine("Verify that the Items and ProductCategories tables are created in StoreManagementDb.");
Console.WriteLine();

using var context = new InventoryDbContext();

Console.WriteLine($"DbContext Type : {context.GetType().Name}");
Console.WriteLine("Database Provider : Microsoft SQL Server");
Console.WriteLine("Connection : StoreManagementDb");
