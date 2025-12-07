
using ProgrammingInCshrpBaseBackend.Abstractions;


namespace ProgrammingInCshrpBaseBackend.Models
{
    //Relationships of class JobInterview and BaseEntity "is a" --> Inheritance

    public class JobInterview : BaseEntity
    {
        // public int Id { get; set; } beacuse inhertance from BaseEntity
        public string First_OnlineInterview {get; set;}
        public string Last_PresentInterview {get; set;}

        //Relationships of class JobInterview and Base "is a" --> Inheritance

        public JobInterview() : base() 
        {
        }

    }
}
