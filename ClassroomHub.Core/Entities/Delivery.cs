using System;

namespace ClassroomHub.Core.Entities
{
    public class Delivery : EntityBase
    {
        public DateTime DeliveyDate { get; set; }
        public string Resolution { get; set; }
        public int Grade { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Activity Activity { get; set; }
        public Guid ActivityId { get; set; }
    }
}
