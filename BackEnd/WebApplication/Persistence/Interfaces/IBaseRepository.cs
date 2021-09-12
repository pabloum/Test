﻿using Entities.Entities;
using System.Collections.Generic;

namespace Persistence.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Filter(string filter);
        T Create(T entity);
    }
}
