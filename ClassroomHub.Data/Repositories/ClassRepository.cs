using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;

namespace ClassroomHub.Data.Repositories
{
    public class ClassRepository : BaseRepository<Class>, IClassRepository
    {
        public ClassRepository(Context context) : base(context)
        {
        }
    }
}
