using System;

namespace ClassroomHub.Core.Entities
{
    public class User : EntityBase
    {        
        public string Name { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
    }
}
