using Entities.DTOs;
using Entities.Entities;
using Entities.Util;
using Persistence.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Services
{
    public class UserService : IUserService
    {
        protected readonly IUserRepository _repo;

        public UserService(IUserRepository repo) 
        {
            _repo = repo;
        }

        public IEnumerable<UserDTO> GetAll()
        {
            try
            {
                var users = _repo.GetAll();
                return users.Select(u => u.ToDTO()).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public UserDTO Create(UserDTO dto)
        {
            try
            {
                var entity = dto.ToEntity();
                var createdUser = _repo.Create(entity);
                return createdUser.ToDTO();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<UserDTO> Filter(string filter)
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

    }
}
