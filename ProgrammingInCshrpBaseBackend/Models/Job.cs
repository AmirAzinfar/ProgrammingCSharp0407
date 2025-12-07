using ProgrammingInCshrpBaseBackend.Abstractions;


namespace ProgrammingInCshrpBaseBackend.Models;

//Relationships of class Job and BaseEntity "is a" --> Inheritance

public class Job : BaseEntity
{
    //Relationships of class Job and Base "is a" --> Inheritance

    public Job() : base() 
    {
    }
    public Job(string fieldOfJob, string titelOfJob, string provinceWorkplace, string cityWorkplace) :this()
    {
        FieldOfJob = fieldOfJob;
        TitelOfJob = titelOfJob;   
        ProvinceWorkplace = provinceWorkplace;
        CityWorkplace = cityWorkplace;
    }


    //public int Id { get; set; } beacuse inhertance from BaseEntity
    public string FieldOfJob {get; set;}
    public string TitelOfJob {get; set;}
    public string Salary {get; set;}
    public string TimeWorkingHours {get; set;}
    public string ProvinceWorkplace {get; set;}
    public string CityWorkplace {get; set;}
    public DateTime DateOfStart {get; set;}
    public string ChoiceStart {get; set;}

}


