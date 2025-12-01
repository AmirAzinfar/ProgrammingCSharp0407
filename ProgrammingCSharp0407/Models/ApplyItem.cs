

using ProgrammingCSharp0407.Enums;

namespace ProgrammingCSharp0407.Models
{
    internal class ApplyItem         //Master & Details
    {
        public Apply Apply { get; set; }
        public Job Job { get; set; }
        public UploadDoc UploadDoc { get; set; }
        public ApplyStatus Status { get; set; } // data type in this case let me better describe it with Enum
        public int Count { get; set; }
        public string EMailSend { get; set; }
        public JobInterview? JobInterview { get; set; } // maby not invite to interview

    }
}
