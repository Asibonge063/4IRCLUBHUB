using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using nomthyApp.Models;

namespace nomthyApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<nomthyApp.Models.Category> Category { get; set; } = default!;
        public DbSet<Event> Events { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}

