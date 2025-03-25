class Dog : Animal
{
    public new int Id { get; private set; }

    public new string Name { get; private set; }

    public new string Rarete { get; private set; }

    public Dog(int id, string name, string rarete) : base(id, name, rarete) 
    {
        this.Id = id;
        this.Name = name;
        this.Rarete = rarete;
    }

    public override void PrintMoove()
    {
        Console.WriteLine("Dog moove");
    }

    public new void PrintSleep()
    {
        Console.WriteLine("Dog sleep");
    }
}
