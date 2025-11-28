using ProgrammingCSharp0407.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCSharp0407.Models
{
    internal class UploadDoc : BaseEntity
    {
        // public int Id { get; set; } beacuse inhertance from BaseEntity
        public string Motivation {  get; set; }
        public string Edjucation { get; set; }
        public string WorkExperience { get; set; }
        public string CV {  get; set; }
        public string EmploymentReference { get; set; }
    }
}
