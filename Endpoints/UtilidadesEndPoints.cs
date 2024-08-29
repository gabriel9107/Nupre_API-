using Microsoft.AspNetCore.Http.HttpResults;
using Nupre_API.Entidades;
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


            return group;
        }


        //pedientes
        //1 agregar metodo que busque la nacionalidad, recibiendo el id de nacionalidad 

        

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
        static async Task<Ok<List<ComunesMunicipiosCatum>>> obtenerMunicipio(IRepositorioMunicipioTrans repositorio)
        {
            var municipios = await repositorio.obtenerMunicipios();
            return TypedResults.Ok(municipios);
        }

        static async Task<Ok<List<ComunesProvinciasCatum>>> obtenerProvincias(IRepositorioMunicipioTrans repositorio)
        {
            var provincia = await repositorio.obtenerProvincias();
            return TypedResults.Ok(provincia);
        }
    }
}
