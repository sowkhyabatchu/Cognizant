namespace StoreManagement.Entities;

public class ProductCategory
{
    public int ProductCategoryId { get; set; }

    public string Name { get; set; } = string.Empty;

    public IList<Item> Items { get; set; } = new List<Item>();
}
