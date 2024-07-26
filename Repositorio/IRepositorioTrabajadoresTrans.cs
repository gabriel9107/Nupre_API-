using Nupre_API.Models;

namespace Nupre_API.Repositorio
{
    public interface IRepositorioTrabajadoresTrans
    {
        Task<bool> Existe(int id);
        Task<TssTrabajadoresTran> obtenerEmpleado(long nss, int idRegistroPatronal);
        Task<List<TssTrabajadoresTran>> obtenerTodos(int idRegistroPatronal);
    }
}