﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nupre_API;

#nullable disable

namespace Nupre_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240610125555_ProfesionalesSolicitudesTrans")]
    partial class ProfesionalesSolicitudesTrans
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Nupre_API.Entidades.ProfesionalesSolicitudesTran", b =>
                {
                    b.Property<int>("ProfesionalesSolicitudesTranId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfesionalesSolicitudesTranId"));

                    b.Property<int>("AsociacionRegistroPatronal")
                        .HasColumnType("int");

                    b.Property<byte>("MotivoNumero")
                        .HasColumnType("tinyint");

                    b.Property<short>("MunicipioNumero")
                        .HasColumnType("smallint");

                    b.Property<short>("NacionalidadNumero")
                        .HasColumnType("smallint");

                    b.Property<string>("ProfesionalDireccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfesionalDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfesionalExequatur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfesionalMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfesionalNombreCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfesionalSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfesionalTelefono1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfesionalTelefono2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfesionalTelefono3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistroEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistroFecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegistroUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolicitudActualizarDatos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolicitudCertificadoNumero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SolicitudEstadoFecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("SolicitudEstadoNota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("SolicitudEstadoNumero")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("SolicitudFecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("SolicitudNumero")
                        .HasColumnType("int");

                    b.Property<string>("SolicitudUsuarioCuenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfesionalesSolicitudesTranId");

                    b.ToTable("profesionalesSolicitudesTrans");
                });
#pragma warning restore 612, 618
        }
    }
}
