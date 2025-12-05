using Microsoft.Data.SqlClient;
using ProgrammingInCshrpBaseBackend.Interfaces;
using ProgrammingInCshrpBaseBackend.Models;


namespace ProgrammingInCshrpBaseBackend.Services;

public class AdressService : IBaseService<Adress>
{
    public void Add(Adress adress)
    {
        const string ConectionString = "Server=AA;Database=ProgrammingCSharp0407Db;Integrated Security=True;TrustServerCertificate=True;";

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
        const string ConectionString = "Server=AA;Database=ProgrammingCSharp0407Db;Integrated Security=True;TrustServerCertificate=True;";

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

}