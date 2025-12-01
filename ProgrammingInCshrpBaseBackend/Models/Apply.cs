
using ProgrammingInCshrpBaseBackend.Abstractions;

namespace ProgrammingInCshrpBaseBackend.Models
{
    //Relationships of class Applay and BaseEntity "is a" --> Inheritance
    public class Apply : BaseEntity
    {
        // public int Id { get; set; } beacuse Inheritance from BaseEntity
        public List<ApplyItem> ApplyItems { get; set; } 
        public User User { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public int Count { get; set; }

        //Relationships of class Applay and Base "is a" --> Inheritance

        public Apply() : base() 
        {
        }

    }
}
