abstract class Animal
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Rarete { get; private set; }

    public Animal(int id, string name, string rarete)
    {
        this.Id = id;
        this.Name = name;
        this.Rarete = rarete;
    }

    public virtual void PrintMoove()
    {
        Console.WriteLine("Animal moove");
    }

    public virtual void PrintSleep()
    {
        Console.WriteLine("Animal sleep");
    }
}