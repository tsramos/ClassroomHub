using ClassroomHub.Core.Entities;
using System.Collections.Generic;
using System;
namespace ClassroomHub.Core.Contracts
{
    public interface IUserService
    {
        void Create(User user);
        List<User> GetAll();
        User GetById(Guid id);
        void Update(User user);
        void Delete(Guid id);    

    }
}
