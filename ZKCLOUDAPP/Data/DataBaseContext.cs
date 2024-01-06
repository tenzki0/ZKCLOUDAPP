using Microsoft.EntityFrameworkCore;

namespace ZKCLOUDAPP
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
