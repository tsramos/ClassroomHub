using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;

namespace ClassroomHub.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : EntityBase
    {
        public void Add(T entity) 
        {
        }

        public T GetById(Guid id)
        {
            return null;
        }

        public IEnumerable<T> GetAll()
        {
            return null;
        }
        public void Update(T entity) { }

        public void Delete(Guid id) { }

    }
}
