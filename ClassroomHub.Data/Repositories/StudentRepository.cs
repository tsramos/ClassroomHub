using ClassroomHub.Core.Entities;
using ClassroomHub.Core.Contracts.Repositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ClassroomHub.Data.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        
        public StudentRepository(Context context) : base(context)
        {
        }

        public Student GetFullObjectById(Guid id)
        {
            return this.Get()
             .Include(x => x.Class)
             .ThenInclude(x => x.Modules)
             .ThenInclude(x => x.Activities)
             .FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Student> GetFullStudents()
        {
           return this.Get().Include(x => x.User);
        }
    }
}
