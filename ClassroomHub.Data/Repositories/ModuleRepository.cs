using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassroomHub.Data.Repositories
{
    public class ModuleRepository : BaseRepository<Module>, IModuleRepository
    {
        public ModuleRepository(Context context) : base(context)
        {            
        }

        public IEnumerable<Module> GetModulesByTeacherId(Guid id)
        {
            return this.Get().Where(x => x.TeacherId == id);
        }
    }
}
