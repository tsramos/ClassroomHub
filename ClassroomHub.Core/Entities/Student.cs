using System;

namespace ClassroomHub.Core.Entities
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid ClassId { get; set; }
        public Class Class { get; set; }

    }
}
