using Entities.DTOs;
using Entities.Entities;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IUserService 
    {
        IEnumerable<UserDTO> GetAll();
        IEnumerable<UserDTO> Filter(string filter);
        UserDTO Create(UserDTO entity);
        UserDTO GetById(int id);
    }
}
