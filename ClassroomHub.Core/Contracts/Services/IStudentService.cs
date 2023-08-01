using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
        Student GetFullObjectById(Guid id);
        void Add(Student student);
    }
}
