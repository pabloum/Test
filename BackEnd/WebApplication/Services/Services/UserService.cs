using Entities.DTOs;
using Entities.Entities;
using Persistence.Interfaces;
using Services.Interfaces;

namespace Services.Services
{
    public class UserService : BaseService<User, UserDTO>, IUserService
    {
        public UserService(IUserRepository repo) : base(repo)
        {
        }
    }
}
