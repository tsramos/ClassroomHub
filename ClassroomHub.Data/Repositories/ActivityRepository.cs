using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ClassroomHub.Data.Repositories
{
    public class ActivityRepository : BaseRepository<Activity>, IActivityRepository
    {
        public ActivityRepository(Context context) : base(context)
        {
        }

        public IEnumerable<Activity> GetAllWithModules() => this.Get().Include(x => x.Module);
            
    }
}
