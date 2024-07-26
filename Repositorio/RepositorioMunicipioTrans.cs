using Microsoft.EntityFrameworkCore;
using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public class RepositorioMunicipioTrans : IRepositorioMunicipioTrans
    {
        private readonly ApplicationDbContext context;
        public RepositorioMunicipioTrans(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<ComunesMunicipiosCatum>> obtenerMunicipios()
        {
            return await context.Comunes_Municipios_Cata.Where(c => c.RegistroEstado == "A").ToListAsync();
        }
        public async Task<List<ComunesProvinciasCatum>> obtenerProvincias()
        {
            return await context.Comunes_Provincias_Cata.Where(c => c.RegistroEstado == "A").ToListAsync();
        }


    }
}
