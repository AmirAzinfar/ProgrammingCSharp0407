using ProgrammingCSharp0407.Abstractions;
using ProgrammingCSharp0407.Enums;

namespace ProgrammingCSharp0407.Models
{
    internal class Apply : BaseEntity
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
