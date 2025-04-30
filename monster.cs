using System;

// Monster class inherits from Creature and represents enemies
public class Monster : Creature
{
    public int Damage { get; set; }

    public Monster(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    // Monster attack logic
    public override void Attack(Creature target)
    {
        Console.WriteLine($"{Name} attacks {target.Name} for {Damage} damage.");
        target.TakeDamage(Damage);
    }
}