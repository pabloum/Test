using Entities.Entities;
using Persistence.Interfaces;
using System.Collections.Generic;

namespace Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public IEnumerable<T> Create(T entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> Filter(string filter)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
