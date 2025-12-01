

namespace ProgrammingCSharp0407.Abstractions
{
    internal abstract class BaseEntity
    {
        public Guid Id { get; set; }   //Guid: Globally Unique Identifier
        public DateTime CreatedAt { get; set; }

        public BaseEntity()  //Seperation of concern
        {
            CreatedAt = DateTime.Now;
            Id = Guid.NewGuid();
        }
    }
}
