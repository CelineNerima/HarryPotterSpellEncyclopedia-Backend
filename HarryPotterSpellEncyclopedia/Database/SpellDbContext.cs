using Microsoft.EntityFrameworkCore;
using HarryPotterSpellEncyclopedia.Models;

namespace HarryPotterSpellEncyclopedia.Database
{
    public class SpellDbContext : DbContext
    {
        public SpellDbContext(DbContextOptions<SpellDbContext> options) : base(options) { }

        public DbSet<Spells> Spells { get; set; } 
                        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Spells>().HasData(
                new Spells { Id = 1, Name = "Expelliarmus", Description = "Disarming Charm", Type = "Charm" },
                new Spells { Id = 2, Name = "Lumos", Description = "Light Producing Charm", Type = "Charm" }
            );
        }

    }
}
