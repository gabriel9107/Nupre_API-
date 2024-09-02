using Microsoft.EntityFrameworkCore;
using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public class RepositorioNacionalidad : IRepositorioNacionalidad
    {
        private ApplicationDbContext context;
        public RepositorioNacionalidad(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<TSSNacionalidadesCata>> obtenerNacionalidad()
        {
            return await context.TSS_Nacionalidades_Cata.Where(cata => cata.Registro_Estado == "A").
                ToListAsync();
        }
    }
}
