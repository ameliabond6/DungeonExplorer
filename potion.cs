// Potion class inherits from Item and represents healing items
public class Potion : Item
{
    public int HealAmount { get; set; }

    public Potion(string name, int healAmount) : base(name)
    {
        HealAmount = healAmount;
    }

    // Use potion to heal player
    public override void Use(Player player)
    {
        player.Health += HealAmount;
        Console.WriteLine($"{player.Name} uses {Name} and heals for {HealAmount}. Health is now {player.Health}.");
    }
}