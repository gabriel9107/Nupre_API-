using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OutputCaching;
using Nupre_API.Entidades;
using Nupre_API.Repositorio;

namespace Nupre_API.Endpoints
{
    public static class SolicitudesEndpoints
    {
        public static RouteGroupBuilder  mapSolicitudes(this RouteGroupBuilder group)
        {

            group.MapGet("/", ObtenerTodos).CacheOutput(c => c.Expire(TimeSpan.FromSeconds(15)).Tag("solicitudes-get")); ;
            group.MapGet("obtenerSolicitudPorId/{id:int}", ObtenerPorId);
            group.MapPost("/", Crear);
            group.MapPut("/{id:int}", Actualizar);
            return group; 
        }

        static async Task<Ok<List<ProfesionalesSolicitudesTran>>> ObtenerTodos(IRepositorioProfesionalesSolicitudesTrans repositorio)
        {
            var profesionales = await repositorio.ObtenerTodos();
            return TypedResults.Ok(profesionales);

        }

        static async Task<Results<Ok<ProfesionalesSolicitudesTran>, NotFound>> ObtenerPorId(IRepositorioProfesionalesSolicitudesTrans repositorio, int id)
        {
            var profesionales = await repositorio.ObtenerPorId(id);
            if (profesionales is null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(profesionales);
        }

        static async Task<Created<ProfesionalesSolicitudesTran>> Crear(ProfesionalesSolicitudesTran solicitudes, IRepositorioProfesionalesSolicitudesTrans repositorio, IOutputCacheStore outputCacheStore)
        {

            var id = await repositorio.Crear(solicitudes);

            await outputCacheStore.EvictByTagAsync("solicitudes-get", default);
            return TypedResults.Created($"/{id}", solicitudes);
        }
        static async Task<Results<NoContent, NotFound>> Actualizar(IRepositorioProfesionalesSolicitudesTrans repositorio,
            int id, ProfesionalesSolicitudesTran trans, IOutputCacheStore outputCacheStore)
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
