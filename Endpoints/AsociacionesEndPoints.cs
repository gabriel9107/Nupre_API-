using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.Identity.Client;
using Nupre_API.DTOs;
using Nupre_API.Entidades;
using Nupre_API.Repositorio;
using Nupre_API.Servicios;

namespace Nupre_API.Endpoints
{
    public static class AsociacionesEndPoints
    {
        private static readonly string contenedor = "Asociaciones";
        public static RouteGroupBuilder mapAsociaciones(this RouteGroupBuilder group)
        {

            group.MapPost("", Crear).DisableAntiforgery();
            group.MapGet("obtenerAsociacionesPorId/{id:int}", obtenerPorId);

            group.MapGet("ListadoAsociaciones", obtenerTodos).CacheOutput(c => c.Expire(TimeSpan.FromSeconds(15)).Tag("Solicitud-asociaciones-get"));
            group.MapGet("obtenerListadoAsociaciones", obtenerListadoDeAsociaciones);

            return group;
        }

        static async Task<Created<Profesionales_Solicitudes_Asociaciones_Tran>> Crear([FromForm] CrearAsociacion_DTO transaccion, IRepositorioProfesionalesAsociacionesTrans repositorio,
            IOutputCacheStore outputCacheStore, IMapper mapper, IAlmacenadorArchivos almacenadorArchivos, IRepositorioComunesDocumentosMaster repositorioDocumentos)
        {
            CrearDocumentoComun_DTO _numeroDocumento  = new CrearDocumentoComun_DTO();
            int documento;

            var solicitud = mapper.Map<Profesionales_Solicitudes_Asociaciones_Tran>(transaccion);

            if (transaccion.Documento is not null)
                _numeroDocumento = await almacenadorArchivos.Almacenar_NombreArchivo(contenedor, transaccion.Documento);
          
            if (_numeroDocumento.Documento_ruta is not null)
            {
                _numeroDocumento.Tipo_Documento = 3;

                documento = await repositorioDocumentos.CrearDocumento(_numeroDocumento);

                solicitud.Documento_Codigo = documento.ToString(); 
            }
             
               

            var id = await repositorio.Crear(solicitud);
            await outputCacheStore.EvictByTagAsync("Solicitud-asociaciones-get", default);



            
            return TypedResults.Created(
                $"{id}", solicitud);
             
        }

        static async Task<Ok<List<Profesionales_Asociaciones_Tipo_Cata>>> obtenerListadoDeAsociaciones(IRepositorioProfesionalesAsociacionesTrans repositorio )
        {
            var query = await repositorio.obtenerListadoDeAsociaciones();

            return TypedResults.Ok(query);

        }


        static async Task<Ok<List<Profesionales_Solicitudes_Asociaciones_Tran>>> obtenerTodos(IRepositorioProfesionalesAsociacionesTrans repositorio, int solicitud_numero)
        {
            var query = await repositorio.obtenerTodos(solicitud_numero);

            return TypedResults.Ok(query);

        }


        public static async Task<Results<Ok<Profesionales_Solicitudes_Asociaciones_Tran>, NotFound>> obtenerPorId(IRepositorioProfesionalesAsociacionesTrans repositorio, int solicitud_numero)
        {
            var query = await repositorio.obtenerAsociacionPorId(solicitud_numero);

            if (query is null)
            {
                return TypedResults.NotFound();
            }

            return TypedResults.Ok(query);


        }





    }
}
