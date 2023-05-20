using ClassroomHub.Core.Contracts;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;

namespace ClassroomHub.Services
{
    public class UserService : IUserService
    {
        public void Create(User user) { 

        }
        public void Update(User user)
        {

        }

        public User GetById(Guid id)
        {
            return new User();
        }
        public List<User> GetAll()
        {
            return new List<User>();    
        }
        public void Delete(Guid id)
        {

        }
    }
}
