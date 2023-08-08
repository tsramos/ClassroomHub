using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassroomHub.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;

        public ActivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        public void Add(Activity activity)
        {
            _activityRepository.Add(activity);
        }

        public IEnumerable<Activity> GetAllWithModules(Guid teacherId)
        {
            return _activityRepository.GetAllWithModules().Where(x => x.Module.TeacherId == teacherId);
        }

        public Activity GetById(Guid id) => 
            _activityRepository.GetById(id);
        
    }
}
