namespace StoreManagement.Entities;

public class ProductCategory
{
    public int ProductCategoryId { get; set; }

    public string Name { get; set; } = string.Empty;

    public List<Item> Items { get; set; } = new();
}
