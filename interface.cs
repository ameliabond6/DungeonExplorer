// Interface for anything that can take damage
public interface IDamageable
{
    void TakeDamage(int amount);
}

// Interface for items that can be collected and used by the player
public interface ICollectible
{
    void Use(Player player);
}

// File: Creature.cs

// Abstract base class for all creatures in the game
public abstract class Creature : IDamageable
{
    public string Name { get; set; }
    public int Health { get; set; }
    public bool IsAlive => Health > 0;

    // Basic implementation of taking damage
    public virtual void TakeDamage(int amount)
    {
        Health -= amount;
        if (Health < 0) Health = 0;
    }

    // Abstract attack method to be implemented by subclasses
    public abstract void Attack(Creature target);
}
