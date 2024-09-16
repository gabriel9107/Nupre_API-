using Microsoft.EntityFrameworkCore;
using Nupre_API.Entidades;


namespace Nupre_API.Repositorio
{
    public class RepositorioProfesionalesSolcitiudesTrans : IRepositorioProfesionalesSolicitudesTrans
    {
        private readonly ApplicationDbContext context;
        public RepositorioProfesionalesSolcitiudesTrans(ApplicationDbContext context)
        {
            this.context = context; 
        }
        public async Task<Profesionales_Solicitudes_Tran> ObtenerPorId(int id)
        {
            return await context.Profesionales_Solicitudes_Trans.FirstOrDefaultAsync(x => x.Solicitud_Numero == id);
        }
        public Task<List<Profesionales_Solicitudes_Tran>> ObtenerTodos()
        {
            return context.Profesionales_Solicitudes_Trans.ToListAsync();
        }
        public async Task<int> Crear(Profesionales_Solicitudes_Tran trans)
        {
            context.Add(trans); 
            await context.SaveChangesAsync();
            return trans.Solicitud_Numero; 
        }
        public async Task Actualizar(Profesionales_Solicitudes_Tran profesionales)
        {
            context.Update(profesionales);
            await context.SaveChangesAsync();
        }
        public async Task<bool> Existe(int id)
        {
            return await context.Profesionales_Solicitudes_Trans.AnyAsync( x => x.Solicitud_Numero == id);   
        }

      
    }   
}
