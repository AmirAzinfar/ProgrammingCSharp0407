using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCSharp0407.Abstractions
{
    internal abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
