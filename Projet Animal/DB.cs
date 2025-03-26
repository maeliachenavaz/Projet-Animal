using Microsoft.Data.SqlClient;

class DB
{
    private const string DBconnectionLink = "Data Source=LAPTOP-20JAC0AL\\SQLEXPRESS;Initial Catalog=CoursDotnet;Integrated Security=True;Trust Server Certificate=True";

    private SqlConnection DBconnection;

    public DB()
    {
        DBconnection = new SqlConnection(DBconnectionLink);
    }

    public SqlConnection GetDBconnection()
    {
        return DBconnection;
    }

    public SqlDataReader Reader(string query)
    {
        SqlCommand command = new SqlCommand(query, DBconnection);
        return command.ExecuteReader();
    }

    public SqlCommand Command(string query)
    {
        SqlCommand command = new SqlCommand(query, DBconnection);
        return command;
    }
}