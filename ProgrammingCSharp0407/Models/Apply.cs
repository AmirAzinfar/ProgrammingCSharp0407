using ProgrammingCSharp0407.Abstractions;
using ProgrammingCSharp0407.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCSharp0407.Models
{
    internal class Apply : BaseEntity
    {
        // public int Id { get; set; } beacuse Inheritance from BaseEntity
        public User User { get; set; }
        public Job Job { get; set; }
        public UploadDoc UploadDoc { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Count { get; set; }
        public ApplyStatus Status { get; set; } // data type in this case let me better describe it with Enum
        public string EMailSend { get; set; }
        public JobInterview? JobInterview { get; set; } // maby not invite to interview

    }
}
