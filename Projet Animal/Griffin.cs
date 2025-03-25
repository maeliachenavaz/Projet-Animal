class Griffin : Animal
{
    public string Name { get; private set; }

    public Griffin()
    {
    }

    public Griffin(string name)
    {
        this.Name = name;
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