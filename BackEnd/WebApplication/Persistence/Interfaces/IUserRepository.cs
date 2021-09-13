using Entities.Entities;
using System.Collections.Generic;

namespace Persistence.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        IEnumerable<User> Filter(string filter);
        User Create(User entity);
    }
}
