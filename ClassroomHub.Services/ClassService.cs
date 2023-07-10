using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;

namespace ClassroomHub.Services
{
    public class ClassService : IClassService
    {
        private readonly IClassRepository _classRepository;

        public ClassService(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public IEnumerable<Class> GetAll()
        {
            return _classRepository.GetAll();
        }

        public void Add(Class entity)
        {
            //podemos adicionar no futro meios de validar isso tudo.
            _classRepository.Add(entity);
        }

        public IEnumerable<Class> GetAllByCourseId(Guid courseId)
        {
            return _classRepository.GetClassesByCourseId(courseId);
        }
    }
}
