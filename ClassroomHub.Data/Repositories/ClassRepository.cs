using ClassroomHub.Core.Entities;
using ClassroomHub.Core.Contracts.Repositories;
using System.ComponentModel;

namespace ClassroomHub.Data.Repositories
{
    public class ClassRepository : BaseRepository<Class>, IClassRepository
    {
        public ClassRepository(Context context) : base(context)
        {
        }
    }
}
