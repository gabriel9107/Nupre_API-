﻿using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.AspNetCore.Mvc;
using Nupre_API.DTOs;
using Nupre_API.Entidades;
using Nupre_API.Repositorio;
using Nupre_API.Servicios;
using Microsoft.AspNetCore.Builder;

namespace Nupre_API.Endpoints
{
    public static class Profesionales_Solicitudes_EspecialidadesEndPoints
    {
        private static readonly string contenedor = "Titulacion_Especialidades";
        public static RouteGroupBuilder mapProfesionalesEspecialidades(this RouteGroupBuilder group)
        {
            group.MapPost("/", Crear);
            return group;
        }


        //public static async Task<Created<Profesionales_Solicitudes_Especialidades_Trans>> Crear(Profesionales_Solicitudes_Especialidades_Trans solicitud, IRepositorioProfesionalesEspecialidadesTrans repositorio)
        //{
        //    var id = await repositorio.Crear(solicitud);
        //    return TypedResults.Created($"/{id}", solicitud);
        //}

        public static async Task<Created<CrearProfesion_Especialidad_DTO>> Crear([FromForm] CrearProfesion_Especialidad_DTO solicitud, IRepositorioProfesionalesEspecialidadesTrans repositorio, 
            IMapper mapper,IAlmacenadorArchivos almacenadorArchivos )
        {

            //if (solicitud.Tipo == 1)
            //{


            //}

            var titulacion = mapper.Map<Profesionales_Solicitudes_Especialidades_Trans>(solicitud);
            //if(titulacion)



            if(solicitud.documento is not null)
            {
                var url = await almacenadorArchivos.Almacenar(contenedor, solicitud.documento );
                //solicitud.documento = url; 
            
            }

            //var titulacion = new Profesionales_Solicitudes_Especialidades_Trans
            //{

            //    Solicitud_Numero = solicitud.Solicitud_Id,
            //    Especialidad_Numero = (short)solicitud.Especialidad_Id,
            //    Documento_Codigo = solicitud.Nombre_Documento,
            //    Registro_Usuario = "g.montero",
            //    Registro_Estado = "A", 
                 
            //};


            var id = await repositorio.Crear(titulacion);
            return TypedResults.Created($"/{id}", solicitud);
        }


        public static async Task<Results<Ok<Profesionales_Solicitudes_Especialidades_Trans>, NotFound>> obtenerEspecialidadestrans(IRepositorioProfesionalesEspecialidadesTrans repositorio, int id)
        {
            var titulacion = await repositorio.obtenerTitulacionPorId(id);
            if (titulacion is null)
            {
                return TypedResults.NotFound();

            }
            return TypedResults.Ok(titulacion);
        }




    }
}
