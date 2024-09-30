using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Nupre_API.DTOs;
using Nupre_API.Entidades;
using Nupre_API.Repositorio;

namespace Nupre_API.Endpoints
{
    public static class CiudadanoEndPoints
    {
        public static RouteGroupBuilder mapCiudadano(this RouteGroupBuilder group)
        {
            group.MapGet("obtenerCiudadano/{id:int}", obtenerCiudadano);
            group.MapGet("obtenerCiudadanoFiltro", ObtenerTodosFiltrada);
            group.MapGet("/{id:int}", getCiudadano);

            return group;
        }


        static async Task<Ok<TssCiudadanosMaster>> ObtenerTodosFiltrada(
                IRepositorioCiudadanoTrans repositorio
               , [AsParameters] Ciudadano_FiltroDTO filtros, IMapper mapper
               )
        {


            
            var resultado = await repositorio.obtenerCiudadanoFiltrado(filtros);

            return TypedResults.Ok(resultado);




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
