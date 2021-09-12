using Persistence.Entities;
using Persistence.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Services.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        readonly IBaseRepository<T> _repo;

        public BaseService(IBaseRepository<T> repo)
        {
            _repo = repo;
        }

        public IEnumerable<T> Create(T entity)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<T> Filter(string filter)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return _repo.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
