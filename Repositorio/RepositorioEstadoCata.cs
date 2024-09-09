using Microsoft.EntityFrameworkCore;
using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public class RepositorioEstadoCata : IRepositorioEstadoCata
    {
        private readonly ApplicationDbContext context;
        public RepositorioEstadoCata(ApplicationDbContext context)
        {
            this.context = context; 
        }

        public async Task<List<Profesionales_Estados_Cata>> obtenerEstados()
        {
            return await context.profesionales_Estados_Catas.Where(x => x.Registro_Estado == "A").ToListAsync(); 

        }

        public async Task<Profesionales_Estados_Cata> obtenerEstadosPorId(int estado_numero)
        {
            return await context.profesionales_Estados_Catas.Where(x => x.Registro_Estado == "A" && x.Profesional_Estado_Numero == estado_numero).FirstOrDefaultAsync();

        }

    }

}
