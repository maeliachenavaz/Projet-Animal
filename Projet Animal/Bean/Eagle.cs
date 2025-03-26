class Eagle : Bird
{
    public override string Name { get; protected set; }

    public Eagle(string name)
    {
        Name = name;
    }

    public override void Fly()
    {
        Console.WriteLine(this.Name + " the eagle, flew away !");
    }
}