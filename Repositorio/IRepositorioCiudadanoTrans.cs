using Nupre_API.DTOs;
using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public interface IRepositorioCiudadanoTrans
    {
        Task<bool> Existe(string Ndocumento);
        Task<TssCiudadanosMaster> obtenerCiudadano(string ndocumento);
        Task<TssCiudadanosMaster> obtenerCiudadanoFiltrado(Ciudadano_FiltroDTO filtro);
        //Task<Ciudadano_master_DTO> obtenerCiudadanoFiltrado(Ciudadano_FiltroDTO filtro);



    }
}