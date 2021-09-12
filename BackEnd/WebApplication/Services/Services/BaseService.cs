using Entities.Entities;
using Entities.DTOs;
using Entities.Util;
using Persistence.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        readonly IBaseRepository<T> _repo;

        public BaseService(IBaseRepository<T> repo)
        {
            _repo = repo;
        }

        public BaseDTO Create(BaseDTO dto)
        {
            try
            {
                var entity = dto.ToEntity();
                var createdUser = _repo.Create((T)entity);
                return createdUser.ToDTO();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<BaseDTO> Filter(string filter)
        {
            try
            {
                var users = _repo.Filter(filter).Select(u => u.ToDTO());
                return users;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<BaseDTO> GetAll()
        {
            try
            {
                var users = _repo.GetAll().Select(u => u.ToDTO());
                return users;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
