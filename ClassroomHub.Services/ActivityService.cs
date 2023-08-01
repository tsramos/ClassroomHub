using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Contracts.Repositories;
using System.Collections.Generic;
using ClassroomHub.Core.Entities;

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

        public IEnumerable<Activity> GetAllWithModules()
        {
            return _activityRepository.GetAllWithModules();
        }
    }
}
