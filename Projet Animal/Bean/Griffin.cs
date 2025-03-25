class Griffin : Animal
{
    public new int Id { get; private set; }

    public new string Name { get; private set; }

    public new string Rarete { get; private set; }

    public Griffin(int id, string name, string rarete) : base(id, name, rarete)
    {
        this.Id = id;
        this.Name = name;
        this.Rarete = rarete;
    }

    public override void PrintMoove()
    {
        Console.WriteLine("Griffin moove");
    }

    public new void PrintSleep()
    {
        Console.WriteLine("Griffin sleep");
    }
}