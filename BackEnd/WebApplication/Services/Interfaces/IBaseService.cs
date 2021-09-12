using Persistence.Entities;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IBaseService<T>  where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Filter(string filter);
        IEnumerable<T> Create(T entity);
    }
}
