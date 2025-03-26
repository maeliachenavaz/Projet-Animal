using Microsoft.Data.SqlClient;
using System.Data;

class Dragon : Animal, IFly
{
    public Dragon() {}

    public Dragon(int id, string name, string rarete) 
    {
        this.Id = id;
        this.Name = name;
        this.Rarete = rarete;
    }

    public override void Create(string name, Rarity rarity)
    {
        DB database = new DB();
        database.GetDBconnection().Open();

        string createQuery = "INSERT INTO ANIMAL ([name], [animal_type],[animal_rarity]) VALUES (@name, @animal_type, @animal_rarity)";

        SqlCommand command = database.Command(createQuery);

        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        command.Parameters.Add("@animal_type", SqlDbType.Int).Value = (int)AnimalType.DRAGON;
        command.Parameters.Add("@animal_rarity", SqlDbType.Int).Value = (int)rarity;

        command.ExecuteNonQuery();

        database.GetDBconnection().Close();
    }

    public override void PrintMoove()
    {
        Console.WriteLine("Dragon moove");
    }

    public new void PrintSleep()
    {
        Console.WriteLine("Dragon sleep");
    }

    public void Fly()
    {
        Console.WriteLine("fly");
    }
}