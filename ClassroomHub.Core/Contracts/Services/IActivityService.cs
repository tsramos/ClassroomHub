using System.Collections.Generic;
using ClassroomHub.Core.Entities;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface IActivityService
    {
        IEnumerable<Activity> GetAllWithModules();
        void Add(Activity activity);
    }
}
