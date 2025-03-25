class Dragon : Animal, IPilotable
{
    public string Name { get; private set; }

    public Dragon()
    {
        this.Name = "Bob le dragon";
    }

    public Dragon(string name)
    {
        this.Name = name;
    }

    public void MooveInterface()
    {
        Console.WriteLine("Interface dragon moove");
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