using Persistence.Entities;
using System.Collections.Generic;

namespace Persistence.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IEnumerable<User> GetAll();
        IEnumerable<User> Filter(string filter);
        IEnumerable<User> Create(T entity);
    }
}
