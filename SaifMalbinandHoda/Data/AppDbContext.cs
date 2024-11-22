using Microsoft.EntityFrameworkCore;
using SaifMalbinandHoda.Models;

namespace SaifMalbinandHoda.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options){}
        public DbSet<Movies>? Movies { get; set; }
        public DbSet<Directos>? Directos { get; set; }
        public DbSet<Nationalities>? Nationalities { get; set; }
        public DbSet<Categories>? Categories { get; set; }

    }
}
