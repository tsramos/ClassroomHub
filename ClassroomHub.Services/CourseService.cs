using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System.Collections.Generic;

namespace ClassroomHub.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public void Add(Course course)
        {
            _courseRepository.Add(course);
        }

        public IEnumerable<Course> GetAll() => _courseRepository.GetAll();

    }
}
