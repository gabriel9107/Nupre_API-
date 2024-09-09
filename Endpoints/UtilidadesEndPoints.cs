using Microsoft.AspNetCore.Http.HttpResults;
using Nupre_API.Entidades;
//using Nupre_API.Models;
using Nupre_API.Repositorio;

namespace Nupre_API.Endpoints
{
    public static class UtilidadesEndPoints
    {
        public static RouteGroupBuilder mapUtilidades(this RouteGroupBuilder group)
        {
            group.MapGet("obtenerProvincias/", obtenerProvincias).CacheOutput(x => x.Expire(TimeSpan.FromSeconds(15)).Tag("privincias-get"));
            group.MapGet("obtenerMunicipios/", obtenerMunicipio).CacheOutput(x => x.Expire(TimeSpan.FromSeconds(15)).Tag("municipio-get"));
            group.MapGet("obtenerCiudadano/{id}", obtenerCiudadano);
            group.MapGet("obtenerNacionalidad", obtenerNacionalidad);
            group.MapGet("obtenerCatalogoProfesionales/{id}", obtenerCatalogoDeEspecilidades);
            group.MapGet("obtenerListadoEstado", obtenerListadoEstado);
            group.MapGet("ObtenerDescripcionEstado/{idEstado}", ObtenerDescripcionEstado);


            return group;
        }
         
        static async Task<Results<Ok<TssCiudadanosMaster>, NotFound>> obtenerCiudadano(IRepositorioCiudadanoTrans respositorio, string id)
        {
            var ciudadanoId = id.ToString();
            var ciudadano = await respositorio.obtenerCiudadano(ciudadanoId);
            if (ciudadano is null)
            {
                return TypedResults.NotFound();
            }

            return TypedResults.Ok(ciudadano);

        }
        static async Task<Ok<List<Entidades.ComunesMunicipiosCatum>>> obtenerMunicipio(IRepositorioMunicipioTrans repositorio)
        {
            var municipios = await repositorio.obtenerMunicipios();
            return TypedResults.Ok(municipios);
        }

        static async Task<Ok<List<Entidades.ComunesProvinciasCatum>>> obtenerProvincias(IRepositorioMunicipioTrans repositorio)
        {
            var provincia = await repositorio.obtenerProvincias();
            return TypedResults.Ok(provincia);
        }

        static async Task<Ok<List<TSSNacionalidadesCata>>> obtenerNacionalidad( IRepositorioNacionalidad repositorio)
        {
            var nacionalidad = await repositorio.obtenerNacionalidad();
            return TypedResults.Ok(nacionalidad); 
        }

        static async Task<Ok<List<ProfesionalesEspecialidadesCata>>> obtenerCatalogoDeEspecilidades(IRepositorioProfesionalesEspecialidadesCata repositorio, int id)
        {
            var catalogo = await repositorio.ObtenerPorTipo(id);
            return TypedResults.Ok(catalogo);
        }

        static async Task<Ok<List<Profesionales_Estados_Cata>>> obtenerListadoEstado(IRepositorioEstadoCata repositorio)
        {
            var catalogo = await repositorio.obtenerEstados();
            return TypedResults.Ok(catalogo);
        }
        /// <summary>
        /// Regresa la descripcion del estado en que se cuenta la solicitud.... 
        /// El mismo sera utilizado en la lista, o en el detalle de la solicitud. 
        /// </summary>
        static async Task<Ok<Profesionales_Estados_Cata>> ObtenerDescripcionEstado(IRepositorioEstadoCata repositorio, int idEstado)
        {
           var detalleEstado = await repositorio.obtenerEstadosPorId(idEstado);
            return TypedResults.Ok(detalleEstado); 
        }

    }
}
