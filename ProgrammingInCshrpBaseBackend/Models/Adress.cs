
using ProgrammingInCshrpBaseBackend.Abstractions;


namespace ProgrammingInCshrpBaseBackend.Models
{
    //Relationships of class Adress and BaseEntity "is a" --> Inheritance
    public class Adress : BaseEntity
    {
        //Relationships of class Adress and Base "is a" --> Inheritance
        public Adress() :base()
        {
        }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int PostalCode { get; set; }
    }
}