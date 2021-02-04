using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Steda_backend.Models;

// database context - main class that coordinates Entity Framework
// functionality for a data model
// it must registered with the DI container which provide
// the service to controllers
namespace Steda_backend.Models {
    public class AppDbContext : IdentityDbContext<AppUser> {
       public DbSet<Photo> Photos {get; set;}

       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}