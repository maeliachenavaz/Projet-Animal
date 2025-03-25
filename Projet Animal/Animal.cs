class Animal
{
    private string name;

    public Animal()
    {
        this.name = "Bob";
    }

    public Animal(string name)
    {
        this.name = name;
    }

    public void PrintMoove()
    {
        Console.WriteLine("Moove");
    }

    public void PrintSleep()
    {
        Console.WriteLine("Sleep");
    }
}