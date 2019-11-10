using HackatonApp.Data.Mappings;
using HackatonApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace HackatonApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Candidato> Candidatos { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CandidatoMap());
        }
    }
}
