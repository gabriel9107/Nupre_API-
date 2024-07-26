using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public interface IRepositorioMunicipioTrans
    {
        Task<List<ComunesMunicipiosCatum>> obtenerMunicipios();
        Task<List<ComunesProvinciasCatum>> obtenerProvincias();
    }
}