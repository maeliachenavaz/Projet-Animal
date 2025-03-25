class Dragon : Animal
{
    public string Name { get; private set; }

    public Dragon()
    {
    }

    public Dragon(string name)
    {
        this.Name = name;
    }

    public override void PrintMoove()
    {
        Console.WriteLine("Dragon moove");
    }

    public new void PrintSleep()
    {
        Console.WriteLine("Dragon sleep");
    }
}