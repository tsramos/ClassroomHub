using System.Collections.Generic;

namespace ClassroomHub.Core.Entities
{
    internal class Course
    {
        public string Name { get; set; }
        public string Description { get; set; }
        List<Student> Students { get; set; }        
    }
}
