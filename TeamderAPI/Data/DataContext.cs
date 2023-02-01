using Microsoft.EntityFrameworkCore;
using TeamderAPI.Models;

namespace TeamderAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }
    }
}
