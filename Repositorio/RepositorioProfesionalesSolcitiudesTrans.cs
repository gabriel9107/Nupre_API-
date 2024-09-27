using Microsoft.EntityFrameworkCore;
using Nupre_API.DTOs;
using Nupre_API.Entidades;
using System.Diagnostics.Eventing.Reader;


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

        public async Task<List<Profesionales_Solicitudes_Tran>> getrequestsbyuser(Profesionales_Filtro_Listado_DTO filtro)
        {
            var query = context.Profesionales_Solicitudes_Trans.Where(x => x.Registro_Estado == "A" && x.Asociacion_Registro_Patronal == filtro.Empleador_Registro_Patronal);

            if (query is not null)
            {
                query = query.Where(x => x.Solicitud_Estado_Numero == filtro.Estado_Numero);
                //query = query.Where(x => x.Solicitud_Fecha.Date <= filtro.AnioFin.Date && x.Solicitud_Fecha.Date >= filtro.AnioInicio.Date);
            }
             else
            {
                query = context.Profesionales_Solicitudes_Trans.Where(x => x.Registro_Estado == "A" && x.Profesional_Documento == filtro.Cedula || x.Solicitud_Numero.ToString() == filtro.Solicitud_Numero); 
            }

            return await query.ToListAsync();   
        }
        public Task<List<Profesionales_Solicitudes_Tran>> ObtenerTodos()
        {
            return context.Profesionales_Solicitudes_Trans.ToListAsync();
        }
        public async Task<int> Crear(Profesionales_Solicitudes_Tran trans)
        {

            trans.Registro_Fecha = new DateTime(2022, 1, 1);
            trans.Registro_Estado = "A";
            trans.Registro_Usuario = "g.montero";
            trans.Solicitud_Usuario_Cuenta = "g.montero";
            trans.Solicitud_Estado_Numero = 1;
            trans.Solicitud_Estado_Fecha = new DateTime(2022, 1, 1); ;


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
