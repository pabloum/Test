﻿using Persistence.Entities;
using Persistence.Interfaces;

namespace Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
    }
}
