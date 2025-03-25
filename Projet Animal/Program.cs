using System.Security.Cryptography;

class Program
{
    public static void Main()
    {
        IList<Dog> dogList =
        [
            new Dog("Bob"),
            new Dog("Bob"),
            new Dog("Bob"),
            new Dog("Snow"),
            new Dog("Bob"),
        ];

        IEnumerable<string> dogNameList = from dog in dogList where dog.Name != "Snow" select dog.Name;

        foreach (string dogName in dogNameList)
        {
            Console.WriteLine(dogName);
        }
    }
}