using Microsoft.Data.SqlClient;
using ProgrammingInCshrpBaseBackend.Interfaces;
using ProgrammingInCshrpBaseBackend.Models;

namespace ProgrammingInCshrpBaseBackend.Services;

public class JobService : IBaseService<Job>
{
    private List<Job> jobs = new List<Job> ();
    public void Add(Job job)
    {
        //jobs.Add(job);

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
      return jobs; 
     }
    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
    public void Update(Job item)
    {
       throw new NotImplementedException();
    }
}
