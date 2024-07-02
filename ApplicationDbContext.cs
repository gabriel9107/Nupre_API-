using Microsoft.EntityFrameworkCore;
using Nupre_API.Entidades;

namespace Nupre_API
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options ): base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<ProfesionalesSolicitudesTran>().HasKey()
        }

        public DbSet<ProfesionalesSolicitudesTran> profesionalesSolicitudesTrans {  get; set; } 
    }
}
