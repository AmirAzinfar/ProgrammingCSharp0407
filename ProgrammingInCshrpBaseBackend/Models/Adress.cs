
using ProgrammingInCshrpBaseBackend.Abstractions;


namespace ProgrammingInCshrpBaseBackend.Models
{
    public class Adress : BaseEntity
    {
        public Adress() :base()
        {
        }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int PostalCode { get; set; }
    }
}