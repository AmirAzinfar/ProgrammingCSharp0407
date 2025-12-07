using Microsoft.Data.SqlClient;
using ProgrammingInCshrpBaseBackend.Interfaces;
using ProgrammingInCshrpBaseBackend.Models;


namespace ProgrammingInCshrpBaseBackend.Services;

public class AdressService : IBaseService<Adress>
{
    public void Add(Adress adress)
    {
        const string ConectionString = "Server=.;Database=ProgrammingCSharp0407Db;Integrated Security=True;TrustServerCertificate=True;";

        using (SqlConnection connection = new SqlConnection(ConectionString))
        {
            connection.Open();
            string Query = $"INSERT INTO [dbo].[Table_Adress]" +
                            "VALUES(@Street,@HouseNumber,@PostalCode)";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Street", adress.Street);
            command.Parameters.AddWithValue("@HouseNumber",adress.HouseNumber);
            command.Parameters.AddWithValue("@PostalCode",adress.PostalCode);

            int rowsAffected = command.ExecuteNonQuery();
        }
    }

    

    public List<Adress> GetAll()
    {
        List<Adress> adresses = new List<Adress>();
        const string ConectionString = "Server=.;Database=ProgrammingCSharp0407Db;Integrated Security=True;TrustServerCertificate=True;";

        using(SqlConnection connection = new SqlConnection(ConectionString))
        {
            connection.Open();
            string Query = $"SELECT * FROM[dbo].[Table_Adress]";
            SqlCommand command = new SqlCommand(Query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Adress adress = new Adress()
                {
                    Id = (int)reader["Id"],
                    Street = reader["Street"].ToString(),
                    HouseNumber = reader["HouseNumber"].ToString(),
                    PostalCode = reader["PostalCode"].ToString(),
                };
                adresses.Add(adress);
            }
        }
        return adresses;
    }

    public void Delete(int id)
    {
        const string Connectionstring = "Server=.;Database=ProgrammingCSharp0407Db;Integrated Security=True;TrustServerCertificate=True;";
        using (SqlConnection connection = new SqlConnection(Connectionstring))
        {
            connection.Open();
            // now, I write a Query with command DELETE (same "DELETE" as Query in Database)
            //Without WHERE, all rows in the table will be deleted! The table remains empty.
            string Query = $"DELETE FROM [dbo].[Table_Adress] WHERE Id = @Id;";

            SqlCommand command = new SqlCommand(Query, connection);

            // create Parameters to command data in Table of Db
            //command.Parameters.AddWithValue("@Id", "8");
            command.Parameters.AddWithValue("@Id", id);

            //Excute INSERT Query

            int rowsaffected = command.ExecuteNonQuery();
        }
    }
    public void Update(Adress item)
    {
        const string Connectionstring = "Server=.;Database=ProgrammingCSharp0407Db;Integrated Security=True;TrustServerCertificate=True;";
        using (SqlConnection connection = new SqlConnection(Connectionstring))
        {
            connection.Open();
            // now, I write a Query with command UPDATE (same "UPDATE" as Query in Database)
            //Without WHERE, all rows in the table will be changed!
            string Query = $"UPDATE [dbo].[Table_Adress] SET Street = @Street,HouseNumber = @HouseNumber,PostalCode = @PostalCode WHERE Id = @Id";

            SqlCommand command = new SqlCommand(Query, connection);

            // create Parameters to command data in Table of Db
            //command.Parameters.AddWithValue("@Id", "8");
            command.Parameters.AddWithValue("@Street", item.Street);
            command.Parameters.AddWithValue("@HouseNumber", item.HouseNumber);
            command.Parameters.AddWithValue("@PostalCode", item.PostalCode);
            command.Parameters.AddWithValue("@Id", item.Id);

            //Excute INSERT Query

            int rowsaffected = command.ExecuteNonQuery();
        }
    }
}