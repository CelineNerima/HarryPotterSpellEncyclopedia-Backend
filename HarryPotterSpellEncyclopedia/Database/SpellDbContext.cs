using Microsoft.EntityFrameworkCore;
using HarryPotterSpellEncyclopedia.Models;

namespace HarryPotterSpellEncyclopedia.Database
{
    public class SpellDbContext : DbContext
    {
        public SpellDbContext(DbContextOptions<SpellDbContext> options) : base(options) { }

        public DbSet<Spell> Spells { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
