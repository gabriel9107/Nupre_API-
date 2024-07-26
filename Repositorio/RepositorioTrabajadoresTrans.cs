using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Nupre_API.Models;

namespace Nupre_API.Repositorio
{
    public class RepositorioTrabajadoresTrans : IRepositorioTrabajadoresTrans
    {
        private readonly SimonContext context;
        public RepositorioTrabajadoresTrans(SimonContext contex)
        {
            this.context = contex;

        }
        public async Task<TssTrabajadoresTran> obtenerEmpleado(long nss, int idRegistroPatronal)
        {
            return context.TssTrabajadoresTrans.Where(t => t.TrabajadorNss == nss).FirstOrDefault();
        }

        /// <summary>
        /// Regresa una lista de todos los trabajadores activo en la institucion 
        /// </summary>
        /// <param Registro Patronal="idRegistroPatronal"></param>
        /// <returns></returns>
        public async Task<List<TssTrabajadoresTran>> obtenerTodos(int idRegistroPatronal)
        {
            return await context.TssTrabajadoresTrans.Where(t => t.EmpleadorRegistroPatronal == idRegistroPatronal && t.RegistroEstado == "A").ToListAsync();
        }



        public async Task<bool> Existe(int id)
        {
            return await context.TssTrabajadoresTrans.Where(t => t.RegistroEstado == "A").AnyAsync(t => t.TrabajadorNss == id);
        }
    }
}
