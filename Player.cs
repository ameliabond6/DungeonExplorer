using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    {
        private string name;
        private int health;
        private string inventoryItem;

        public Player(string name)
        {
            this.name = name;
            this.health = 100;
            this.inventoryItem = "None";
        }

        public string GetName()
        {
            return name;
        }

        public bool PickUpItem(string item)
        {
            if (inventoryItem == "None")
            {
                inventoryItem = item;
                Console.WriteLine($"You picked up: {item}");// You picked up: {item} pop up message
                return true;
            }
            else
            {
                Console.WriteLine("You can only carry one item!"); // You can only carry one item pop up message
                return false;
            }
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Player: {name}\nHealth: {health}\nInventory: {inventoryItem}");
        }
    }
}