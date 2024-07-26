using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public interface IRepositorioCiudadanoTrans
    {
        Task<bool> Existe(string Ndocumento);
        Task<TssCiudadanosMaster> obtenerCiudadano(string ndocumento);
    }
}