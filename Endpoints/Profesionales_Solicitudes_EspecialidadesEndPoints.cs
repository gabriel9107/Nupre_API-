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
            group.MapPost("guardarTitulacion", Crear);
            group.MapGet("listadoTitulacion/{solicitud_numero}", obtenerListadoPorSolicitud);
            return group;
        }


        //public static async Task<Created<Profesionales_Solicitudes_Especialidades_Trans>> Crear(Profesionales_Solicitudes_Especialidades_Trans solicitud, IRepositorioProfesionalesEspecialidadesTrans repositorio)
        //{
        //    var id = await repositorio.Crear(solicitud);
        //    return TypedResults.Created($"/{id}", solicitud);
        //}

        public static async Task<Created<CrearProfesion_Especialidad_DTO>> Crear( CrearProfesion_Especialidad_DTO solicitud, IRepositorioProfesionalesEspecialidadesTrans repositorio, 
            IMapper mapper,IAlmacenadorArchivos almacenadorArchivos )
        {

            //if (solicitud.Tipo == 1)
            //{


            //}

            //var titulacion = mapper.Map<Profesionales_Solicitudes_Especialidades_Trans>(solicitud);
            //if(titulacion)


            //Pendeinte de arreglar
            //if(solicitud.documento is not null)
            //{
            //    var url = await almacenadorArchivos.Almacenar(contenedor, solicitud.documento );
            //    //solicitud.documento = url; 

            //}

            

            var titulacion = new Profesionales_Solicitudes_Especialidades_Trans
            {

                Solicitud_Numero = solicitud.Solicitud_Numero,
                Especialidad_Numero = (short)solicitud.Especialidad_Numero,
                Documento_Codigo = solicitud.Documento_Codigo,
                Registro_Usuario = "g.montero",
                Registro_Estado = "A",
                Especialidad_Estado_Numero = 1, 

            };


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


        public static async Task<Ok<List<Profesionales_Solicitudes_Especialidades_Trans>>> obtenerListadoPorSolicitud(IRepositorioProfesionalesEspecialidadesTrans repositorio, int solicitud_numero)
        {

            var titulos = await repositorio.obtenerTitulacionPorSolicitud(solicitud_numero);
            
            return TypedResults.Ok(titulos);
        }
         


    }
}
