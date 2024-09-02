using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public class RepositorioRequerimientoDocumentoCata
    {
        private readonly ApplicationDbContext context;
        public RepositorioRequerimientoDocumentoCata(ApplicationDbContext context)
        {
            this.context = context;
        }

        
    }
}
