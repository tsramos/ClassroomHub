using System;
using System.Collections.Generic;

namespace ClassroomHub.Core.Entities
{
    internal class Class
    {
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<Student> Students { get; set; }
    }
}
