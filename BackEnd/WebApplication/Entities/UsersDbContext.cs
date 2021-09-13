using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
