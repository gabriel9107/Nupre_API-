using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public interface IRepositorioNacionalidad
    {
        Task<List<TSSNacionalidadesCata>> obtenerNacionalidad();

    }
}
