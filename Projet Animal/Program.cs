using System.Security.Cryptography;

class Program
{
    public static void Main()
    {
        IList<Animal> animalList =
        [
            new Dog(1, "Bob le chien", "Commun"),
            new Dragon(2, "Bob le dragon", "Rare"),
            new Griffin(3, "Bob le griffon", "Très rare"),
        ];

        /**
         * Method expression
         */
        //var rareAnimalList = animalList.Where(animal => animal.Rarete != "Commun");

        /**
         * Query expression
         */
        var rareAnimalList = from animal in animalList 
                             where animal.Rarete != "Commun" 
                             orderby animal.Id descending 
                             select animal;

        foreach (Animal animal in rareAnimalList)
        {
            Console.WriteLine(animal.Id + " : " + animal.Name);
        }
    }
}