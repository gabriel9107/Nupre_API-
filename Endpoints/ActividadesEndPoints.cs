using Microsoft.AspNetCore.Http.HttpResults;
using Nupre_API.DTOs;
using Nupre_API.Entidades;
using Nupre_API.Repositorio;

namespace Nupre_API.Endpoints
{
    public static class ActividadesEndPoints
    {

        public static RouteGroupBuilder mapActividades(this RouteGroupBuilder group)
        {
            //group.MapGet("GetProgressBar", );
            group.MapPost("PostProgressBar", Crear);
            group.MapGet("GetProgressBar", obtenerTodas);

            return group;
        }

        static async Task<Created<Solicitudes_Actividades_Trans>> Crear(Solicitudes_Actividades_Trans actividad, IRepositorioProfesionalesActividadesTrans repositorio)
        {
            var id = repositorio.Crear(actividad);
            return TypedResults.Created($"{id}", actividad);
        }

        static async Task<Ok<List<Solicitudes_Actividades_Progress_DTO>>> obtenerTodas(int solicitudNumero, IRepositorioProfesionalesActividadesTrans repositorio)
        {
            var query = await repositorio.obtener_Progreso_solicitudes(solicitudNumero);


            return TypedResults.Ok(query);
        }

        




    }
}
