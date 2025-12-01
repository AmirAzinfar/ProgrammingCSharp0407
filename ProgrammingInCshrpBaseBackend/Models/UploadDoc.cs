
using ProgrammingInCshrpBaseBackend.Abstractions;


namespace ProgrammingInCshrpBaseBackend.Models
{
    //Relationships of class UploadDoc and BaseEntity "is a" --> Inheritance

    public class UploadDoc : BaseEntity
    {
        // public int Id { get; set; } beacuse inhertance from BaseEntity
        public string Motivation {  get; set; }
        public string Edjucation { get; set; }
        public string WorkExperience { get; set; }
        public string CV {  get; set; }
        public string EmploymentReference { get; set; }

        //Relationships of class UploadDoc and Base "is a" --> Inheritance

        public UploadDoc() :base()
        {
        }
    }
}
