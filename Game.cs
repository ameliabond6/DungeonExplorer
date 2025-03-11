using System;
using System.Media;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;

        public Game()
        {
            
                player = new Player(name);
                currentRoom = new Room("A dark dungeon room with a rusty key on the floor.", "Rusty Key");     // put rusty key in the room
                // Initialize the game with one room and one player

        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = false;
            while (playing)
            {
                // Code your playing logic here
                Console.Write("Enter your player name: ");
                string name = Console.ReadLine();
        
                Console.WriteLine($"Welcome, {player.GetName()}! You find yourself in a dungeon.");// add message at the start of the game that says welcome player
                Play();
            }
        }
        private void Play()
        {
            bool playing = true;
            while (playing)
            {
                Console.WriteLine("\nChoose an action: 1. Look around  2. Pick up item  3. Check status  4. Exit"); // Add a menu for the player
                string choice = Console.ReadLine();
            
                switch (choice)
                {
                    case "1":
                        Console.WriteLine(currentRoom.GetDescription());
                    break;
                    case "2":
                        if (player.PickUpItem(currentRoom.GetItem()))
                        {
                            currentRoom.RemoveItem();
                        }
                    break;
                    case "3":
                        player.DisplayStatus();
                    break;
                    case "4":
                        playing = false;
                        Console.WriteLine("Thanks for playing!"); // add messsage at the end of thr game that says thanks for playing
                    break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                    break;
                }
            }
    
        }
    }
}