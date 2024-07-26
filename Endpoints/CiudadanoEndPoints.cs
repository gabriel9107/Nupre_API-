using Microsoft.AspNetCore.Http.HttpResults;
using Nupre_API.Entidades;
using Nupre_API.Repositorio;

namespace Nupre_API.Endpoints
{
    public static class CiudadanoEndPoints
    {
        public static RouteGroupBuilder mapCiudadano(this RouteGroupBuilder group)
        {
            group.MapGet("obtenerCiudadano/{id:int}", obtenerCiudadano);
            group.MapGet("/{id:int}", getCiudadano);

            //group.MapGet("obtenerCiudadano/{id:int}", obtenerCiudadano);
            return group;
        }

        public static async Task<Results<Ok<TssCiudadanosMaster>, NotFound>> getCiudadano(IRepositorioCiudadanoTrans repositorio, int id)
        {
            var documento = id.ToString();
            var cidadano = await repositorio.obtenerCiudadano(documento);
            return TypedResults.Ok(cidadano);
        }




        //static async Task<Ok<List<TssCiudadanosMaster>>> ObtenerTodos(IRepositorioCiudadanoTrans repositorio)
        //{
        //    var profesionales = await repositorio.obtenerCiudadano();
        //    return TypedResults.Ok(profesionales);

        //}

        static async Task<Results<Ok<TssCiudadanosMaster>, NotFound>> obtenerCiudadano(IRepositorioCiudadanoTrans repositorio, int id)
        {
            var documento = id.ToString();
            var ciudadano = await repositorio.obtenerCiudadano(documento);
            if (ciudadano is null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(ciudadano);
        }
    }
}
