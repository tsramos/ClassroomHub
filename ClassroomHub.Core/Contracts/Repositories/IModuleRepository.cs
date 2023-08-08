using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;

namespace ClassroomHub.Core.Contracts.Repositories
{
    public interface IModuleRepository : IBaseRepository<Module>
    {
        IEnumerable<Module> GetModulesByTeacherId(Guid id);
        IEnumerable<Module> GetDeliveriesByTeacherId(Guid teacherId);
    }
}
