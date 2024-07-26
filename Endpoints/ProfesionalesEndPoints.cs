using Microsoft.AspNetCore.Http.HttpResults;
using Nupre_API.Repositorio;
using Nupre_API.Entidades;

namespace Nupre_API.Endpoints
{
    public static class ProfesionalesEndPoints
    {
        public static RouteGroupBuilder mapProfesionales(this RouteGroupBuilder group)
        {
            group.MapGet("obtenerTodosLasProfesionales/", ObtenerTodos).CacheOutput(c => c.Expire(TimeSpan.FromSeconds(15)).Tag("profesiones-get"));
            group.MapGet("obtenerProfesionesPorTipo/{id:int}", ObtenerPorTipo);
            return group;
        }

        static async Task<Ok<List<ProfesionalesEspecialidadesCata>>> ObtenerTodos(IRepositorioProfesionalesEspecialidadesCata repositorio)
        {
            var profesionales = await repositorio.ObtenerTodos();
            return TypedResults.Ok(profesionales);

        }

        static async Task<Ok<List<ProfesionalesEspecialidadesCata>>> ObtenerPorTipo(IRepositorioProfesionalesEspecialidadesCata repositorio, int id)
        {
            var profesionales = await repositorio.ObtenerPorTipo(id);

            return TypedResults.Ok(profesionales);
        }

    }
}
