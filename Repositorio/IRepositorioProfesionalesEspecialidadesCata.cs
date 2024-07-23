using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public interface IRepositorioProfesionalesEspecialidadesCata
    {
        Task<bool> Existe(int id);
        Task<ProfesionalesEspecialidadesCata> ObtenerPorId(int id);
        Task<List<ProfesionalesEspecialidadesCata>> ObtenerPorTipo(int id);
        Task<List<ProfesionalesEspecialidadesCata>> ObtenerTodos();
    }
}