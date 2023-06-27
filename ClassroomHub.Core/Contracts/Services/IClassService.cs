using ClassroomHub.Core.Entities;
using System.Collections.Generic;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface IClassService
    {
        IEnumerable<Class> GetAll();
        void Add(Class entity);
    }
}
