using Entities.Entities;
using Entities.DTOs;
using Persistence.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Services.Services
{
    public class BaseService<T, DTO> : IBaseService<T, DTO> where T : BaseEntity where DTO : BaseDTO
    {
        readonly IBaseRepository<T> _repo;

        public BaseService(IBaseRepository<T> repo)
        {
            _repo = repo;
        }

        public IEnumerable<DTO> Create(DTO entity)
        {
            try
            {
                //var createdUser = _repo.Create(entity);
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<DTO> Filter(string filter)
        {
            try
            {
                var users = _repo.Filter(filter);
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<DTO> GetAll()
        {
            try
            {
                var users = _repo.GetAll();
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
