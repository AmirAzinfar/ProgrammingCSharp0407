
using ProgrammingInCshrpBaseBackend.Abstractions;


namespace ProgrammingInCshrpBaseBackend.Models
{
    public class WatchList : BaseEntity
    {
        //public int Id { get; set; } beacuse inhertance from BaseEntity
        public User User { get; set; }
        public Job Job { get; set; }
        public string Description { get; set; }
    }
}
