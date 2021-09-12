using Persistence.Entities;
using Persistence.Interfaces;
using System.Collections.Generic;

namespace Persistence.Repositories
{
    public class BaseRepository : IBaseRepository<BaseEntity>
    {
        public IEnumerable<User> Create(BaseEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> Filter(string filter)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
