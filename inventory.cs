using System;
using System.Collections.Generic;
using System.Linq;

// Manages player's items
public class Inventory
{
    private List<Item> items = new List<Item>();

    // Add item to inventory
    public void AddItem(Item item)
    {
        items.Add(item);
        Console.WriteLine($"Added {item.Name} to inventory.");
    }

    // Use item by name; checks if item exists before using
    public void UseItem(string name, Player player)
    {
        var item = items.FirstOrDefault(i => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (item != null)
        {
            item.Use(player);
            items.Remove(item);
        }
        else
        {
            Console.WriteLine($"Item {name} not found in inventory.");
        }
    }

    // Return list of all items
    public IEnumerable<Item> GetItems() => items;

    // Display all items in the inventory
    public void DisplayItems()
    {
        if (!items.Any())
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        Console.WriteLine("Inventory:");
        foreach (var item in items)
        {
            Console.WriteLine($"- {item.Name}");
        }
    }
}