using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Nupre_API.DTOs;
using Nupre_API.Entidades;
using Nupre_API.Repositorio;
using Nupre_API.Servicios;

namespace Nupre_API.Endpoints
{
    public static class SolicitudesEndpoints
    {
        private static readonly string contenedor = "solicitud";
        public static RouteGroupBuilder  mapSolicitudes(this RouteGroupBuilder group)
        {

            group.MapGet("/", ObtenerTodos).CacheOutput(c => c.Expire(TimeSpan.FromSeconds(15)).Tag("solicitudes-get")); ;
            group.MapGet("obtenerSolicitudPorId/{id:int}", ObtenerPorId);
            group.MapPost("/", Crear);
            group.MapPost("crearSolicituDocumento", CrearSolicitudDocumento).DisableAntiforgery();
            group.MapPut("/{id:int}", Actualizar);
            return group; 
        }

        static async Task<Ok<List<Profesionales_Solicitudes_Tran>>> ObtenerTodos(IRepositorioProfesionalesSolicitudesTrans repositorio)
        {
            var profesionales = await repositorio.ObtenerTodos();
            return TypedResults.Ok(profesionales);

        }



        //static async Task<Results<Ok<DetalleSolicitudDTO>, NotFound>> obtenerDetalleSolicitud(IRepositorioProfesionalesSolicitudesTrans repositorio, int solicitudNumero)
        //{


        //}

        static async Task<Results<Ok<Profesionales_Solicitudes_Tran>, NotFound>> ObtenerPorId(IRepositorioProfesionalesSolicitudesTrans repositorio, int id)
        {
            var profesionales = await repositorio.ObtenerPorId(id);
            if (profesionales is null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(profesionales);
        }

        static async Task<Created<Crear_Profesionales_SolicitudesDTO>> CrearSolicitudDocumento([FromForm] Crear_Profesionales_SolicitudesDTO solicitudes,
            IRepositorioProfesionalesSolicitudesTrans repositorio, IOutputCacheStore outputCacheStore, 
            IMapper mapper, IAlmacenadorArchivos almacenadorArchivos)
        {

            solicitudes.Registro_Fecha = new DateTime(2022, 1, 1);
            solicitudes.Registro_Estado = "A";
            solicitudes.Registro_Usuario = "g.montero";
            solicitudes.Solicitud_Usuario_Cuenta = "g.montero";
            solicitudes.Solicitud_Estado_Numero = 1;
            solicitudes.Solicitud_Estado_Fecha = new DateTime(2022, 1, 1); ;


            var _solicitud = mapper.Map<Profesionales_Solicitudes_Tran>(solicitudes);

            if(solicitudes.Profesional_Documento is not null)
            {
                var url = await almacenadorArchivos.Almacenar(contenedor, solicitudes.Profesional_Documento);
            }




            //Completar datos para prueba 




            var id = await repositorio.Crear(_solicitud);

            await outputCacheStore.EvictByTagAsync("solicitudes-get", default);

            var actorDto = mapper.Map<Crear_Profesionales_SolicitudesDTO>(_solicitud);
            return TypedResults.Created($"/{id}", actorDto);
        }

        static async Task<Created<Profesionales_Solicitudes_Tran>> Crear(Profesionales_Solicitudes_Tran solicitudes, IRepositorioProfesionalesSolicitudesTrans repositorio, IOutputCacheStore outputCacheStore)
        {

            //Completar datos para prueba 
            solicitudes.Registro_Fecha = new DateTime(2022, 1, 1);
            solicitudes.Registro_Estado = "A";
            solicitudes.Registro_Usuario = "g.montero";
            solicitudes.Solicitud_Usuario_Cuenta = "g.montero";
            solicitudes.Solicitud_Estado_Numero = 1;
            solicitudes.Solicitud_Estado_Fecha = new DateTime(2022, 1, 1); ;




            var id = await repositorio.Crear(solicitudes);

            await outputCacheStore.EvictByTagAsync("solicitudes-get", default);
            return TypedResults.Created($"/{id}", solicitudes);
        }        
        static async Task<Results<NoContent, NotFound>> Actualizar(IRepositorioProfesionalesSolicitudesTrans repositorio,
            int id, Profesionales_Solicitudes_Tran trans, IOutputCacheStore outputCacheStore)
        {
            var existe = await repositorio.Existe(id);
            if (!existe)
            {
                return TypedResults.NotFound();
            }
            await repositorio.Actualizar(trans);
            await outputCacheStore.EvictByTagAsync("solicitudes-get", default);
            return TypedResults.NoContent();

        }
    }
}
