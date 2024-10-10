using Microsoft.EntityFrameworkCore;
using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public class RepositorioPrestadoras_Master : IRepositorioPrestadoras_Master
    {
        private ApplicationDbContext context; 
        public RepositorioPrestadoras_Master(ApplicationDbContext context)
        {

            this.context = context;

        }

        public async Task<List<Prestadoras_Master>> obtenerPrestadoras()
        {
        return await context.Prestadoras_Master.Where(a => a.Registro_Estado == "A").ToListAsync();
        }
    }
}
