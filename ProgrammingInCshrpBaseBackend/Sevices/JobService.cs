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
        }

        public List<Job> GetAll()
        {
            return jobs; 
        }
    }
}
