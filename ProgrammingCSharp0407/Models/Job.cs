using ProgrammingCSharp0407.Abstractions;


namespace ProgrammingCSharp0407.Models
{
    internal class Job : BaseEntity
    {
        public Job() : base() 
        {
        }
        public Job(string fieldOfJob, string titelOfJob, string provinzWorkplace, string cityWorkplace) :this()
        {
            FieldOfJob = fieldOfJob;
            TitelOfJob = titelOfJob;   
            ProvinzWorkplace = provinzWorkplace;
            CityWorkplace = cityWorkplace;
        }


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
