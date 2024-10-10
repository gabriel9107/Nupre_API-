using Microsoft.AspNetCore.Http.HttpResults;
using Nupre_API.Entidades;
using Nupre_API.Repositorio;

namespace Nupre_API.Endpoints
{


    public static class  LocalidadesEndPoints
    {
        private static readonly string contenedor = "Localidades"; 

        public static RouteGroupBuilder mapProfesionales_Solicitudes_Localidades(this RouteGroupBuilder group)
        {

            group.MapPost("", Crear).DisableAntiforgery();
            group.MapGet("obtenerLocalidad", BuscarPorId);
            return group;
        }

        public static async Task<Created<Profesionales_Solicitudes_Localidades_Tran>> Crear(Profesionales_Solicitudes_Localidades_Tran trans, IRepositorioProfesionales_Solicitudes_Localidades_Tran repositorio )
        {

            var respuesta = await repositorio.Crear(trans);
            return TypedResults.Created($"/{respuesta.Solicitud_Numero}", respuesta);


        }  



        public static async Task<Results<Ok<Profesionales_Solicitudes_Localidades_Tran>, NotFound>> BuscarPorId(IRepositorioProfesionales_Solicitudes_Localidades_Tran repositorio, int id)
        {

            var query = await repositorio.obtenerId(id);
            //if(query is null)
            //{
            //    return TypedResults.NotFound(); 
            //}
            return TypedResults.Ok(query);
        }
    }
}
