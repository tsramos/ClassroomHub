using System;

namespace ClassroomHub.Core.Entities
{
    internal class Activity
    {
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Guid ModuleId { get; set; }
    }
}
