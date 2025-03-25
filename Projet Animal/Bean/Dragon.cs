class Dragon : Animal, IPilotable
{
    public override int Id { get; protected set; }

    public override string Name { get; protected set; }

    public override string Rarete { get; protected set; }

    public Dragon(int id, string name, string rarete) 
    {
        this.Id = id;
        this.Name = name;
        this.Rarete = rarete;
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