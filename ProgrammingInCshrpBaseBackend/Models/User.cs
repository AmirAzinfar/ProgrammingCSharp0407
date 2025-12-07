using ProgrammingInCshrpBaseBackend.Abstractions;


namespace ProgrammingInCshrpBaseBackend.Models
{
    //Relationships of class User and BaseEntity "is a" --> Inheritance

    public class User : BaseEntity //entities
    {
        //Relationships of class User and Base "is a" --> Inheritance

        public User() : base() 
        {
        }
        public User(string nationalCode, string phoneNumber) :this() 
        {
            if (string.IsNullOrEmpty(nationalCode) || string.IsNullOrEmpty(phoneNumber))
            {
                throw new Exception();
            }

            NationalCode = nationalCode;
            PhoneNumber = phoneNumber;
        }
        public User(string firstName, string lastName, string nationalCode, string phoneNumber) : this (nationalCode, phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            NationalCode= nationalCode; 
            PhoneNumber= phoneNumber;
        }

        public User(string firstName, string lastName, DateTime birthDay, string nationalCode, string phoneNumber) : this(firstName,lastName,nationalCode,phoneNumber)
        {
            Birthday = birthDay;
        }

        //Access_Modifier Dtatype Name {get; set;}
        // public int Id { get; set; } beacuse inhertance from BaseEntity
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string NationalCode {get; set;}
        public string PhoneNumber {get; set;}
        public DateTime Birthday {get; set;}
    }
}
