using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain.DataModels;

namespace SamuraiApp.Data.Models
{
    public class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }
    }
}
