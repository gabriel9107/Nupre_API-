﻿using Microsoft.EntityFrameworkCore;
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
            modelBuilder.Entity<ProfesionalesSolicitudesTran>().HasKey(entity => new
            {
                entity.SolicitudNumero
            });
            modelBuilder.Entity<ProfesionalesEspecialidadesCata>().HasKey(entity => new
            {
                entity.EspecialidadNumero
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

            //modelBuilder.Entity<ProfesionalesSolicitudesTran>().HasKey()
        }

        public DbSet<ProfesionalesSolicitudesTran> profesionalesSolicitudesTrans { get; set; }
        public DbSet<ProfesionalesEspecialidadesCata> profesionalesEspecialidadesCata { get; set; }
        public DbSet<TssCiudadanosMaster> TSS_Ciudadanos_Master    { get; set; }
        public DbSet<TssTrabajadoresTran> TSS_Trabajadores_Trans   { get; set; }
        public DbSet<TssEmpleadoresMaster> TSS_Empleadores_Master  { get; set; }
        public DbSet<ComunesMunicipiosCatum> Comunes_Municipios_Cata { get; set; }
        public DbSet<ComunesProvinciasCatum> Comunes_Provincias_Cata { get; set; }

        public DbSet<TSSNacionalidadesCata> TSS_Nacionalidades_Cata { get; set; }

        public DbSet<Profesionales_Documento_Master> Profesionales_Documento_Masters { get; set; }
        public DbSet<Profesionales_Requerimiento_Cata> Profesionales_Requerimientos_Cata { get; set; }



    }
}
