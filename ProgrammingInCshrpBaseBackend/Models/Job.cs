using ProgrammingInCshrpBaseBackend.Abstractions;


namespace ProgrammingInCshrpBaseBackend.Models;

//Relationships of class Job and BaseEntity "is a" --> Inheritance

public class Job : BaseEntity
{
    private object value;

    //Relationships of class Job and Base "is a" --> Inheritance

    public Job() : base() 
    {
    }
    public Job(string fieldOfJob, string titelOfJob,string salary, string provinceWorkplace, string cityWorkplace) :this()
    {
        FieldOfJob = fieldOfJob;
        TitelOfJob = titelOfJob;
        Salary = salary;
        ProvinceWorkplace = provinceWorkplace;
        CityWorkplace = cityWorkplace;
    }

    public Job(string fieldOfJob, string titelOfJob, string salary, string timeWorkingHours, string provinceWorkplace, string cityWorkplace, object value)
    {
        FieldOfJob = fieldOfJob;
        TitelOfJob = titelOfJob;
        Salary = salary;
        TimeWorkingHours = timeWorkingHours;
        ProvinceWorkplace = provinceWorkplace;
        CityWorkplace = cityWorkplace;
        this.value = value;
    }

    public Job (string fieldOfJob, string titelOfJob, string salary,string timeWorkingHours, string provinceWorkplace, string cityWorkplace, DateTime dateOfStart,string choiceStart) :this (fieldOfJob, titelOfJob, salary, provinceWorkplace, cityWorkplace)
    {
        FieldOfJob = fieldOfJob;
        TitelOfJob = titelOfJob;
        Salary = salary;
        TimeWorkingHours = timeWorkingHours;
        ProvinceWorkplace = provinceWorkplace;
        CityWorkplace = cityWorkplace;
        DateOfStart = dateOfStart;
        ChoiceStart = choiceStart;

    }

    //public int Id { get; set; } beacuse inhertance from BaseEntity
    public string FieldOfJob {get; set;}
    public string TitelOfJob {get; set;}
    public string Salary {get; set;}
    public string TimeWorkingHours {get; set;}
    public string ProvinceWorkplace {get; set;}
    public string CityWorkplace {get; set;}
    public DateTime? DateOfStart {get; set; }  //nullable
    public string ChoiceStart {get; set;}

}


