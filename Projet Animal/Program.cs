using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;
class Program
{
    public static void Main()
    {
        Console.Clear();

        Console.WriteLine("1 - Ajouter un animal");
        Console.WriteLine("2 - Voir la liste des animaux");
        int input = int.Parse(Console.ReadLine());

        Menu(input);
    }

    public static void Menu(int input)
    {
        if (input == 1)
        {
            Console.Clear();

            Console.WriteLine("Choisir un type : \n1 - Chien \n2 - Dragon \n3 - Eagle \n4 - Griffon");
            int inputType = int.Parse(Console.ReadLine());

            Console.WriteLine("Choisir une rareté : \n1 - Commun \n2 - Peu commun \n3 - Rare \n4 - Légendaire");
            int inputRarity = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un nom : ");
            string inputName = Console.ReadLine();

            switch (inputType)
            {
                case 1:
                    Animal dog = new Dog();
                    dog.Create(inputName, (Rarity)inputRarity);
                    break;
                case 2:
                    Animal dragon = new Dragon();
                    dragon.Create(inputName, (Rarity)inputRarity);
                    break;
                case 3:
                    Animal eagle = new Eagle();
                    eagle.Create(inputName, (Rarity)inputRarity);
                    break;
                case 4:
                    Animal griffin = new Griffin();
                    griffin.Create(inputName, (Rarity)inputRarity);
                    break;
            }
        }
        else if (input == 2)
        {
            Console.Clear();

            DB database = new DB();
            database.GetDBconnection().Open();

            string query = "SELECT a.id, a.name, t.type, r.rarity FROM ANIMAL a INNER JOIN ANIMALTYPE t ON a.animal_type = t.id INNER JOIN ANIMALRARITY r ON a.animal_rarity = r.id;";
            SqlDataReader reader = database.Reader(query);

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"].ToString());
                string name = reader["name"].ToString();
                string rarity = reader["rarity"].ToString();
                string type = reader["type"].ToString();

                Type? animalType = Type.GetType(type);

                Animal animal = (Animal)Activator.CreateInstance(animalType, id, name, rarity);

                if (animal is IFly)
                {
                    Console.WriteLine("\nType : " + animal.GetType().Name + "\nNom : " + animal.Name + "\nRareté : " + animal.Rarete + "\nIl peut voler");
                }
                else
                {
                    Console.WriteLine("\nType : " + animal.GetType().Name + "\nNom : " + animal.Name + "\nRareté : " + animal.Rarete + "\nNe peux pas voler");
                }
            }

            reader.Close();
            database.GetDBconnection().Close();
        }

        Console.WriteLine("1 - Retour au menu \n2 - Quitter");
        int inputChoice = int.Parse(Console.ReadLine());

        if (inputChoice == 1)
        {
            Main();
        }
        else if (inputChoice == 2) 
        {
            Console.Clear();
        }
    }
}