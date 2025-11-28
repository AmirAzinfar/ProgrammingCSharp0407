using ProgrammingCSharp0407.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCSharp0407.Models
{
    internal class WatchList : BaseEntity
    {
        //public int Id { get; set; } beacuse inhertance from BaseEntity
        public User User { get; set; }
        public Job Job { get; set; }
        public string Description { get; set; }
    }
}
