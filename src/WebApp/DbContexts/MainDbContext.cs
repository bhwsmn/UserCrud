using Microsoft.EntityFrameworkCore;
using User = WebApp.Entities.User;

namespace WebApp.DbContexts
{
    public class MainDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        { }
    }
}
