using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public class RepositorioProfesionalesEspecialidadesCata : IRepositorioProfesionalesEspecialidadesCata
    {
        private readonly ApplicationDbContext context;

        public RepositorioProfesionalesEspecialidadesCata(ApplicationDbContext context)
        {
            this.context = context;

        }

        public async Task<ProfesionalesEspecialidadesCata> ObtenerPorId(int id)
        {
            return await context.Profesionales_Especialidades_Cata.Where(a => a.Registro_Estado =="A").FirstOrDefaultAsync(x => x.Especialidad_Numero == id);
        }
        public Task<List<ProfesionalesEspecialidadesCata>> ObtenerTodos()
        {
            return context.Profesionales_Especialidades_Cata.ToListAsync();
        }

        public Task<List<Profesionales_Especialidades_Tipos_Cata>> ObtenerTipoProfesiones()
        {
            return context.Profesionales_Especialidades_Tipos_Cata.Where(p => p.Registro_Estado =="A").ToListAsync();
        }

        public Task<List<ProfesionalesEspecialidadesCata>> ObtenerPorTipo(int id)
        {
            return context.Profesionales_Especialidades_Cata.Where(x => x.Especialidad_Tipo_Numero == id).ToListAsync();
        }

        public async Task<bool> Existe(int id)
        {
            return await context.Profesionales_Especialidades_Cata.AnyAsync(x => x.Especialidad_Profesion_Numero == id);
        }

    }
}
