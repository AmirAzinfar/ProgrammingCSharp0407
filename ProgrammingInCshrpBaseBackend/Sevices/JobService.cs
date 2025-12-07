using Microsoft.Data.SqlClient;
using ProgrammingInCshrpBaseBackend.Interfaces;
using ProgrammingInCshrpBaseBackend.Models;

namespace ProgrammingInCshrpBaseBackend.Services
{
    public class JobService : IBaseService<Job>
    {
        private List<Job> jobs = new List<Job> ();
        public void Add(Job job)
        {
            //jobs.Add(job);

            const string ConectionString = "Server=.;Database=ProgrammingCSharp0407Db;Integrated Security=True;TrustServerCertificate=True;";

            using(SqlConnection sqlConnection = new SqlConnection(ConectionString))              
            {
                
                sqlConnection.Open ();
                //string Query = 
            }
}

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Job> GetAll()
        {
            return jobs; 
        }

        public void Update(Job item)
        {
            throw new NotImplementedException();
        }
    }
}
