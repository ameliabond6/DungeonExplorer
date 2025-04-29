using System;

// Controls the navigation between rooms
public class GameMap
{
    public Room CurrentRoom { get; private set; }

    // the game map with connected rooms and contents
    public void Initialize()
    {
        var room1 = new Room { Description = "You are in a dark cave." };
        var room2 = new Room { Description = "You have entered a narrow corridor." };
        var room3 = new Room { Description = "You stand in a treasure chamber." };

        room1.Neighbors["east"] = room2;
        room2.Neighbors["west"] = room1;
        room2.Neighbors["north"] = room3;
        room3.Neighbors["south"] = room2;

        // Add items and monsters to rooms
        room1.Items.Add(new Weapon("Rusty Sword", 10));
        room3.Items.Add(new Potion("Health Potion", 20));

        room2.Monsters.Add(new Monster("Goblin", 30, 5));
        room3.Monsters.Add(new Monster("Dragon", 100, 25));

        // Set initial room
        CurrentRoom = room1;
    }

    // Move to the neighboring room based on direction
    public void Move(string direction)
    {
        if (CurrentRoom.Neighbors.ContainsKey(direction))
        {
            CurrentRoom = CurrentRoom.Neighbors[direction];
            Console.WriteLine(CurrentRoom.Description);
        }
        else
        {
            Console.WriteLine("You can't go that way.");
        }
    }
}