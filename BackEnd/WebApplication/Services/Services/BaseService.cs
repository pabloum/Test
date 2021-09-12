using Persistence.Entities;
using Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Services.Services
{
    public class BaseService : IBaseService<BaseEntity>
    {
        public IEnumerable<User> Create(BaseEntity entity)
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

        public IEnumerable<User> Filter(string filter)
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

        public IEnumerable<User> GetAll()
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
    }
}
