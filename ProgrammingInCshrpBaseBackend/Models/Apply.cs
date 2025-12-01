
using ProgrammingInCshrpBaseBackend.Abstractions;

namespace ProgrammingInCshrpBaseBackend.Models
{
    public class Apply : BaseEntity
    {
        // public int Id { get; set; } beacuse Inheritance from BaseEntity
        public List<ApplyItem> ApplyItems { get; set; } 
        public User User { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public int Count { get; set; }
        

        public Apply() : base() 
        {
        }

    }
}
