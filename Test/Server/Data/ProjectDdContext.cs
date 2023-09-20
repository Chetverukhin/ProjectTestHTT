using Microsoft.EntityFrameworkCore;
using Test.Shared;

namespace Test.Server.Data
{
    public class ProjectDdContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public ProjectDdContext(DbContextOptions<ProjectDdContext> option) : base(option) 
        {
            Database.Migrate();
        }        
    }
}
