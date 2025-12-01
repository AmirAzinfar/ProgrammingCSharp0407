using ProgrammingCSharp0407.Abstractions;


namespace ProgrammingCSharp0407.Models
{
    internal class JobInterview : BaseEntity
    {
        // public int Id { get; set; } beacuse inhertance from BaseEntity
        public string First_OnlineInterview { get; set; }
        public string Last_PresentInterview { get; set; }

        public JobInterview() : base() 
        {
        }

    }
}
