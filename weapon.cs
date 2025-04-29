// Weapon class inherits from Item and represents damage-dealing items
public class Weapon : Item
{
    public int Damage { get; set; }

    public Weapon(string name, int damage) : base(name)
    {
        Damage = damage;
    }

    // Equip logic when weapon is used
    public override void Use(Player player)
    {
        Console.WriteLine($"{player.Name} equips {Name}.");
    }
}