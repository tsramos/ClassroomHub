﻿using System.Collections.Generic;
using System;
using ClassroomHub.Core.Entities;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface IActivityService
    {
        IEnumerable<Activity> GetAllWithModules(Guid teacherId);
        Activity GetById(Guid id);
        void Add(Activity activity);
    }
}
