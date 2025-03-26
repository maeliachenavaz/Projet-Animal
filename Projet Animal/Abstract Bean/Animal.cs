abstract class Animal
{
    public int Id { get; protected set; }

    public string? Name { get; protected set; }

    public string? Rarete { get; protected set; }

    public abstract void Create(string name, Rarity rarity);

    public virtual void PrintMoove()
    {
        Console.WriteLine("Animal moove");
    }

    public virtual void PrintSleep()
    {
        Console.WriteLine("Animal sleep");
    }
}