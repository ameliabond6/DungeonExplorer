// Abstract base class for all items
public abstract class Item : ICollectible
{
    public string Name { get; set; }

    protected Item(string name)
    {
        Name = name;
    }

    // Abstract use method to be implemented by specific item types
    public abstract void Use(Player player);
}