using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;

namespace ClassroomHub.Core.Contracts.Repositories
{
    public interface IStudentRepository : IBaseRepository<Student>
    {
        IEnumerable<Student> GetFullStudents();
        Student GetFullObjectById(Guid id);
    }
}
