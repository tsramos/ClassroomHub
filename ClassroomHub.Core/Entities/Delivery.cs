using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Entities
{
    internal class Delivery
    {
        public Guid ActivityId { get; set; }
        public Activity Activity { get; set; }
        public Guid StudentId  { get; set; }
        public Student Student { get; set; }
        public DateTime SubmissionDate { get; set; }
    }
}
