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
        public string Street {get; set;}
        public string HouseNumber {get; set;}
        public string PostalCode {get; set;}

        public Adress (string street, string houseNumber, string postalCode)
        {
            Street = street;
            HouseNumber = houseNumber;
            PostalCode = postalCode;
        }
    }
}