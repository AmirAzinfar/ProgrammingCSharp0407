
using ProgrammingInCshrpBaseBackend.Abstractions;


namespace ProgrammingInCshrpBaseBackend.Models;

//Relationships of class UploadDoc and BaseEntity "is a" --> Inheritance

public class UploadDoc : BaseEntity
{
    // public int Id { get; set; } beacuse inhertance from BaseEntity
    public byte[] Motivation {get; set;}
    public byte[] Education {get; set;}
    public byte[] JobExperience {get; set;}
    public byte[] CV {get; set;}
    public byte[] EmploymentReference {get; set;}
    //public DateTime? CreatedAt {get; set;}


    //Relationships of class UploadDoc and Base "is a" --> Inheritance

    public UploadDoc() :base()
    {
    }

}
