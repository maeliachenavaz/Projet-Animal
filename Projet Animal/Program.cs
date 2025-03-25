using System.Security.Cryptography;

class Program
{
    public static void Main()
    {
        IList<Animal> animalList = new List<Animal>
        {
            new Dog(1, "Bob le chien", "Commun"),
            new Dragon(2, "Bob le dragon", "Rare"),
            new Griffin(3, "Bob le griffon", "Très rare"),
        };

        var rareAnimalList = animalList.Where(animal => animal.Rarete != "Commun");

        foreach (Animal animal in rareAnimalList)
        {
            Console.WriteLine(animal.Id + " : " + animal.Name);
        }
    }
}