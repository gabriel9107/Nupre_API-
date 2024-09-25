using Microsoft.EntityFrameworkCore;
using Nupre_API.Entidades;
using System;

namespace Nupre_API
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext(DbContextOptions options ): base(options)
        //{

        //}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Profesionales_Solicitudes_Tran>().HasKey(entity => new
            {
                entity.Solicitud_Numero
            });
            modelBuilder.Entity<Profesionales_Especialidades_Cata>().HasKey(entity => new
            {
                entity.Especialidad_Numero
            });
            modelBuilder.Entity<TssCiudadanosMaster>().HasKey(entity => new
            {
                entity.CiudadanoNss
            });
            modelBuilder.Entity<TssTrabajadoresTran>().HasKey(entity => new
            {
                entity.TrabajadorNss
            });

            modelBuilder.Entity<TssEmpleadoresMaster>().HasKey(entity => new
            {
                entity.EmpleadorRegistroPatronal
            });
            modelBuilder.Entity<ComunesMunicipiosCatum>().HasKey(entity => new
            {
                entity.MunicipioNumero
            });
            modelBuilder.Entity<ComunesProvinciasCatum>().HasKey(entity => new
            {
                entity.ProvinciaNumero
            });
            modelBuilder.Entity<TSSNacionalidadesCata>().HasKey(entity => new
            {
                entity.Nacionalidad_Numero
            });

            modelBuilder.Entity<Profesionales_Documento_Master>().HasKey(entidad => new
            {
                entidad.Documento_Codigo
            });
            modelBuilder.Entity<Profesionales_Requerimiento_Cata>().HasKey(entity => new
            {
                entity.Requerimiento_Numero
            });
            modelBuilder.Entity<Profesionales_Especialidades_Tipos_Cata>().HasKey(entity => new
            {
                entity.Especialidad_Tipo_Numero
            });


            modelBuilder.Entity<Profesionales_Especialidades_Cata>().HasKey(entity => new
            {
                entity.Especialidad_Numero
            });
            modelBuilder.Entity<Profesionales_Estados_Cata>().HasKey(entity => new
            {
                entity.Profesional_Estado_Numero
            });
            modelBuilder.Entity<Profesionales_Solicitudes_Especialidades_Trans>().HasKey(entity => new
            {
                entity.Solicitud_Numero, entity.Especialidad_Numero
            });
            modelBuilder.Entity<Profesionales_Asociaciones_Tipo_Cata>().HasKey(entidad => new 
            {
                entidad.Asociacion_Numero
            });
            modelBuilder.Entity<Profesionales_Solicitudes_Asociaciones_Tran>().HasKey(entity => new
            {
                entity.Solicitud_Numero
            });
             
        }

        public DbSet<Profesionales_Solicitudes_Tran> Profesionales_Solicitudes_Trans { get; set; }
        
        public DbSet<TssCiudadanosMaster> TSS_Ciudadanos_Master    { get; set; }
        public DbSet<TssTrabajadoresTran> TSS_Trabajadores_Trans   { get; set; }
        public DbSet<TssEmpleadoresMaster> TSS_Empleadores_Master  { get; set; }
        public DbSet<ComunesMunicipiosCatum> Comunes_Municipios_Cata { get; set; }
        public DbSet<ComunesProvinciasCatum> Comunes_Provincias_Cata { get; set; }

        public DbSet<TSSNacionalidadesCata> TSS_Nacionalidades_Cata { get; set; }

        public DbSet<Profesionales_Documento_Master> Profesionales_Documento_Masters { get; set; }
        public DbSet<Profesionales_Requerimiento_Cata> Profesionales_Requerimientos_Cata { get; set; }

        public DbSet<Profesionales_Especialidades_Tipos_Cata> Profesionales_Especialidades_Tipos_Cata { get; set; }
        public DbSet<Profesionales_Especialidades_Cata> Profesionales_Especialidades_Cata { get; set; }
        public DbSet<Profesionales_Solicitudes_Especialidades_Trans> Profesionales_Solicitudes_Especialidades_Trans { get; set; }

        public DbSet<Profesionales_Estados_Cata> profesionales_Estados_Catas { get; set; }

        public DbSet<Profesionales_Solicitudes_Asociaciones_Tran> Profesionales_Solicitudes_Asociaciones_Trans { get; set; }

        public DbSet<Profesionales_Asociaciones_Tipo_Cata>   Profesionales_Asociaciones_Catas { get; set; }  







    }
}
