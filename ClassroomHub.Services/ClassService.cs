using ClassroomHub.Core.ApplicationExeception;
using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomHub.Services
{
    public class ClassService : IClassService
    {
        private readonly IClassRepository _classRepository;
        private Dictionary<string, string> ErrorMessages;

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
            try
            {
                ValidateClassEntity(entity);
            }
            catch (InvalidDateExeception e)
            {
                throw e;
            }

            _classRepository.Add(entity);
        }

        public IEnumerable<Class> GetAllByCourseId(Guid courseId)
        {
            return _classRepository.GetClassesByCourseId(courseId);
        }

        private void ValidateClassEntity(Class entity)
        {
            if (entity.End < entity.Start)
            {
                throw new InvalidDateExeception("Data de inicio da turma deve ser menor que a de encerramento.");
            }
        }
    }
}
