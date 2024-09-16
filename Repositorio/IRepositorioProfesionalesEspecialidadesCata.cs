using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public interface IRepositorioProfesionalesEspecialidadesCata
    {
        Task<bool> Existe(int id);
        Task<Profesionales_Especialidades_Cata> ObtenerPorId(int id);
        Task<List<Profesionales_Especialidades_Cata>> ObtenerPorTipo(int id);
        Task<List<Profesionales_Especialidades_Cata>> ObtenerTodos();
        Task<List<Profesionales_Especialidades_Tipos_Cata>> ObtenerTipoProfesiones();
    }
}