using ProgrammingCSharp0407.Interfaces;
using ProgrammingCSharp0407.Models;

namespace ProgrammingCSharp0407.Services
{
    internal class JobService : BaseService<Job>
    {
        private List<Job> jobs = new List<Job> ();
        public void Add(Job job)
        {
            jobs.Add(job);
        }

        public List<Job> GetAll()
        {
            return jobs; 
        }
    }
}
