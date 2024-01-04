using Digimash.Domain.Entities;
using Digimash.Domain.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Digimash.Infrastructure.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(UserSeeder.Data);
        }
    }
}