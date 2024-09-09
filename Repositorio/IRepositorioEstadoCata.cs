using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public interface IRepositorioEstadoCata
    {
        Task<List<Profesionales_Estados_Cata>> obtenerEstados();
        Task<Profesionales_Estados_Cata> obtenerEstadosPorId(int estado_numero);
    }
}