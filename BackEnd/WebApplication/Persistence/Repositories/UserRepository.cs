using Entities;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        protected readonly DbContextOptions<UsersDbContext> _db;

        public UserRepository(DbContextOptions<UsersDbContext> db)
        {
            _db = db;
        }

        public User Create(User user)
        {
            using (var context = new UsersDbContext(_db))
            {
                user.Id = context.User.Max(u => u.Id) + 1;
                context.User.Add(user);
                context.SaveChanges();
                return user;
            }
        }

        public IEnumerable<User> Filter(string filter)
        {
            using (var context = new UsersDbContext(_db))
            {
                var users = context.User.AsNoTracking();
                users = users.Where(u => u.Username.Contains(filter) || u.FirstName.Contains(filter) || u.LastName.Contains(filter));
                return users.ToList();
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (var context = new UsersDbContext(_db))
            {
                var users = context.User.AsNoTracking().ToList();
                return users;
            }
        }
    }
}
