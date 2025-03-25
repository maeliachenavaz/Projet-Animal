using System.Security.Cryptography;

class Program
{
    public static void Main()
    {
        IList<Dog> dogList = new List<Dog>();
        dogList.Add(new Dog("Bob"));
        dogList.Add(new Dog("Bob"));
        dogList.Add(new Dog("Bob"));
        dogList.Add(new Dog("Snow"));
        dogList.Add(new Dog("Bob"));

        IEnumerable<string> dogNameList = from dog in dogList where dog.Name != "Snow" select dog.Name;

        foreach (string dogName in dogNameList)
        {
            Console.WriteLine(dogName);
        }
    }
}