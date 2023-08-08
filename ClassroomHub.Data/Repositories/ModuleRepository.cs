using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Module> GetDeliveriesByTeacherId(Guid teacherId) =>        
            this.Get()
                .Include(x => x.Activities)
                .ThenInclude(x => x.Deliveries)
                .Where(x => x.TeacherId == teacherId).AsEnumerable();
        

        public IEnumerable<Module> GetModulesByTeacherId(Guid id)
        {
            return this.Get().Where(x => x.TeacherId == id);
        }
    }
}
