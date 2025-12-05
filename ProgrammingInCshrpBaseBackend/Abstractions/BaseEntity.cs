

namespace ProgrammingInCshrpBaseBackend.Abstractions
{
    public abstract class BaseEntity
    {
        //public Guid Id { get; set; }   //Guid: Globally Unique Identifier
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public BaseEntity()  //Seperation of concern
        {
            CreatedAt = DateTime.Now;
            //Id = Guid.NewGuid();
        }
    }
}
