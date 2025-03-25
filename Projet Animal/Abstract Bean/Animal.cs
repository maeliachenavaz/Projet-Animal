abstract class Animal
{
    public abstract int Id { get; protected set; }

    public abstract string Name { get; protected set; }

    public abstract string Rarete { get; protected set; }

    public virtual void PrintMoove()
    {
        Console.WriteLine("Animal moove");
    }

    public virtual void PrintSleep()
    {
        Console.WriteLine("Animal sleep");
    }
}