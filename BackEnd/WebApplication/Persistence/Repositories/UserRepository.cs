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
                users = users.Where(u => u.Username.Contains(filter) || u.FirstName.Contains(filter) || u.LastName.Contains(filter))
                             .OrderBy(u => u.FirstName)
                             .ThenBy(u => u.LastName)
                             .ThenBy(u => u.Username)
                             .Take(10);
                return users.ToList();
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (var context = new UsersDbContext(_db))
            {
                var users = context.User.AsNoTracking()
                                 .OrderBy(u => u.FirstName)
                                 .ThenBy(u => u.LastName)
                                 .ThenBy(u => u.Username)
                                 .Take(10)
                                 .ToList();
                return users;
            }
        }

        public User GetById(int id)
        {
            using (var context = new UsersDbContext(_db))
            {
                var user = context.User.AsNoTracking().Where(u => u.Id == id).FirstOrDefault();
                return user;
            }
        }
    }
}
