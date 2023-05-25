using System;

namespace ClassroomHub.Core.Entities
{
    public class Delivery : EntityBase
    {
        public Guid ActivityId { get; set; }
        public Activity Activity { get; set; }
        public Guid StudentId  { get; set; }
        public Student Student { get; set; }
        public DateTime SubmissionDate { get; set; }
    }
}
