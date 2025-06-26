using Microsoft.EntityFrameworkCore;
using Solvo_Core.Models;

namespace Solvo_Repository.Context
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}
