using System;
using System.Collections.Generic;

namespace ClassroomHub.Core.Entities
{
    public class Activity : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int ActivityScore { get; set; }
        public Guid ModuleId { get; set; }
        public Module Module { get; set; }
        public IEnumerable<Delivery> Deliveries { get; set; }

    }
}
