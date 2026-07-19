namespace StoreManagement.Entities;

public class Item
{
    public int ItemId { get; set; }

    public string Name { get; set; } = string.Empty;

    public int StockLevel { get; set; }

    public int ProductCategoryId { get; set; }

    public ProductCategory? Category { get; set; }
}
