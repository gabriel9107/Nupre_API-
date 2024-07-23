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
            return await context.profesionalesEspecialidadesCata.FirstOrDefaultAsync(x => x.EspecialidadNumero == id);
        }
        public Task<List<ProfesionalesEspecialidadesCata>> ObtenerTodos()
        {
            return context.profesionalesEspecialidadesCata.ToListAsync();
        }
                    
        public Task<List<ProfesionalesEspecialidadesCata>> ObtenerPorTipo(int id)
        {
            return context.profesionalesEspecialidadesCata.Where(x => x.EspecialidadTipoNumero == id).ToListAsync();
        }

        public async Task<bool> Existe(int id)
        {
            return await context.profesionalesEspecialidadesCata.AnyAsync(x => x.EspecialidadProfesionNumero == id);
        }




    }
}
