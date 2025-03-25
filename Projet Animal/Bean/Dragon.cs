class Dragon : Animal, IPilotable
{
    public new int Id { get; private set; }

    public new string Name { get; private set; }

    public new string Rarete { get; private set; }

    public Dragon(int id, string name, string rarete) : base(id, name, rarete)
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