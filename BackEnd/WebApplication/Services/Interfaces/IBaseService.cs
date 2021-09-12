using Persistence.Entities;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IBaseService<T>  where T : BaseEntity
    {
        IEnumerable<User> GetAll();
        IEnumerable<User> Filter(string filter);
        IEnumerable<User> Create(T entity);
    }
}
