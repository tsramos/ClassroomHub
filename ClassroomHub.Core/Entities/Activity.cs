using System;

namespace ClassroomHub.Core.Entities
{
    internal class Activity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int ActivityScore { get; set; }
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Guid ModuleId { get; set; }
        public Module Module { get; set; }
    }
}
