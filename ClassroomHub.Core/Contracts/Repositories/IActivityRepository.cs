using ClassroomHub.Core.Entities;
using System.Collections.Generic;

namespace ClassroomHub.Core.Contracts.Repositories
{
    public interface IActivityRepository : IBaseRepository<Activity>
    {
        IEnumerable<Activity> GetAllWithModules();
    }
}
