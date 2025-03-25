class Griffin : Animal
{
    public override int Id { get; protected set; }

    public override string Name { get; protected set; }

    public override string Rarete { get; protected set; }

    public Griffin(int id, string name, string rarete) 
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