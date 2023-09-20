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
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Genre)
                .WithMany(g => g.Products)
                .HasForeignKey(p => p.GenreId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
