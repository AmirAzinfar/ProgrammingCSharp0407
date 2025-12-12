using Microsoft.Data.SqlClient;
using ProgrammingInCshrpBaseBackend.Interfaces;
using ProgrammingInCshrpBaseBackend.Models;
using System.Data;

namespace ProgrammingInCshrpBaseBackend.Services;

public class UploadDocService : IBaseService<UploadDoc>
{
    private const string ConnectionString = "Server=.;Database=ProgrammingCSharp0407Db;Integrated Security=True;TrustServerCertificate=True;";
    public void Add(UploadDoc doc)
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();

            string Query = @"INSERT INTO [dbo].[Table_UploadDoc]
                            (Motivation, Education, JobExperience, CV, EmploymentReference,CreatedAt)
                            VALUES (@Motivation, @Education, @JobExperience, @CV, @EmploymentReference,@CreatedAt)";


            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.Add("@Motivation", SqlDbType.VarBinary).Value = doc.Motivation ?? []; 
            command.Parameters.Add("@Education", SqlDbType.VarBinary).Value = doc.Education ?? [];
            command.Parameters.Add("@JobExperience", SqlDbType.VarBinary).Value = doc.JobExperience ?? [];
            command.Parameters.Add("@CV", SqlDbType.VarBinary).Value = doc.CV ?? [];
            command.Parameters.Add("@EmploymentReference", SqlDbType.VarBinary).Value = doc.EmploymentReference ?? [];
            command.Parameters.AddWithValue("@CreatedAt", doc.CreatedAt);

            int rowsAffected = command.ExecuteNonQuery();
        }
    }
    public void Delete(int id)
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            string Query = $"DELETE FROM [dbo].[Table_UploadDoc] WHERE Id = @Id;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Id", id);
            int rowsaffected = command.ExecuteNonQuery();
        }
    }

    public List<UploadDoc> GetAll()
    {
        List<UploadDoc> uploadDocs = new List<UploadDoc>();
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            string Query = $"SELECT * FROM [dbo].[Table_UploadDoc]";
            SqlCommand command = new SqlCommand(Query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            { 
                UploadDoc uploadDoc = new UploadDoc()
                {
                    Id = (int)reader["Id"],
                    Motivation = reader["Motivation"] as byte[],
                    Education = reader["Education"] as byte[],
                    JobExperience = reader["JobExperience"] as byte[],
                    CV = reader["CV"] as byte[],
                    EmploymentReference = reader["EmploymentReference"] as byte[],
                    //CreatedAt = reader["CreatedAt"] != DBNull.Value ? (DateTime?)reader["CreatedAt"] : null

                    CreatedAt = (DateTime)reader["CreatedAt"],
                };
                uploadDocs.Add(uploadDoc);
            }
        }
        return uploadDocs;
    }

    public void Update(UploadDoc doc)
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            
            string Query = $"UPDATE [dbo].[Table_UploadDoc] SET Motivation = @Motivation,Education= @Education,JobExperience = @JobExperience,CV = @CV,EmploymentReference = @EmploymentReference WHERE Id = @Id";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.Add("@Motivation", SqlDbType.VarBinary).Value =doc.Motivation ?? []; 
            command.Parameters.Add("@Education", SqlDbType.VarBinary).Value =doc.Education ?? [];
            command.Parameters.Add("@JobExperience", SqlDbType.VarBinary).Value =doc.JobExperience ?? [];
            command.Parameters.Add("@CV", SqlDbType.VarBinary).Value = doc.CV ?? [];
            command.Parameters.Add("@EmploymentReference", SqlDbType.VarBinary).Value = doc.EmploymentReference ?? [];
            command.Parameters.AddWithValue("@Id", doc.Id);

            int rowsaffected = command.ExecuteNonQuery();
        }
    }
}
