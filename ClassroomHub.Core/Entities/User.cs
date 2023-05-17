using System;

namespace ClassroomHub.Core.Entities
{
    internal class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
