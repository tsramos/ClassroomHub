using System.Collections.Generic;
using ClassroomHub.Core.Entities;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface ICourseService
    {
        IEnumerable<Course> GetAll();
        void Add(Course course);
    }
}
