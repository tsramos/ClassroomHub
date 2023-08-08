using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassroomHub.Services
{
    public class ModuleService : IModuleService
    {
        private readonly IModuleRepository _moduleRepository;

        public ModuleService(IModuleRepository moduleRepository, ITeacherService teacherService)
        {
            _moduleRepository = moduleRepository;
        }
        public IEnumerable<Module> GetAll()
        {
            return _moduleRepository.GetAll();
        }

        public void Add(Module module)
        {
            _moduleRepository.Add(module);
        }

        public Module GetById(Guid id)
        {
            return _moduleRepository.GetById(id);
        }

        public IEnumerable<Module> GetModulesByTeacherId(Guid id)
        {
            return _moduleRepository.GetModulesByTeacherId(id);
        }

        public IEnumerable<Module> GetDeliveredActivitiesByTeacherId(Guid teacherId)
        {
            var modulesDB = _moduleRepository.GetDeliveriesByTeacherId(teacherId);
            List<Module> modules = new List<Module>();
            foreach (var module in modulesDB)
            {
                foreach (var activity in module.Activities)
                {
                    if (activity.Deliveries.Any())
                    {
                        modules.Add(new Module
                        {
                            Nome = module.Nome,
                            Id = module.Id, 
                            Activities = new List<Activity>()
                            {
                                new Activity
                                {
                                    Id = activity.Id,
                                    Description = activity.Description,
                                    DueDate = activity.DueDate,
                                    Title = activity.Title,
                                    Deliveries = activity.Deliveries,
                                }
                            }

                        });
                    }
                }
            }
            return modules;
        }

    }
}
