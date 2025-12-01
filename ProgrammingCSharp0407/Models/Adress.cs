using ProgrammingCSharp0407.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp0407.Models
{
    internal class Adress :BaseEntity
    {
        public Adress() :base()
        {
        }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int PostalCode { get; set; }
    }
}
