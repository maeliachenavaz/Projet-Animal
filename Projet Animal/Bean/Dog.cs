class Dog : Animal
{
    public string Name { get; private set; }

    public Dog()
    {
        this.Name = "Snow";
    }

    public Dog(string name)
    {
        this.Name = name;
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
