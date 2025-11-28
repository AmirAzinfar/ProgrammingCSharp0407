using ProgrammingCSharp0407.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCSharp0407.Models
{
    internal class Job : BaseEntity
    {
        //public int Id { get; set; } beacuse inhertance from BaseEntity
        public string FieldOfJob {  get; set; }
        public string TitelOfJob { get; set; }
        public string ProvinzWorkplace { get; set; }
        public string CityWorkplace { get; set; }
        public string Salary { get; set; }
        public string FullTimeWorkingHours {  get; set; }
        public string HalfTimeWorkingHours { get; set; }
        public DateTime DateOfStart {  get; set; }

    }
}
