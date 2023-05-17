using System;

namespace ClassroomHub.Core.Entities
{
    internal class Module
    {
        public string Nome { get; set; }
        public string Description { get; set; }
        public int Hours { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
