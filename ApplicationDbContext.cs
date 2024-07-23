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
            modelBuilder.Entity<ProfesionalesEspecialidadesCata>().HasKey(entity => new
            {
                entity.EspecialidadNumero
            });
           
            //modelBuilder.Entity<ProfesionalesSolicitudesTran>().HasKey()
        }

        public DbSet<ProfesionalesSolicitudesTran> profesionalesSolicitudesTrans {  get; set; } 
        public DbSet<ProfesionalesEspecialidadesCata> profesionalesEspecialidadesCata { get; set; }

    }
}
