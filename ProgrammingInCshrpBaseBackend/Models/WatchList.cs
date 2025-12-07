
using ProgrammingInCshrpBaseBackend.Abstractions;


namespace ProgrammingInCshrpBaseBackend.Models
{
    //Relationships of class WatchList and BaseEntity "is a" --> Inheritance

    public class WatchList : BaseEntity
    {
        //class WatchList "has a" Relationships of Compsition with User,Job

        //public int Id { get; set; } beacuse inhertance from BaseEntity
        public User User {get; set;}
        public Job Job {get; set;}
        public string Description {get; set;}
    }
}
