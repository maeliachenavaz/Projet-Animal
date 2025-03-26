abstract class Bird : IFly
{
    public abstract string Name { get; protected set; }

    public abstract void Fly();
}