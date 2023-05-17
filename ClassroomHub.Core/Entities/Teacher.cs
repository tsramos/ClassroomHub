using System;
using System.Collections.Generic;

namespace ClassroomHub.Core.Entities
{
    internal class Teacher
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        List<Module> Modules { get; set; }
    }
}
