using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public interface IRepositorioPrestadoras_Master
    {
        Task<List<Prestadoras_Master>> obtenerPrestadoras();

    }
}
