using System.Collections.Generic;
using System.Linq;

// Represents a room with items, monsters, and neighboring rooms
public class Room
{
    public string Description { get; set; }
    public List<Item> Items { get; set; } = new List<Item>();
    public List<Monster> Monsters { get; set; } = new List<Monster>();
    public Dictionary<string, Room> Neighbors { get; set; } = new Dictionary<string, Room>();

    // Returns the monster with the highest health
    public Monster GetStrongestMonster()
    {
        return Monsters.OrderByDescending(m => m.Health).FirstOrDefault();
    }
}