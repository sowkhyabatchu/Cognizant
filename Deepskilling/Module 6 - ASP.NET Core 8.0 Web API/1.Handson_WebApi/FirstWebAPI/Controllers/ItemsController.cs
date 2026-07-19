using Microsoft.AspNetCore.Mvc;
using StoreManagementApi.Models;

namespace StoreManagementApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItemsController : ControllerBase
{
    private static readonly List<Item> Items = new()
    {
        new Item { Id = 1, Name = "Laptop" },
        new Item { Id = 2, Name = "Wireless Mouse" }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Item>> Get() => Ok(Items);

    [HttpGet("{id}")]
    public ActionResult<Item> Get(int id)
    {
        var item = Items.FirstOrDefault(i => i.Id == id);

        if (item == null)
            return NotFound();

        return Ok(item);
    }

    [HttpPost]
    public ActionResult<Item> Post(Item item)
    {
        var id = Items.Any() ? Items.Max(i => i.Id) + 1 : 1;
        item.Id = id;

        Items.Add(item);

        return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Item item)
    {
        var existingItem = Items.FirstOrDefault(i => i.Id == id);

        if (existingItem == null)
            return NotFound();

        existingItem.Name = item.Name;

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var item = Items.FirstOrDefault(i => i.Id == id);

        if (item == null)
            return NotFound();

        Items.Remove(item);

        return NoContent();
    }
}
