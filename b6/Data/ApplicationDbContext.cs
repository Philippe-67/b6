using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using b6.Models;

namespace b6.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<b6.Models.Voiture> Voiture { get; set; } = default!;
        public DbSet<b6.Models.Reparation> Reparation { get; set; } = default!;
    }
}