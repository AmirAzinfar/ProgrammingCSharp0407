using Microsoft.Data.SqlClient;
using ProgrammingInCshrpBaseBackend.Interfaces;
using ProgrammingInCshrpBaseBackend.Models;

namespace ProgrammingInCshrpBaseBackend.Services;

public class JobService : IBaseService<Job>
{
    public void Add(Job job)
    {
        
        const string ConectionString = "Server=.;Database=ProgrammingCSharp0407Db;Integrated Security=True;TrustServerCertificate=True;";

        using(SqlConnection Connection = new SqlConnection(ConectionString))              
        {
            
            Connection.Open ();
            string Query = $"INSERT INTO[dbo].[Table_Job] " +
            "VALUES(@FieldOfJob,@TitelOfJob,@Salary,@TimeWorkingHours," + 
            "@ProvinceWorkplace,@CityWorkplace,@DateOfStart,@ChoiceStart,@CreatedAt);";

            SqlCommand comand = new SqlCommand(Query,Connection);

            comand.Parameters.AddWithValue("@FieldOfJob", job.FieldOfJob);
            comand.Parameters.AddWithValue("@TitelOfJob",job.TitelOfJob);
            comand.Parameters.AddWithValue("@Salary", job.Salary);
            comand.Parameters.AddWithValue("@TimeWorkingHours",job.TimeWorkingHours);
            comand.Parameters.AddWithValue("@ProvinceWorkplace",job.ProvinceWorkplace);
            comand.Parameters.AddWithValue("@CityWorkplace", job.CityWorkplace);
            comand.Parameters.AddWithValue("@DateOfStart",job.DateOfStart);
            comand.Parameters.AddWithValue("@ChoiceStart",job.ChoiceStart); 
            comand.Parameters.AddWithValue("@CreatedAt",job.CreatedAt);

            int rowAffected = comand.ExecuteNonQuery();
        }
    }

     public List<Job> GetAll()
     {
        List<Job> jobs = new List<Job>();
        const string Connectionstring = "Server=.;Database=ProgrammingCSharp0407Db;Integrated Security=True;TrustServerCertificate=True;";

        using (SqlConnection connection = new SqlConnection(Connectionstring))
        {
            connection.Open();
            
            string Query = $"SELECT * FROM [dbo].[Table_Job]";

            SqlCommand command = new SqlCommand(Query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Job job = new Job()
                {
                    Id = (int)reader["Id"],
                    FieldOfJob = reader["FieldOfJob"].ToString(),
                    TitelOfJob = reader["TitelOfJob"].ToString(),
                    Salary = reader["Salary"].ToString(),
                    TimeWorkingHours = reader["TimeWorkingHours"].ToString(),
                    ProvinceWorkplace = reader["ProvinceWorkplace"].ToString(),
                    CityWorkplace = reader["CityWorkplace"].ToString(),
                    DateOfStart = (DateTime)reader["DateOfStart"],
                    ChoiceStart = reader["ChoiceStart"].ToString(),
                    CreatedAt=(DateTime)reader["CreatedAt"],
                };
                jobs.Add(job);
            }
        }
   
        return jobs;
    }
    public void Delete(int id)
    {
        const string Connectionstring = "Server=.;Database=ProgrammingCSharp0407Db;Integrated Security=True;TrustServerCertificate=True;";
        using (SqlConnection connection = new SqlConnection(Connectionstring))
        {
            connection.Open();
            
            string Query = $"DELETE FROM [dbo].[Table_Job] WHERE Id = @Id;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@Id", id);

            int rowsaffected = command.ExecuteNonQuery();
        }
    }
    public void Update(Job item)
    {
        const string Connectionstring = "Server=.;Database=ProgrammingCSharp0407Db;Integrated Security=True;TrustServerCertificate=True;";
        using (SqlConnection connection = new SqlConnection(Connectionstring))
        {
            connection.Open();
            
            string Query = $"UPDATE [dbo].[Table_Job] SET FieldOfJob = @FieldOfJob,TitelOfJob=@TitelOfJob,Salary=@Salary," +
                "TimeWorkingHours=@TimeWorkingHours, ProvinceWorkplace= @ProvinceWorkplace," +
                "CityWorkplace=@CityWorkplace,DateOfStart=@DateOfStart,ChoiceStart=@ChoiceStart WHERE Id = @Id";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@FieldOfJob", item.FieldOfJob);
            command.Parameters.AddWithValue("@TitelOfJob", item.TitelOfJob);
            command.Parameters.AddWithValue("@Salary", item.Salary);
            command.Parameters.AddWithValue("@TimeWorkingHours", item.TimeWorkingHours);
            command.Parameters.AddWithValue("@ProvinceWorkplace", item.ProvinceWorkplace);
            command.Parameters.AddWithValue("@CityWorkplace", item.CityWorkplace);
            command.Parameters.AddWithValue("@DateOfStart", item.DateOfStart);
            command.Parameters.AddWithValue("@ChoiceStart", item.ChoiceStart);
            command.Parameters.AddWithValue("@Id", item.Id);

            int rowsaffected = command.ExecuteNonQuery();
        }
    }
}
